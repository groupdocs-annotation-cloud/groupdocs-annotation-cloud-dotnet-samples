using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.BasicUsage.Storage.WorkingWithFolder
{
	// Delete Folder
    internal class DeleteFolder
	{
		public static void Run()
		{
			var apiInstance = new FolderApi(Constants.GetConfig());

			try
			{
				var request = new DeleteFolderRequest("Annotationdocs1", Constants.MyStorage, true);

				apiInstance.DeleteFolder(request);
				Console.WriteLine("Expected response type is Void: 'Annotationdocs1' folder deleted recusrsively.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FolderApi: " + e.Message);
			}
		}
	}
}