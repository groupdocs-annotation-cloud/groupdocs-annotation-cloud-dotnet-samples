using System;
using System.Collections.Generic;
using System.Linq;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.AdvancedUsage
{
	// Add Area annotation
    internal class AddAreaAnnotation
	{
		public static void Run()
		{
			var apiInstance = new AnnotateApi(Constants.GetConfig());

			try
			{
                var fileInfo = new FileInfo {FilePath = "one-page.docx"};

                AnnotationInfo[] annotations =
				{
					new AnnotationInfo
					{
						AnnotationPosition = new Point { X = 1, Y = 1 },
						Box = new Rectangle { X = 100, Y = 100, Width = 100, Height = 100 },
						PageNumber = 0,
						BackgroundColor = 65535,
						PenColor = 65535,
						PenStyle = AnnotationInfo.PenStyleEnum.Solid,
						PenWidth = 3,
                        Type = AnnotationInfo.TypeEnum.Area,
						Text = "This is area annotation",
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
                    FileInfo = fileInfo, Annotations = annotations.ToList(), OutputPath = "Output/output.docx"
                };

                var link = apiInstance.Annotate(new AnnotateRequest(options));
				Console.WriteLine("AddAreaAnnotation: Area Annotation added: " + link.Title);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling AnnotateApi: " + e.Message);
			}
		}
	}
}