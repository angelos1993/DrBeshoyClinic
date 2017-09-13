using System;
using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;
using DrBeshoyClinic.Utility;

namespace DrBeshoyClinic.BLL
{
    public class EmgNcvManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public void AddOrUpdateEmgNcv(EmgNcv emgNcv)
        {
            if (emgNcv.Emg.IsNullOrEmptyOrWhiteSpace())
                emgNcv.Emg = string.Empty;
            if (emgNcv.Ncv.IsNullOrEmptyOrWhiteSpace())
                emgNcv.Ncv = string.Empty;
            if (!IsExistEmgNcv(emgNcv.PatientId, emgNcv.Date))
                UnitOfWork.EmgNcvRepository.Add(emgNcv);
            else
                UnitOfWork.EmgNcvRepository.Update(emgNcv);
        }

        public bool IsExistEmgNcv(string patientId, DateTime date)
        {
            return UnitOfWork.EmgNcvRepository
                .Get(emgNcv => emgNcv.PatientId == patientId && emgNcv.Date == date).Any();
        }

        public IQueryable<EmgNcv> GetEmgNcvsForPatient(string patientId)
        {
            return UnitOfWork.EmgNcvRepository.Get(emgNcv => emgNcv.PatientId == patientId);
        }

        #endregion
    }
}