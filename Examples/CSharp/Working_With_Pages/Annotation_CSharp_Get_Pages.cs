using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Client;
using GroupDocs.Annotation.Cloud.Sdk.Model;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.CSharp
{
	// Get document pages as images from File
	class Get_Pages
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new PreviewApi(configuration);

			try
			{
				// Set request.
				var request = new GetPagesRequest()
				{
					filePath = "Annotationdocs\\ten-pages.docx",
					password = null,
					pageNumber = 1,
					countPagesToConvert = 1,
					enableCaching = false,
					cacheStoragePath = null,
					withoutAnnotations = true
				};

				var response = apiInstance.GetPages(request);
				Console.WriteLine("Expected response type is PageImages: " + response.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling Annotation PreviewApi: " + e.Message);
			}
		}
	}
}