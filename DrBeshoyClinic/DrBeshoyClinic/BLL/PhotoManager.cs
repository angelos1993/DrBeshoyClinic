using System.Collections.Generic;
using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;

namespace DrBeshoyClinic.BLL
{
    public class PhotoManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public IQueryable<Photo> GetAllPhotosForPatient(string patientId)
        {
            return UnitOfWork.PhotoRepository.Get(photo => photo.PatientId == patientId);
        }

        public void AddListOfPhotos(List<Photo> photos)
        {
            photos.ForEach(photo => UnitOfWork.PhotoRepository.Add(photo));
        }

        #endregion
    }
}