using DrBeshoyClinic.DAL.Repositories.Infrastructure;

namespace DrBeshoyClinic.BLL.Infrastructure
{
    public abstract class BaseManager
    {
        private IUnitOfWork _unitOfWork;
        public IUnitOfWork UnitOfWork => _unitOfWork ?? (_unitOfWork = new UnitOfWork());
    }
}