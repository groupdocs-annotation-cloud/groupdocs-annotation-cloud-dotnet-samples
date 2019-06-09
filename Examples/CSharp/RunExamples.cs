using System;

namespace GroupDocs.Annotation.Cloud.Examples.CSharp
{
	class RunExamples
	{
		static void Main(string[] args)
		{
			//// ***********************************************************
			////          GroupDocs.Annotation Cloud API Examples
			//// ***********************************************************

			//TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
			Common.MyAppSid = "XXXXX-XXXXX-XXXXX-XXXXX";
			Common.MyAppKey = "XXXXXXXXXX";
			Common.MyStorage = "XXXXX";

			//// Uploading sample test files from local to storage under folder 'Annotationdocs'
			//Common.UploadSampleTestFiles();

			//// ***********************************************************
			///// ***** WORKING WITH STORAGE *****
			//// ***********************************************************

			//// Is Storage Exist
			//Storage_Exist.Run();

			//// Get Get Disc Usage
			//Get_Disc_Usage.Run();

			//// Get File Versions
			//Get_File_Versions.Run();

			//// Is Object Exists
			//Object_Exists.Run();


			//// ***********************************************************
			//// ***** WORKING WITH FOLDER *****
			//// ***********************************************************

			//// Create Folder
			//Create_Folder.Run();

			//// Copy Folder
			//Copy_Folder.Run();

			//// Move Folder
			//Move_Folder.Run();

			//// Delete Folder
			//Delete_Folder.Run();

			//// Get Files List
			//Get_Files_List.Run();


			//// ***********************************************************
			//// ***** WORKING WITH FILES *****
			//// ***********************************************************

			//// Upload File
			//Upload_File.Run();

			//// Copy File
			//Copy_File.Run();

			//// Move File
			//Move_File.Run();

			//// Delete File
			//Delete_File.Run();

			//// Download_File
			//Download_File.Run();


			//// ***********************************************************
			//// ***** WORKING WITH SUPPORTED FORMATS *****
			//// ***********************************************************

			// Get All Supported Formats
			Get_All_Supported_Formats.Run();


			//// ***********************************************************
			//// ***** WORKING WITH SUPPORTED BARCODES *****
			//// ***********************************************************

			//// Get All Supported Barcodes
			//Get_All_Supported_Barcodes.Run();


			//// ***********************************************************
			/////// ***** WORKING WITH DOCUMENT INFORMATION *****
			//// ***********************************************************

			//// Get document information from File
			//DocumentInfo_File.Run();


			//// ***********************************************************
			/////// ***** WORKING WITH DOCUMENT PAGES *****
			//// ***********************************************************

			//// Get document pages as images from File
			//Get_Pages.Run();

			//// Delete document pages created as images from File
			//Delete_Pages.Run();


			//// ***********************************************************
			/////// ***** WORKING WITH ANNOTATIONS *****
			//// ***********************************************************

			// Post/Add annotations
			//Add_Annotation.Run();

			//// Get document annotation from File
			//Get_Annotation.Run();

			////// Delete annotation from document
			//Delete_Annotation.Run();

			//// Get document with annotation result as Stream
			//Get_Export_Document.Run();

			//// Get document as PDF with annotation result as Stream
			//Get_PDF.Run();
		}
	}
}