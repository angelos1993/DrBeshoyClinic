using System.Collections.Generic;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;

namespace DrBeshoyClinic.BLL
{
    public class PostOperativeTreatmentManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public void AddListOfPostOperativeTreatments(int operationId, List<PostOperativeTreatment> postOperativeTreatments)
        {
            postOperativeTreatments.ForEach(postOperativeTreatment =>
            {
                postOperativeTreatment.OperationId = operationId;
                UnitOfWork.PostOperativeTreatmentRepository.Add(postOperativeTreatment);
            });
        }

        #endregion
    }
}