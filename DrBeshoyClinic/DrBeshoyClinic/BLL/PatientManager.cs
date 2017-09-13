using System;
using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;

namespace DrBeshoyClinic.BLL
{
    public class PatientManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public IQueryable<Patient> GetAllPatients()
        {
            return UnitOfWork.PatientRepository.GetAll();
        }

        public void AddNewPatient(Patient patient)
        {
            patient.CreatedOn = DateTime.Now;
            UnitOfWork.PatientRepository.Add(patient);
        }

        public string GetLastPatientId()
        {
            return UnitOfWork.PatientRepository.GetAll().OrderByDescending(patient => patient.CreatedOn)
                .Select(patient => patient.Id).FirstOrDefault();
        }

        public Patient GetPatientById(string patientId)
        {
            return UnitOfWork.PatientRepository.Get(patient => patient.Id == patientId).FirstOrDefault();
        }

        public Patient GetPatientByName(string patientName)
        {
            return UnitOfWork.PatientRepository.Get(patient => patient.Name == patientName).FirstOrDefault();
        }

        public void UpdatePatient(Patient patient)
        {
            UnitOfWork.PatientRepository.Update(patient);
        }

        #endregion
    }
}