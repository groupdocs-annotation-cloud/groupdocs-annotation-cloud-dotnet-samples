using System;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.BasicUsage.Storage.WorkingWithFolder
{
	// Move Folder
    internal class MoveFolder
	{
		public static void Run()
		{
			var apiInstance = new FolderApi(Constants.GetConfig());

			try
			{
				var request = new MoveFolderRequest("Annotationdocs1", "Annotationdocs1", Constants.MyStorage, Constants.MyStorage);

				apiInstance.MoveFolder(request);
				Console.WriteLine("Expected response type is Void: 'Annotationdocs1' folder moved to 'Annotationdocs1'.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FolderApi: " + e.Message);
			}
		}
	}
}