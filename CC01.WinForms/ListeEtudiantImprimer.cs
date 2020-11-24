using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.WinForms
{
    class ListeEtudiantImprimer
    {
        public string Nom { get; set; }
        public string PreNom { get; set; }
        public string Matricule   { get; set; }
        public long Contact { get; set; }
        public string Email { get; set; }
        public DateTime DateNais { get; set; }
        public string LieuNais { get; set; }
        public byte[] Photo { get; set; }
       // public byte[] Logo { get; set; }
        
       
        public ListeEtudiantImprimer()
        {

        }
        public ListeEtudiantImprimer(byte[] photo,string matricule, string nom, string prenom,
              DateTime dateNais, string email, long contact, string lieu
          )
        {
            Photo = photo;
            //Logo = logo;
            Matricule = matricule;
            Nom = nom;
            PreNom = prenom;
            DateNais = dateNais;
            LieuNais = lieu;
            Contact = contact;
            Email = email;
        }

        
    }
}
