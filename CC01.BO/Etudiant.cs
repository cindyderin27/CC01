using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    class Etudiant
    {
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string PreNom { get; set; }
        public string LieuNais { get; set; }
        public string DateNais { get; set; }
        public int Contact { get; set; }
        public byte[] Photo { get; set; }
        public byte[] CodeBar { get; set; }

        public Etudiant(string matricule,string nom, string preNom, string lieuNais, int contact, byte[] photo, byte[] codeBar)
        {
            Matricule = matricule;
            Nom = nom;
            PreNom = preNom;
            LieuNais = lieuNais;
            Contact = contact;
            Photo = photo;
            CodeBar = codeBar;
        }

        public override bool Equals(object obj)
        {
            return obj is Etudiant etudiant&&
                Matricule==etudiant.Matricule;
        }

        public override int GetHashCode()
        {
            return 797189699 + EqualityComparer<string>.Default.GetHashCode(Matricule);
        }
    }
}
