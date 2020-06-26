using System;

namespace FAS.Entity
{
    public class Brevete
    {
        public int Id {get;set;}
        public string numero {get;set;}
        public DateTime fechaExpi {get;set;}
        public int IdcatBrevete {get;set;}
        public CatBrevete CatBrevete {get;set;}
    }
}