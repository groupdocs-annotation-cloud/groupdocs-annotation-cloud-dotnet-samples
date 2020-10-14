using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.BasicUsage.Storage.WorkingWithFiles
{
	// Download_File
    internal class DownloadFile
	{
		public static void Run()
		{
			var apiInstance = new FileApi(Constants.GetConfig());

			try
			{
				var request = new DownloadFileRequest("one-page.docx", Constants.MyStorage);

				var response = apiInstance.DownloadFile(request);
				Console.WriteLine("Expected response type is Stream: " + response.Length);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FileApi: " + e.Message);
			}
		}
	}
}