using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Client;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.CSharp
{
	// Copy Folder
	class Copy_Folder
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new FolderApi(configuration);

			try
			{
				var request = new CopyFolderRequest("Annotationdocs", "Annotationdocs1", Common.MyStorage, Common.MyStorage);

				apiInstance.CopyFolder(request);
				Console.WriteLine("Expected response type is Void: 'Annotationdocs' folder copied as 'Annotationdocs1'.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FolderApi: " + e.Message);
			}
		}
	}
}