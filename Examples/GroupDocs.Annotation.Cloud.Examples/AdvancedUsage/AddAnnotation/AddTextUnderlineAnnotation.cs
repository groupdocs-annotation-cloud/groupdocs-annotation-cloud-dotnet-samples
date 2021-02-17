using System;
using System.Collections.Generic;
using System.Linq;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.AdvancedUsage
{
	// Add Text Underline annotations
	internal class AddTextUnderlineAnnotation
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
                        Points = new List<Point>
                        {
                            new Point {X = 80, Y = 730}, new Point {X=240, Y=730}, new Point {X=80, Y=650}, new Point {X=240, Y=650}
                        },
						FontColor = 65535,
                        PageNumber = 0,
                        Type = AnnotationInfo.TypeEnum.TextUnderline,
                        Text = "This is text underline annotation",
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
                Console.WriteLine("AddTextUnderlineAnnotation: Text Underline Annotation added: " + link.Title);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling AnnotateApi: " + e.Message);
			}
		}
	}
}