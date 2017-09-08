namespace DrBeshoyClinic.Utility
{
    public static class Constants
    {
        #region Validation MSGs

        public static string RequiredValidationMsg = "This field is required";

        #endregion

        #region ListBox Members

        public static string ListBoxDisplayMember = "DateString";

        #endregion

        #region Image Size(s) & Filter(s)

        #region OpenFileDialog

        public static string AllImageFiles =
            "Image files | *.BMP; *.DIB; *.RLE; *.JPG; *.JPEG; *.JPE; *.JFIF; *.GIF; *.TIF; *.TIFF; *.PNG";

        public static string OpenFileDialogTitleForImages = "Choose Image(s)";

        #endregion

        public static int ImageWidth = 100;
        public static int ImageHeight = 100;

        #endregion

        #region Report

        public static string ReportParameterEmptyValue = "...";

        #endregion
    }
}