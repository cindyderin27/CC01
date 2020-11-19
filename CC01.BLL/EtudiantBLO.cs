using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    public class EtudiantBLO
    {

        EtudiantDAO etudiantRepo;
        public EtudiantBLO(string dbFolder)
        {
            etudiantRepo = new EtudiantDAO(dbFolder);
        }
        public void CreateProduct(Etudiant etudiant)
        {
            etudiantRepo.Add(etudiant);
        }

        public void DeleteProduct(Etudiant etudiant)
        {
            etudiantRepo.Remove(etudiant);
        }


        public IEnumerable<Etudiant> GetAllProducts()
        {
            return etudiantRepo.Find();
        }


        public IEnumerable<Etudiant> GetByReference(string reference)
        {
            return etudiantRepo.Find(x => x.Matricule == reference);
        }

        public IEnumerable<Etudiant> GetBy(Func<Etudiant, bool> predicate)
        {
            return etudiantRepo.Find(predicate);
        }

        public void EditProduct(Etudiant oldEtudiant, Etudiant newEtudiant)
        {
            etudiantRepo.Set(oldEtudiant, newEtudiant);
        }

        public void CreateProduct(object newEtudiant)
        {
            throw new NotImplementedException();
        }
    }
}

