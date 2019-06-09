using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Client;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Annotation.Cloud.Examples.CSharp
{
	// Download_File
	class Download_File
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new FileApi(configuration);

			try
			{
				var request = new DownloadFileRequest("Annotationdocs/one-page.docx", Common.MyStorage);

				var response = apiInstance.DownloadFile(request);
				Console.WriteLine("Expected response type is Stream: " + response.Length.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FileApi: " + e.Message);
			}
		}
	}
}