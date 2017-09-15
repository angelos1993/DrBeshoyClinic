using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;
using DrBeshoyClinic.Utility;

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

        public IQueryable<ChronicDiseas> GetAllChronicDiseasesOrderedAlphabetically()
        {
            return GetAllChronicDiseases().OrderBy(chronicDiseas => chronicDiseas.Name);
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

        public string GetChronicDiseasByExaminationId(int examinationId)
        {
            var examinationChronicDiseasesIds = UnitOfWork.ExaminationChronicDiseaseRepository
                .Get(examinationChronicDisease => examinationChronicDisease.ExaminationId == examinationId)
                .Select(examinationChronicDisease => examinationChronicDisease.ChronicDiseaseId).ToList();
            return UnitOfWork.ChronicDiseaseRepository
                .Get(chronicDisease => examinationChronicDiseasesIds.Contains(chronicDisease.Id))
                .Select(chronicDisease => chronicDisease.Name).ToList().ToCommaSeperatedString();
        }

        #endregion
    }
}