using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Client;
using GroupDocs.Annotation.Cloud.Sdk.Model;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.CSharp
{
	// Get document information from File
	class DocumentInfo_File
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new InfoApi(configuration);

			try
			{
				// Set request.
				var request = new GetInfoRequest()
				{
					filePath = "Annotationdocs\\one-page.docx",
					password = null
				};

				var response = apiInstance.GetInfo(request);
				Console.WriteLine("Expected response type is InfoResult: " + response.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling Annotation InfoApi: " + e.Message);
			}
		}
	}
}