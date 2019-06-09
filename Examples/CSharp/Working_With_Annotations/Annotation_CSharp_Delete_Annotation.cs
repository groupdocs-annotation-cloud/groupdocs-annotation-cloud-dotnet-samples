using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Client;
using GroupDocs.Annotation.Cloud.Sdk.Model;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.CSharp
{
	// Delete annotation from document
	class Delete_Annotation
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new AnnotateApi(configuration);

			try
			{
				// Set request.
				var request = new DeleteAnnotationsRequest()
				{
					filePath = "Annotationdocs\\one-page.docx"
				};

				apiInstance.DeleteAnnotations(request);
				Console.WriteLine("Expected response type is Void: Annotation deleted from document.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling Annotation AnnotateApi: " + e.Message);
			}
		}
	}
}