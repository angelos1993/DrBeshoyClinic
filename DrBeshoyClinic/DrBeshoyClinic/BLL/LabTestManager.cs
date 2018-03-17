using System.Collections.Generic;
using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;

namespace DrBeshoyClinic.BLL
{
    public class LabTestManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public IQueryable<LabTest> GetAllLabTests()
        {
            return UnitOfWork.LabTestRepository.GetAll();
        }

        public IQueryable<LabTest> GetAllLabTestsForPatient(string patientId)
        {
            return UnitOfWork.LabTestRepository.Get(labTest => labTest.PatientId == patientId);
        }

        public void AddListOfLabTests(List<LabTest> labTests)
        {
            labTests.ForEach(labtest => UnitOfWork.LabTestRepository.Add(labtest));
        }

        public void DeleteListOfLabTests(List<LabTest> labTests)
        {
            labTests.ForEach(labtest => UnitOfWork.LabTestRepository.Delete(labtest));
        }

        #endregion
    }
}