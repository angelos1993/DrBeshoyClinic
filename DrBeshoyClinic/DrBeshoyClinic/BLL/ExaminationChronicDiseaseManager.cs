using System.Collections.Generic;
using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;

namespace DrBeshoyClinic.BLL
{
    public class ExaminationChronicDiseaseManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public void AddListOfChronicDiseases(List<ExaminationChronicDisease> examinationChronicDiseases)
        {
            var alreadyAddedExaminationChronicDiseases = GetExaminationChronicDiseasesForExamination(
                examinationChronicDiseases.FirstOrDefault()?.ExaminationId ?? 0).ToList();
            var examinationChronicDiseasesToBeAdded =
                examinationChronicDiseases.Except(alreadyAddedExaminationChronicDiseases);
            var examinationChronicDiseasesToBeDeleted =
                alreadyAddedExaminationChronicDiseases.Except(examinationChronicDiseases);
            foreach (var examinationChronicDisease in examinationChronicDiseasesToBeAdded)
                UnitOfWork.ExaminationChronicDiseaseRepository.Add(examinationChronicDisease);
            foreach (var examinationChronicDisease in examinationChronicDiseasesToBeDeleted)
                UnitOfWork.ExaminationChronicDiseaseRepository.Delete(examinationChronicDisease);
        }

        public IQueryable<ExaminationChronicDisease> GetExaminationChronicDiseasesForExamination(int examinationId)
        {
            return UnitOfWork.ExaminationChronicDiseaseRepository.Get(examinationChronicDiseases
                => examinationChronicDiseases.ExaminationId == examinationId);
        }

        public IQueryable<ExaminationChronicDisease> GetChronicDiseasesForExamination(int examinationId)
        {
            return UnitOfWork.ExaminationChronicDiseaseRepository.GetAll()
                .Where(examinationChronicDisease => examinationChronicDisease.ExaminationId == examinationId);
        }

        #endregion
    }
}