using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Client;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Annotation.Cloud.Examples.CSharp
{
	// Copy File
	class Copy_File
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new FileApi(configuration);

			try
			{
				var request = new CopyFileRequest("Annotationdocs/one-page1.docx", "Annotationdocs/one-page-copied.docx", Common.MyStorage, Common.MyStorage);

				apiInstance.CopyFile(request);
				Console.WriteLine("Expected response type is Void: 'Annotationdocs/one-page1.docx' file copied as 'Annotationdocs/one-page-copied.docx'.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FileApi: " + e.Message);
			}
		}
	}
}