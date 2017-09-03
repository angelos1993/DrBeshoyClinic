using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;

namespace DrBeshoyClinic.BLL
{
    public class TreatmentPeriodManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public IQueryable<TreatmentPeriod> GetAllTreatmentPeriods()
        {
            return UnitOfWork.TreatmentPeriodRepository.GetAll();
        }

        public int GetTreatmentPeriodIdByDescription(string treatmentPeriodDescription)
        {
            var treatmentPeriodObj = UnitOfWork.TreatmentPeriodRepository
                .Get(treatmentPeriod => treatmentPeriod.Description == treatmentPeriodDescription).FirstOrDefault();
            if (treatmentPeriodObj != null)
                return treatmentPeriodObj.Id;
            treatmentPeriodObj = new TreatmentPeriod {Description = treatmentPeriodDescription};
            UnitOfWork.TreatmentPeriodRepository.Add(treatmentPeriodObj);
            return treatmentPeriodObj.Id;
        }

        public string GetPeriodDescriptionById(int treatmentPeriodId)
        {
            return UnitOfWork.TreatmentPeriodRepository.Get(treatmentPeriod => treatmentPeriod.Id == treatmentPeriodId)
                .Select(treatmentPeriod => treatmentPeriod.Description).FirstOrDefault();
        }

        #endregion
    }
}