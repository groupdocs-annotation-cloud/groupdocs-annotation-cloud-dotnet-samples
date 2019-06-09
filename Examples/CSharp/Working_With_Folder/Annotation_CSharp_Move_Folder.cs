using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Client;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Annotation.Cloud.Examples.CSharp
{
	// Move Folder
	class Move_Folder
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new FolderApi(configuration);

			try
			{
				var request = new MoveFolderRequest("Annotationdocs1", "Annotationdocs\\Annotationdocs1", Common.MyStorage, Common.MyStorage);

				apiInstance.MoveFolder(request);
				Console.WriteLine("Expected response type is Void: 'Annotationdocs1' folder moved to 'Annotationdocs/Annotationdocs1'.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FolderApi: " + e.Message);
			}
		}
	}
}