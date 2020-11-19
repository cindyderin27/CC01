using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Ecole
    {
        public string Logo { get; set; }
        public string Nom { get; set; }
        public int Tel { get; set; }
        public string Email { get; set; }

        public Ecole(string logo, string nom, int tel, string email)
        {
            Logo = logo;
            Nom = nom;
            Tel = tel;
            Email = email;
        }

        public override bool Equals(object obj)
        {
            return obj is Ecole ecole &&
                   Nom == ecole.Nom;
        }

        public override int GetHashCode()
        {
            return 217408413 + EqualityComparer<string>.Default.GetHashCode(Nom);
        }
    }
}
