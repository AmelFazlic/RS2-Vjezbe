using AutoMapper;
using eProdaja.Services.Database;
using eProdaja.Model;
using eProdaja.Model.Request;
using eProdaja.Model.SearchObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class KorisniciService : BaseCRUDService<Model.Korisnici, Database.Korisnici, KorisniciSearchObject, KorisniciInsertRequest, KorisniciUpdateRequest>, IKorisniciService
    {
        public KorisniciService(IMapper mapper, eProdajaContext context) : base(mapper, context)
        {
        }

        public override Model.Korisnici Insert(KorisniciInsertRequest obj)
        {
            if(obj.Password != obj.PasswordPotvrda)
            {
                throw new UserException("Password and Conformation are not the same");
            }

            var entity = base.Insert(obj);

            foreach (var UlogaId in obj.UlogeIdList)
            {
                Database.KorisniciUloge korisniciUloge = new Database.KorisniciUloge();

                korisniciUloge.KorisnikId = entity.KorisnikId;
                korisniciUloge.UlogaId = UlogaId;
                korisniciUloge.DatumIzmjene = DateTime.Now;

                _context.KorisniciUloges.Add(korisniciUloge);
            }

            return entity;
        }

        public override IQueryable<eProdaja.Services.Database.Korisnici> AddFilter(IQueryable<eProdaja.Services.Database.Korisnici> query, KorisniciSearchObject search)
        {
            var filterQuery = base.AddFilter(query, search);
            
            if (!string.IsNullOrWhiteSpace(search?.NameFTS))
            {
                filterQuery = filterQuery.Where(x => x.Ime.Contains(search.NameFTS)
                                                  || x.Prezime.Contains(search.NameFTS)
                                                  || x.KorisnickoIme.Contains(search.NameFTS));
            }
            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                filterQuery = filterQuery.Where(x => x.KorisnickoIme == search.KorisnickoIme);
            }
            return filterQuery;
        }

        public override void BeforeInsert(KorisniciInsertRequest insert, eProdaja.Services.Database.Korisnici context)
        {
            var salt = GenerateSalt();
            var hash = GenerateHash(salt, insert.Password);
            
            context.LozinkaHash = hash;
            context.LozinkaSalt = salt;
            
            base.BeforeInsert(insert, context);
        }


        public static string GenerateSalt()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[16];
            provider.GetBytes(byteArray);


            return Convert.ToBase64String(byteArray);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
        
        public override IQueryable<eProdaja.Services.Database.Korisnici> AddInclude(IQueryable<eProdaja.Services.Database.Korisnici> query, KorisniciSearchObject search = null)
        {
            if (search?.IncludeRoles == true)
            {
                query = query.Include("KorisniciUloges.Uloga"); 
            }
            return query;
        }
        
        public Model.Korisnici Login(string username, string password)
        {
            var entity = _context.Korisnicis.Include("KorisniciUloges.Uloga").FirstOrDefault(x => x.KorisnickoIme == username);

            if(entity == null)
            {
                return null;
            }

            var hash = GenerateHash(entity.LozinkaSalt, password);
            if(hash != entity.LozinkaHash)
            {
                return null;
            }
            return _mapper.Map<Model.Korisnici>(entity);
        }
    }
}
