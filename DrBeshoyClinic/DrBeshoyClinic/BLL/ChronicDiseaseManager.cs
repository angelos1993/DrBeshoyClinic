using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;

namespace DrBeshoyClinic.BLL
{
    public class ChronicDiseaseManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public IQueryable<ChronicDiseas> GetAllChronicDiseases()
        {
            return UnitOfWork.ChronicDiseaseRepository.GetAll();
        }

        public void AddNewChronicDisease(ChronicDiseas chronicDiseas)
        {
            UnitOfWork.ChronicDiseaseRepository.Add(chronicDiseas);
        }

        public ChronicDiseas GetChronicDiseasByName(string chronicDiseasName)
        {
            return UnitOfWork.ChronicDiseaseRepository.Get(chronicDiseas => chronicDiseas.Name == chronicDiseasName)
                .FirstOrDefault();
        }

        public void DeleteChronicDisease(ChronicDiseas chronicDiseas)
        {
            UnitOfWork.ChronicDiseaseRepository.Delete(chronicDiseas);
        }

        #endregion
    }
}