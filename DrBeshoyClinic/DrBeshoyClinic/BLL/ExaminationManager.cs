using System;
using DrBeshoyClinic.BLL.Infrastructure;

namespace DrBeshoyClinic.BLL
{
    public class ExaminationManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public bool IsExistsExaminationForPatient(string patientId)
        {
            throw new NotImplementedException();
            //return UnitOfWork.ExaminationRepository.Get(examination=>examination.PatientId==patientId&&examination.)
        }

        #endregion
    }
}