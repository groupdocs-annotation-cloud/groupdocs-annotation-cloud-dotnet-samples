using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.BasicUsage.Storage.WorkingWithFolder
{
	// Copy Folder
    internal class CopyFolder
	{
		public static void Run()
		{
			var apiInstance = new FolderApi(Constants.GetConfig());

			try
			{
				var request = new CopyFolderRequest("Annotationdocs", "Annotationdocs1", Constants.MyStorage, Constants.MyStorage);

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