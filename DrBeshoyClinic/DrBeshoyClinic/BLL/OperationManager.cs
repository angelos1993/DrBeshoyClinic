using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;

namespace DrBeshoyClinic.BLL
{
    public class OperationManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public IQueryable<Operation> GetAllOperationsForPatient(string patientId)
        {
            return UnitOfWork.OperationRepository.Get(operation => operation.PatientId == patientId);
        }

        public void AddOperation(Operation operation)
        {
            UnitOfWork.OperationRepository.Add(operation);
        }

        #endregion
    }
}