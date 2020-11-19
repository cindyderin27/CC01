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
        public string Prenom { get; set; }
        public string Matricule   { get; set; }
        public long Contact { get; set; }
        public string Email { get; set; }
        public DateTime DateNais { get; set; }
        public string Lieu { get; set; }
        public byte[] Photo { get; set; }
        public string NomEcole { get; set; }
        public string EmailEcole { get; set; }
        public long ContactEcole { get; set; }
        public byte[] Logo { get; set; }

        public ListeEtudiantImprimer(string nom, string prenom, string matricule,
            long contact, string email, DateTime dateNais, string lieu,
            byte[] photo, string nomEcole, string emailEcole,
            long contactEcole, byte[] logo)
        {
            Nom = nom;
            Prenom = prenom;
            Matricule = matricule;
            Contact = contact;
            Email = email;
            DateNais = dateNais;
            Lieu = lieu;
            Photo = photo;
            NomEcole = nomEcole;
            EmailEcole = emailEcole;
            ContactEcole = contactEcole;
            Logo = logo;
        }
    }
}
