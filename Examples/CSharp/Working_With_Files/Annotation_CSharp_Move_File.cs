using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Client;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Annotation.Cloud.Examples.CSharp
{
	// Move File
	class Move_File
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new FileApi(configuration);

			try
			{
				var request = new MoveFileRequest("Annotationdocs/one-page1.docx", "Annotationdocs1/one-page1.docx", Common.MyStorage, Common.MyStorage);

				apiInstance.MoveFile(request);
				Console.WriteLine("Expected response type is Void: 'Annotationdocs/one-page1.docx' file moved to 'Annotationdocs1/one-page1.docx'.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FileApi: " + e.Message);
			}
		}
	}
}