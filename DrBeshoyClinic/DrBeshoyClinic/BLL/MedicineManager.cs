using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;

namespace DrBeshoyClinic.BLL
{
    public class MedicineManager : BaseManager
    {
        #region Properties

        private static DateTime Today => DateTime.Now.Date;

        #endregion

        #region Methods

        public IQueryable<Medicine> GetAllMedicines()
        {
            return UnitOfWork.MedicineRepository.GetAll();
        }

        public IQueryable<Medicine> GetAllMedicinesForPatient(string patientId)
        {
            return UnitOfWork.MedicineRepository.Get(medicine => medicine.PatientId == patientId);
        }

        public Medicine CreateNewMedicineForPatientIfNotExistsForToday(string patientId)
        {
            var medicineObj = UnitOfWork.MedicineRepository.Get(medicine
                => SqlFunctions.DateDiff("DAY", medicine.Date, Today) == 0 &&
                   medicine.PatientId == patientId).FirstOrDefault();
            if (medicineObj != null)
                return medicineObj;
            medicineObj = new Medicine {PatientId = patientId, Date = Today};
            UnitOfWork.MedicineRepository.Add(medicineObj);
            return medicineObj;
        }

        #endregion
    }
}