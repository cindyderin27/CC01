using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    public class EcoleBLO
    {
       EcoleDAO ecoleRepo;
        private string dbFolder;
        public EcoleBLO(string dbFolder)
        {
            this.dbFolder = dbFolder;
            ecoleRepo = new EcoleDAO(dbFolder);
        }
        public void CreateEcole(Ecole newEcole)
        {
            string filename = null;
            if (!string.IsNullOrEmpty(newEcole.Logo.ToString()))
            {
                string ext = Path.GetExtension(newEcole.Logo.ToString());
                filename = Guid.NewGuid().ToString() + ext;
                FileInfo fileSource = new FileInfo(newEcole.Logo.ToString());
                string filePath = Path.Combine(dbFolder, "logo", filename);
                FileInfo fileDest = new FileInfo(filePath);
                if (!fileDest.Directory.Exists)
                    fileDest.Directory.Create();
                fileSource.CopyTo(fileDest.FullName);
            }
           // newEcole.Logo = filename;
            ecoleRepo.Add(newEcole);

            if (!string.IsNullOrEmpty(newEcole.Logo.ToString()))
                File.Delete(newEcole.Logo.ToString());
        }

        //public Ecole GetEcole()
        //{
        //    Ecole ecole = (Ecole)ecoleRepo.Get();
        //    if (ecole != null)
        //        if (!string.IsNullOrEmpty(ecole.Logo.ToString()))
        //            ecole.Logo = Path.Combine(dbFolder, "logo", ecole.Logo);
        //    return ecole;
        //}
        public void DeleteEcole(Ecole ecole)
        {
            ecoleRepo.Remove(ecole);
        }


        public IEnumerable<Ecole> GetAllEcoles()
        {
            return ecoleRepo.Find();
        }


        public IEnumerable<Ecole> GetByNom(string nom)
        {
            return ecoleRepo.Find(x => x.NomEcole == nom);
        }

        public IEnumerable<Ecole> GetBy(Func<Ecole, bool> predicate)
        {
            return ecoleRepo.Find(predicate);
        }

        public void EditEcole(Ecole oldEcole, Ecole newEcole)
        {
            ecoleRepo.Set(oldEcole, newEcole);
        }


    }
}

        


