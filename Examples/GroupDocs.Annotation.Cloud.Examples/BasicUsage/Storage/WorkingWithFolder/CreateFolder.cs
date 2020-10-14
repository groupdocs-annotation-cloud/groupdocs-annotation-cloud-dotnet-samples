using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.BasicUsage.Storage.WorkingWithFolder
{
	// Create Folder
    internal class CreateFolder
	{
		public static void Run()
		{
			var apiInstance = new FolderApi(Constants.GetConfig());

			try
			{
				var request = new CreateFolderRequest("", Constants.MyStorage);

				apiInstance.CreateFolder(request);
				Console.WriteLine("Expected response type is Void: 'Annotationdocs' folder created.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FolderApi: " + e.Message);
			}
		}
	}
}