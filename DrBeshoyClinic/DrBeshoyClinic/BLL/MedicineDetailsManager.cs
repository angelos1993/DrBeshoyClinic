using System.Collections.Generic;
using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;

namespace DrBeshoyClinic.BLL
{
    public class MedicineDetailsManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public List<MedicineDetail> GetMedicineDetailsByPatientId(string patientId)
        {
            return UnitOfWork.MedicineDetailsRepository
                .Get(medicineDetail => medicineDetail.Medicine.PatientId == patientId).ToList();
        }

        public void AddListOfMedicineDetails(List<MedicineDetail> medicineDetails)
        {
            medicineDetails.ForEach(medicineDetail => UnitOfWork.MedicineDetailsRepository.Add(medicineDetail));
        }

        public void DeleteListOfMedicineDetails(List<MedicineDetail> medicineDetails)
        {
            medicineDetails.ForEach(medicineDetail => UnitOfWork.MedicineDetailsRepository.Delete(medicineDetail));
        }
        
        #endregion
    }
}