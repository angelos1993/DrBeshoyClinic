using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;

namespace DrBeshoyClinic.BLL
{
    public class TreatmentDescriptionManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public IQueryable<TreatmentDescription> GetAllTreatmentDescriptions()
        {
            return UnitOfWork.TreatmentDescriptionRepository.GetAll();
        }

        public int GetTreatmentDescriptionIdByDescription(string treatmentDescriptionDescription)
        {
            var treatmentDescriptionObj = UnitOfWork.TreatmentDescriptionRepository.Get(treatmentDescription
                => treatmentDescription.Description == treatmentDescriptionDescription).FirstOrDefault();
            if (treatmentDescriptionObj != null)
                return treatmentDescriptionObj.Id;
            treatmentDescriptionObj = new TreatmentDescription {Description = treatmentDescriptionDescription};
            UnitOfWork.TreatmentDescriptionRepository.Add(treatmentDescriptionObj);
            return treatmentDescriptionObj.Id;
        }

        public string GetDescriptionById(int treatmentDescriptionId)
        {
            return UnitOfWork.TreatmentDescriptionRepository
                .Get(treatmentDescription => treatmentDescription.Id == treatmentDescriptionId)
                .Select(treatmentDescription => treatmentDescription.Description).FirstOrDefault();
        }

        #endregion
    }
}