#pragma checksum "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Grid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85219488a53194a0ba6cd73458087950b762cd7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Grid), @"mvc.1.0.view", @"/Views/Book/Grid.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Grid.cshtml", typeof(AspNetCore.Views_Book_Grid))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\_ViewImports.cshtml"
using ILabrary;

#line default
#line hidden
#line 2 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\_ViewImports.cshtml"
using ILabrary.Models;

#line default
#line hidden
#line 5 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Grid.cshtml"
using ILabrary.ModelViews.Libraries;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85219488a53194a0ba6cd73458087950b762cd7c", @"/Views/Book/Grid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d259f4a223f3bfacd8cd4f6d00f50b5d3ec9eab", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Grid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Grid.cshtml"
  
    ViewData["Title"] = "Grid";

#line default
#line hidden
            BeginContext(117, 44, false);
#line 7 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Grid.cshtml"
Write(await Html.PartialAsync("BookTopBar.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(161, 95, true);
            WriteLiteral("\r\n\r\n<div class=\"album py-5 bg-light\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 12 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Grid.cshtml"
             foreach (var book in Model)
            {

#line default
#line hidden
            BeginContext(313, 60, true);
            WriteLiteral("                <div class=\"col-md-3\">\r\n                    ");
            EndContext();
            BeginContext(373, 2269, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85219488a53194a0ba6cd73458087950b762cd7c5084", async() => {
                BeginContext(442, 61, true);
                WriteLiteral("\r\n                        <div class=\"card mb-3 shadow-sm\">\r\n");
                EndContext();
#line 17 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Grid.cshtml"
                              
                                BookPictureViewModel image = null;
                                if (book.Images.Any())
                                {
                                   image = book.Images.ToList()[book.Images.Count - 1];
                                }
                                string imagePath = "";
                                if (image != null)
                                {
                                    imagePath = "/uploads/" + image.FullPath;
                                }
                            

#line default
#line hidden
                BeginContext(1106, 28, true);
                WriteLiteral("                            ");
                EndContext();
#line 29 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Grid.cshtml"
                             if (!string.IsNullOrEmpty(imagePath))
                            {

#line default
#line hidden
                BeginContext(1205, 102, true);
                WriteLiteral("                                <img class=\"bd-placeholder-img card-img-top\" width=\"100%\" height=\"225\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1307, "\"", 1336, 1);
#line 31 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Grid.cshtml"
WriteAttributeValue("", 1313, Url.Content(imagePath), 1313, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1337, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 32 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Grid.cshtml"
                            }
                            else
                            {

#line default
#line hidden
                BeginContext(1438, 387, true);
                WriteLiteral(@"                                <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"" role=""img"" aria-label=""Placeholder: Thumbnail""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c"" /><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>
");
                EndContext();
#line 36 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Grid.cshtml"
                            }

#line default
#line hidden
                BeginContext(1856, 126, true);
                WriteLiteral("                            <div class=\"card-body\">\r\n                                <p>\r\n                                    ");
                EndContext();
                BeginContext(1983, 31, false);
#line 39 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Grid.cshtml"
                               Write(Html.DisplayFor(x => book.Name));

#line default
#line hidden
                EndContext();
                BeginContext(2014, 40, true);
                WriteLiteral("\r\n                                </p>\r\n");
                EndContext();
#line 41 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Grid.cshtml"
                                 if (!string.IsNullOrWhiteSpace(book.Barcode))
                                {

#line default
#line hidden
                BeginContext(2169, 94, true);
                WriteLiteral("                                    <span>\r\n                                        Barcode : ");
                EndContext();
                BeginContext(2264, 34, false);
#line 44 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Grid.cshtml"
                                             Write(Html.DisplayFor(x => book.Barcode));

#line default
#line hidden
                EndContext();
                BeginContext(2298, 47, true);
                WriteLiteral("\r\n                                    </span>\r\n");
                EndContext();
#line 46 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Grid.cshtml"
                                }

#line default
#line hidden
                BeginContext(2380, 91, true);
                WriteLiteral("                                <p class=\"card-text\">\r\n                                    ");
                EndContext();
                BeginContext(2472, 38, false);
#line 48 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Grid.cshtml"
                               Write(Html.DisplayFor(x => book.Description));

#line default
#line hidden
                EndContext();
                BeginContext(2510, 128, true);
                WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Grid.cshtml"
                                                                   WriteLiteral(book.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2642, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 54 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Grid.cshtml"
            }

#line default
#line hidden
            BeginContext(2683, 34, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
