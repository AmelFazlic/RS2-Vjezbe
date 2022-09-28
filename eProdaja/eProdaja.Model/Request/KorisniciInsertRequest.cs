using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eProdaja.Model.Request
{
    public class KorisniciInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Ime { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Prezime { get; set; }
        [Required(AllowEmptyStrings = false)]
        [EmailAddress()]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Telefon { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }
        public string PasswordPotvrda { get; set; }

        public bool? Status { get; set; }
        public List<int> UlogeIdList { get; set; } = new List<int> { };

    }
}
