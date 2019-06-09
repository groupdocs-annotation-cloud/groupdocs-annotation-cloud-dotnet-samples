using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Client;
using GroupDocs.Annotation.Cloud.Sdk.Model;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.CSharp
{
	// Get document annotation from File
	class Get_Annotation
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new AnnotateApi(configuration);

			try
			{
				// Set request.
				var request = new GetImportRequest()
				{
					filePath = "Annotationdocs\\ten-pages.docx"
				};

				var response = apiInstance.GetImport(request);
				Console.WriteLine("Expected response type is List<AnnotationInfo>: " + response.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling Annotation AnnotateApi: " + e.Message);
			}
		}
	}
}