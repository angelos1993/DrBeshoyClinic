using System;

namespace DrBeshoyClinic.Utility
{
    public static class Utility
    {
        public static string GetNextPatientId(string lastPatientId)
        {
            string nextPatientId;
            if (lastPatientId != null)
            {
                var datePartOfLastPatientId = lastPatientId.Substring(0, 8);
                if (DateTime.TryParse(datePartOfLastPatientId, out DateTime date) && date.Date == DateTime.Now.Date)
                {
                    var lastNumberString = lastPatientId.Substring(8);
                    var lastNumber = int.Parse(lastNumberString);
                    nextPatientId = $"{datePartOfLastPatientId}{lastNumber}";
                }
                else
                {
                    var today = DateTime.Now;
                    nextPatientId = $"{today.Year}{today.Month}{today.Day}1";
                }
            }
            else
            {
                var today = DateTime.Now;
                nextPatientId = $"{today.Year}{today.Month}{today.Day}1";
            }
            return nextPatientId;
        }
    }
}