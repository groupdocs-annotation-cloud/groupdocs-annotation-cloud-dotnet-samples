using System;
using System.IO;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.BasicUsage.Storage.WorkingWithFiles
{
	// Upload File
    internal class UploadFile
	{
		public static void Run()
		{
			var apiInstance = new FileApi(Constants.GetConfig());

			try
			{
				// Open file in IOStream from local/disc.
				var fileStream = File.Open("..\\..\\..\\Data\\one-page.docx", FileMode.Open);

				var request = new UploadFileRequest("one-page1.docx", fileStream, Constants.MyStorage);

				var response = apiInstance.UploadFile(request);
				Console.WriteLine("Expected response type is FilesUploadResult: " + response.Uploaded.Count);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FileApi: " + e.Message);
			}
		}
	}
}