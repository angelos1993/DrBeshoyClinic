using DrBeshoyClinic.DAL.Model;

namespace DrBeshoyClinic.DAL.Repositories.Infrastructure
{
    public class DrBeshoyClinicContext
    {
        private static DrBeshoyClinicEntities _instance;

        private DrBeshoyClinicContext()
        {
        }

        public static DrBeshoyClinicEntities Instance => _instance ?? (_instance = new DrBeshoyClinicEntities());
    }
}