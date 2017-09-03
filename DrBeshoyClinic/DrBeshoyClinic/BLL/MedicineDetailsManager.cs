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

        public List<MedicineDetail> GetMedicineDetailsByMedicineId(int medicineId)
        {
            return UnitOfWork.MedicineDetailsRepository
                .Get(medicineDetail => medicineDetail.MedicineId == medicineId).ToList();
        }

        public void AddListOfMedicineDetails(List<MedicineDetail> medicineDetails)
        {
            medicineDetails.ForEach(medicineDetail => UnitOfWork.MedicineDetailsRepository.Add(medicineDetail));
        }

        #endregion
    }
}