using System;
using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;

namespace DrBeshoyClinic.BLL
{
    public class DrugHxManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public void AddOrUpdateDrugHx(DrugHx drugHx)
        {
            if (!IsExistDrugHx(drugHx.PatientId, drugHx.Date))
                UnitOfWork.DrugHxRepository.Add(drugHx);
            else
                UnitOfWork.DrugHxRepository.Update(drugHx);
        }

        public bool IsExistDrugHx(string patientId, DateTime date)
        {
            return UnitOfWork.DrugHxRepository
                .Get(drugHx => drugHx.PatientId == patientId && drugHx.Date == date).Any();
        }

        public IQueryable<DrugHx> GetDrugHxesForPatient(string patientId)
        {
            return UnitOfWork.DrugHxRepository.Get(drugHx => drugHx.PatientId == patientId);
        }

        #endregion
    }
}