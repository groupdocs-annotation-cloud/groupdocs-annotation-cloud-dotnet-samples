using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.AdvancedUsage
{
	// Get document with annotations
    internal class ExportDocumentWithAnnotations
	{
		public static void Run()
		{
            var apiInstance = new AnnotateApi(Constants.GetConfig());

			try
			{
				// Set request.
				var request = new GetExportRequest("one-page.docx");

				var response = apiInstance.GetExport(request);
				Console.WriteLine("ExportDocumentWithAnnotations: Document Length: " + response.Length);
            }
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling AnnotateApi: " + e.Message);
			}
		}
	}
}