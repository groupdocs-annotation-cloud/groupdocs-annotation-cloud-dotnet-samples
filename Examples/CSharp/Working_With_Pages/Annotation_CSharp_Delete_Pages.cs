using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Client;
using GroupDocs.Annotation.Cloud.Sdk.Model;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.CSharp
{
	// Delete document pages created as images from File
	class Delete_Pages
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new PreviewApi(configuration);

			try
			{
				// Set request.
				var request = new DeletePagesRequest()
				{
					filePath = "Annotationdocs\\one-page.docx"
				};

				apiInstance.DeletePages(request);
				Console.WriteLine("Expected response type is Void: pages deleted.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling Annotation PreviewApi: " + e.Message);
			}
		}
	}
}