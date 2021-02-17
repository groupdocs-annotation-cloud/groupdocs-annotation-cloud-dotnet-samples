using System;
using System.Collections.Generic;
using System.Linq;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Model;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Examples.AdvancedUsage
{
    // Add Multiple annotations
    internal class AddMultipleAnnotations
	{
		public static void Run()
		{
			var apiInstance = new AnnotateApi(Constants.GetConfig());

			try
			{
                var fileInfo = new FileInfo { FilePath = "ten-pages.pdf" };

				AnnotationInfo[] annotations =
				{
                    new AnnotationInfo
                    {
                        AnnotationPosition = new Point { X = 1, Y = 1 },
                        Box = new Rectangle { X = 100, Y = 100, Width = 100, Height = 100 },
                        PageNumber = 1,
                        BackgroundColor=65535,
                        PenColor = 65535,
                        PenStyle = AnnotationInfo.PenStyleEnum.Solid,
                        PenWidth = 3,
                        Opacity = 0.7,
                        Type = AnnotationInfo.TypeEnum.Area,
                        Text="This is area annotation",
                        CreatorName = "Anonym A.",
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
                        } },
                    new AnnotationInfo
                    {
                        AnnotationPosition = new Point { X = 852, Y = 59.388262910798119 },
                        Box = new Rectangle { X = 375.89276123046875, Y = 59.388263702392578, Width = 88.7330551147461, Height = 37.7290153503418 },
                        PageNumber = 2,
                        PenColor = 1201033,
                        PenStyle = 0,
                        PenWidth = 1,
                        Type = AnnotationInfo.TypeEnum.Area,
                        CreatorName = "Anonym A."
                    },
                    new AnnotationInfo
                    {
                        AnnotationPosition = new Point { X = 852, Y = 59.388262910798119 },
                        Box = new Rectangle { X = 375.89276123046875, Y = 59.388263702392578, Width = 88.7330551147461, Height = 37.7290153503418 },
                        PageNumber = 4,
                        Type = AnnotationInfo.TypeEnum.Point,
                        CreatorName = "Anonym A."
                    },
                    new AnnotationInfo
                    {
                        AnnotationPosition = new Point { X = 852, Y = 59.388262910798119 },
                        Box = new Rectangle { X = 375.89276123046875, Y = 59.388263702392578, Width = 88.7330551147461, Height = 37.7290153503418 },
                        PageNumber = 5,
                        PenColor = 1201033,
                        PenStyle = 0,
                        PenWidth = 1,
                        Type = AnnotationInfo.TypeEnum.Arrow,
                        CreatorName = "Anonym A."
                    }
				};

                var options = new AnnotateOptions
                {
                    FileInfo = fileInfo,
                    Annotations = annotations.ToList(),
                    OutputPath = "Output/output.pdf"
                };

                var link = apiInstance.Annotate(new AnnotateRequest(options));
                Console.WriteLine("AddMultipleAnnotations: Multiple Annotation added: " + link.Title);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling AnnotateApi: " + e.Message);
			}
		}
	}
}