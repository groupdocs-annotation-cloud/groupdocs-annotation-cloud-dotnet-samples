using System;
using GroupDocs.Annotation.Cloud.Examples.AdvancedUsage;
using GroupDocs.Annotation.Cloud.Examples.BasicUsage;

namespace GroupDocs.Annotation.Cloud.Examples
{
    internal class Program
    {
        private static void Main()
        {
            //// ***********************************************************
            ////          GroupDocs.Annotation Cloud API Examples
            //// ***********************************************************

            //TODO: Get your ClientId and ClientSecret at https://dashboard.groupdocs.cloud (free registration is required).
            Constants.MyClientId = "XXXX-XXXX-XXXX-XXXX";
            Constants.MyClientSecret = "XXXXXXXXXXXXXXXX";
            Constants.MyStorage = "First Storage";

            // Uploading sample test files from local disk to cloud storage
            Constants.UploadSampleTestFiles();

            #region Basic usage
            GetSupportedFormats.Run();
            GetDocumentInfo.Run();
            #endregion

            #region AdvancedUsage
            AddAreaAnnotation.Run();
            //AddArrowAnnotation.Run();
            //AddDistanceAnnotation.Run();
            //AddEllipseAnnotation.Run();
            //AddImageAnnotation.Run();
            //AddMultipleAnnotations.Run();
            //AddPointAnnotation.Run();
            //AddPolylineAnnotation.Run();
            //AddResourcesRedactionAnnotation.Run();
            //AddTextFieldAnnotation.Run();
            //AddTextHighlightAnnotation.Run();
            //AddLinkAnnotation.Run();
            //AddTextRedactionAnnotation.Run();
            //AddTextReplacementAnnotation.Run();
            //AddTextStrikeoutAnnotation.Run();
            //AddTextUnderlineAnnotation.Run();
            //AddWatermarkAnnotation.Run();
            GetAnnotations.Run();
            ExportDocumentWithAnnotations.Run();
            DeleteAnnotations.Run();
            GetPages.Run();
            DeletePages.Run();
            #endregion

            Console.WriteLine("Completed!");
        }
    }
}
