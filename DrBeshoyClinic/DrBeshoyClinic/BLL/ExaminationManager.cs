﻿using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;
using DrBeshoyClinic.DAL.VMs;
using static System.Data.Entity.DbFunctions;

namespace DrBeshoyClinic.BLL
{
    public class ExaminationManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public bool IsExistsExaminationForPatient(string patientId, DateTime today)
        {
            return UnitOfWork.ExaminationRepository
                .Get(examination => examination.PatientId == patientId && examination.Date == today.Date).Any();
        }

        public void AddNewExamination(Examination examination)
        {
            UnitOfWork.ExaminationRepository.Add(examination);
        }

        public IEnumerable<Examination> GetAllExaminationsForPatient(string patientId)
        {
            return UnitOfWork.ExaminationRepository.Get(examination => examination.PatientId == patientId);
        }

        public void UpdateExamination(Examination examination)
        {
            UnitOfWork.ExaminationRepository.Update(examination);
        }

        public Examination GetExaminationByPatientAndDate(string patientId, DateTime dateTime)
        {
            return UnitOfWork.ExaminationRepository
                .Get(examination => examination.PatientId == patientId &&
                                    TruncateTime(examination.Date) == TruncateTime(dateTime)).FirstOrDefault();
        }

        public List<DailyReportExaminationVm> GetDailyReportExaminationVms(DateTime dateTime)
        {
            return UnitOfWork.ExaminationRepository
                .Get(examination => SqlFunctions.DateDiff("DAY", examination.Date, dateTime) == 0)
                .Select(examination => new DailyReportExaminationVm
                {
                    PatientName = examination.Patient.Name,
                    ExaminationType = examination.ExaminationType ? "كشف" : "إعادة"
                    //TODO: need to include Diagnosis in each item -_-
                }).ToList();
        }

        #endregion
    }
}