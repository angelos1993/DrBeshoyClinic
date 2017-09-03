using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;

namespace DrBeshoyClinic.BLL
{
    public class TreatmentManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public IQueryable<Treatment> GetAllTreatments()
        {
            return UnitOfWork.TreatmentRepository.GetAll();
        }

        public int GetTreatmentIdByName(string treatmentName)
        {
            var treatmentObj = UnitOfWork.TreatmentRepository.Get(treatment => treatment.Name == treatmentName)
                .FirstOrDefault();
            if (treatmentObj != null)
                return treatmentObj.Id;
            treatmentObj = new Treatment {Name = treatmentName};
            UnitOfWork.TreatmentRepository.Add(treatmentObj);
            return treatmentObj.Id;
        }

        public string GetTreatmentNameById(int treatmentId)
        {
            return UnitOfWork.TreatmentRepository.Get(treatment => treatment.Id == treatmentId)
                .Select(treatment => treatment.Name).FirstOrDefault();
        }

        #endregion
    }
}