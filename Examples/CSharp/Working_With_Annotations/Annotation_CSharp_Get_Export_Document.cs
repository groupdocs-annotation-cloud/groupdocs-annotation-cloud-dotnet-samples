using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Client;
using GroupDocs.Annotation.Cloud.Sdk.Model;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.CSharp
{
	// Get document with annotation result as Stream
	class Get_Export_Document
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new AnnotateApi(configuration);

			try
			{
				// Set request.
				var request = new GetExportRequest()
				{
					filePath = "Annotationdocs\\ten-pages.docx",
					password = null,
					annotatedPages = true,
					annotationTypes = null,
					firstPage = 1,
					lastPage = 2
				};

				var response = apiInstance.GetExport(request);
				Console.WriteLine("Expected response type is Stream: Document Length: " + response.Length.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling Annotation AnnotateApi: " + e.Message);
			}
		}
	}
}