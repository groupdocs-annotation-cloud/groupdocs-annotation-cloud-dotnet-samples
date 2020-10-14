using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.AdvancedUsage
{
	// Get document annotations
    internal class GetAnnotations
	{
		public static void Run()
		{
            var apiInstance = new AnnotateApi(Constants.GetConfig());

			try
			{
				// Set request.
				var request = new GetImportRequest
				{
					filePath = "one-page.docx"
				};

				var response = apiInstance.GetImport(request);
				Console.WriteLine("GetAnnotations: annotations count = " + response.Count);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling AnnotateApi: " + e.Message);
			}
		}
	}
}