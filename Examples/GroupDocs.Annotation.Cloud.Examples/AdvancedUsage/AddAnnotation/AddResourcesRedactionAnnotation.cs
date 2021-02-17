using System;
using System.Collections.Generic;
using System.Linq;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.AdvancedUsage
{
	// Add resources redaction annotation
	internal class AddResourcesRedactionAnnotation
	{
		public static void Run()
		{
			var apiInstance = new AnnotateApi(Constants.GetConfig());

			try
			{
                var fileInfo = new FileInfo { FilePath = "one-page.docx" };

				AnnotationInfo[] annotations =
				{
					new AnnotationInfo
					{
						Box = new Rectangle { X = 100, Y = 100, Width = 100, Height = 100 },
						PageNumber = 0,
                        Type = AnnotationInfo.TypeEnum.ResourcesRedaction,
						Text = "This is resource redaction annotation",
						CreatorName = "Anonym A.",
						CreatedOn = DateTime.Now,
						Replies = new List<AnnotationReplyInfo>
						{
							new AnnotationReplyInfo
							{
								Comment = "First comment",
								RepliedOn = DateTime.Now
							},
							new AnnotationReplyInfo
							{
								Comment = "Second comment",
								RepliedOn = DateTime.Now
							}
						}
					},
				};

                var options = new AnnotateOptions
                {
                    FileInfo = fileInfo,
                    Annotations = annotations.ToList(),
                    OutputPath = "Output/output.docx"
                };

                var link = apiInstance.Annotate(new AnnotateRequest(options));
				Console.WriteLine("AddResourcesRedactionAnnotation: resources redaction Annotation added: " + link.Title);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling AnnotateApi: " + e.Message);
			}
		}
	}
}