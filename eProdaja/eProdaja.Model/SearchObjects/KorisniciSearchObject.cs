using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model.SearchObjects
{
    public class KorisniciSearchObject : BaseSearchObject
    {
        public string KorisnickoIme { get; set; }
        public string NameFTS { get; set; }
    }
}
