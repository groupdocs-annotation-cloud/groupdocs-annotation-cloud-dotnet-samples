using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Client;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;
using System;
using System.IO;

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
				var request = new DownloadFileRequest("Annotationdocs/ten-pages.pdf", Common.MyStorage);

				Stream response = apiInstance.DownloadFile(request);
				using (var fileStream = File.Create("D:\\tenpages.pdf"))
				{
					response.Seek(0, SeekOrigin.Begin);
					response.CopyTo(fileStream);
				}
				Console.WriteLine("Expected response type is Stream: " + response.Length.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FileApi: " + e.Message);
			}
		}
	}
}