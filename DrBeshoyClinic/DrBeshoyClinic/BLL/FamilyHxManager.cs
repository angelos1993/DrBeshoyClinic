using System;
using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;
using DrBeshoyClinic.Utility;

namespace DrBeshoyClinic.BLL
{
    public class FamilyHxManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public void AddOrUpdateFamilyHx(FamilyHx familyHx)
        {
            if (!IsExistFamilyHx(familyHx.PatientId, familyHx.Date))
                UnitOfWork.FamilyHxRepository.Add(familyHx);
            else
                UnitOfWork.FamilyHxRepository.Update(familyHx);
        }

        public bool IsExistFamilyHx(string patientId, DateTime date)
        {
            return UnitOfWork.FamilyHxRepository
                .Get(familyHx => familyHx.PatientId == patientId && familyHx.Date == date).Any();
        }

        public IQueryable<FamilyHx> GetFamilyHxesForPatient(string patientId)
        {
            return UnitOfWork.FamilyHxRepository.Get(familyHx => familyHx.PatientId == patientId);
        }

        public string GetFamilyHxsForPatient(string patientId)
        {
            return GetFamilyHxesForPatient(patientId).Select(familyHx => familyHx.Description).ToCommaSeperatedString();
        }

        #endregion
    }
}