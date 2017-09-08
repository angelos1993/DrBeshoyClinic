using System;
using System.Collections.Generic;
using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;
using DrBeshoyClinic.Utility;

namespace DrBeshoyClinic.BLL
{
    public class DiagnosisManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public IQueryable<Diagnosi> GetAllDiagnosis()
        {
            return UnitOfWork.DiagnosisRepository.GetAll();
        }

        public IQueryable<Diagnosi> GetDiagnosisForPatient(string patientId)
        {
            return UnitOfWork.DiagnosisRepository.Get(diagnosi => diagnosi.PatientId == patientId);
        }

        public string GetDiagnosisStringByPatientAndDate(string patientId, DateTime date)
        {
            return GetDiagnosisForPatient(patientId).Where(diagnosi => diagnosi.Date == date)
                .Select(diagnosi => diagnosi.Name).ToCommaSeperatedString();
        }

        public void AddListOfDiagnosis(List<Diagnosi> diagnosis)
        {
            diagnosis.ForEach(diagnosi => UnitOfWork.DiagnosisRepository.Add(diagnosi));
        }

        #endregion
    }
}