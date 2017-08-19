using System.Collections.Generic;
using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;

namespace DrBeshoyClinic.BLL
{
    public class RadiologyManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public IQueryable<Radiology> GetAllRadiologies()
        {
            return UnitOfWork.RadiologyRepository.GetAll();
        }

        public IQueryable<Radiology> GetRadiologiesForPatient(string patientId)
        {
            return UnitOfWork.RadiologyRepository.Get(radiology => radiology.PatientId == patientId);
        }

        public void AddListOfRadiologies(List<Radiology> radiologies)
        {
            radiologies.ForEach(radiology => UnitOfWork.RadiologyRepository.Add(radiology));
        }

        #endregion
    }
}