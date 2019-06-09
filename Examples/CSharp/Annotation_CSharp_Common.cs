using System.IO;
using System;
using GroupDocs.Annotation.Cloud.Sdk.Client;
using GroupDocs.Annotation.Cloud.Sdk.Api;

namespace GroupDocs.Annotation.Cloud.Examples.CSharp
{
	class Common
	{
		public static string MyAppSid = Common.MyAppSid;
		public static string MyAppKey = Common.MyAppKey;
		public static string MyStorage = Common.MyStorage;

		public static void UploadSampleTestFiles()
		{
			var storageConfig = new Configuration(MyAppSid, MyAppKey);

			StorageApi storageApi = new StorageApi(storageConfig);
			FolderApi folderApi = new FolderApi(storageConfig);
			FileApi fileApi = new FileApi(storageConfig);

			var path = "..\\..\\..\\Data";

			Console.WriteLine("File Upload Processing...");

			var dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
			foreach (var dir in dirs)
			{
				var relativeDirPath = dir.Replace(path, string.Empty).Trim(Path.DirectorySeparatorChar);
				var response = storageApi.ObjectExists(new Sdk.Model.Requests.ObjectExistsRequest(relativeDirPath, MyStorage));
				if (!response.Exists.Value)
				{
					folderApi.CreateFolder(new Sdk.Model.Requests.CreateFolderRequest(relativeDirPath, MyStorage));
				}
			}

			var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
			foreach (var file in files)
			{
				var relativeFilePath = file.Replace(path, string.Empty).Trim(Path.DirectorySeparatorChar);

				var response = storageApi.ObjectExists(new Sdk.Model.Requests.ObjectExistsRequest(relativeFilePath, MyStorage));
				if (!response.Exists.Value)
				{
					var fileName = Path.GetFileName(file);
					var relativeDirPath = relativeFilePath.Replace(fileName, string.Empty).Trim(Path.DirectorySeparatorChar);
					var fileStream = File.Open(file, FileMode.Open);

					fileApi.UploadFile(new Sdk.Model.Requests.UploadFileRequest(relativeFilePath, fileStream, MyStorage));
					fileStream.Close();
				}
			}

			Console.WriteLine("File Upload Process Completed.");
		}
	}
}
