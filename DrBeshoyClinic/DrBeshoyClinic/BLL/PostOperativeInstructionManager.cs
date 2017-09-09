using System.Collections.Generic;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;

namespace DrBeshoyClinic.BLL
{
    public class PostOperativeInstructionManager : BaseManager
    {
        #region Methods

        public void AddListOfPostOperativeInstructions(int operationId,
            List<PostOperativeInstruction> postOperativeInstructions)
        {
            postOperativeInstructions.ForEach(postOperativeInstruction =>
            {
                postOperativeInstruction.OperationId = operationId;
                UnitOfWork.PostOperativeInstructionRepository.Add(postOperativeInstruction);
            });
        }

        #endregion

        #region Properties

        #endregion
    }
}