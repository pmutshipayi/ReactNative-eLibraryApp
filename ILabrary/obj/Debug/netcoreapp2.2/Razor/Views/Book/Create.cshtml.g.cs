#pragma checksum "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "611e82d9fc5284e2604cecd140046a34036aa085"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Create), @"mvc.1.0.view", @"/Views/Book/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Create.cshtml", typeof(AspNetCore.Views_Book_Create))]
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
#line 5 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Create.cshtml"
using ILabrary.ModelViews.Libraries;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"611e82d9fc5284e2604cecd140046a34036aa085", @"/Views/Book/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d259f4a223f3bfacd8cd4f6d00f50b5d3ec9eab", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookCreateViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Create.cshtml"
  
    ViewData["Title"] = "Create new book";

#line default
#line hidden
            BeginContext(122, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(127, 67, false);
#line 9 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Create.cshtml"
Write(await Html.PartialAsync("BookTopBarBack.cshtml", "Create new book"));

#line default
#line hidden
            EndContext();
            BeginContext(194, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(200, 1889, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "611e82d9fc5284e2604cecd140046a34036aa0855318", async() => {
                BeginContext(266, 154, true);
                WriteLiteral("\r\n    <fieldset style=\"        margin-left: auto;\r\n        margin-right: auto;\r\n        width: 500px\">\r\n\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(421, 26, false);
#line 18 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Create.cshtml"
       Write(Html.LabelFor(x => x.Name));

#line default
#line hidden
                EndContext();
                BeginContext(447, 66, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(514, 27, false);
#line 21 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Create.cshtml"
       Write(Html.EditorFor(x => x.Name));

#line default
#line hidden
                EndContext();
                BeginContext(541, 18, true);
                WriteLiteral("<br>\r\n            ");
                EndContext();
                BeginContext(560, 71, false);
#line 22 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.Name, "", new { style = "color:red" }));

#line default
#line hidden
                EndContext();
                BeginContext(631, 68, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(700, 29, false);
#line 26 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Create.cshtml"
       Write(Html.LabelFor(x => x.Barcode));

#line default
#line hidden
                EndContext();
                BeginContext(729, 66, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(796, 30, false);
#line 29 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Create.cshtml"
       Write(Html.EditorFor(x => x.Barcode));

#line default
#line hidden
                EndContext();
                BeginContext(826, 18, true);
                WriteLiteral("<br>\r\n            ");
                EndContext();
                BeginContext(845, 74, false);
#line 30 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.Barcode, "", new { style = "color:red" }));

#line default
#line hidden
                EndContext();
                BeginContext(919, 146, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            Is Available\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(1066, 34, false);
#line 37 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Create.cshtml"
       Write(Html.EditorFor(x => x.IsAvailable));

#line default
#line hidden
                EndContext();
                BeginContext(1100, 18, true);
                WriteLiteral("<br>\r\n            ");
                EndContext();
                BeginContext(1119, 45, false);
#line 38 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.IsAvailable));

#line default
#line hidden
                EndContext();
                BeginContext(1164, 68, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(1233, 33, false);
#line 42 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Create.cshtml"
       Write(Html.LabelFor(x => x.Description));

#line default
#line hidden
                EndContext();
                BeginContext(1266, 66, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(1333, 67, false);
#line 45 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Create.cshtml"
       Write(Html.TextAreaFor(x => x.Description, new { style = "width:350px" }));

#line default
#line hidden
                EndContext();
                BeginContext(1400, 18, true);
                WriteLiteral("<br>\r\n            ");
                EndContext();
                BeginContext(1419, 45, false);
#line 46 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.Description));

#line default
#line hidden
                EndContext();
                BeginContext(1464, 68, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(1533, 30, false);
#line 50 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Create.cshtml"
       Write(Html.LabelFor(x => x.BookTags));

#line default
#line hidden
                EndContext();
                BeginContext(1563, 66, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(1630, 64, false);
#line 53 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Create.cshtml"
       Write(Html.TextAreaFor(x => x.BookTags, new { style = "width:350px" }));

#line default
#line hidden
                EndContext();
                BeginContext(1694, 18, true);
                WriteLiteral("<br>\r\n            ");
                EndContext();
                BeginContext(1713, 42, false);
#line 54 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Book\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.BookTags));

#line default
#line hidden
                EndContext();
                BeginContext(1755, 327, true);
                WriteLiteral(@"
        </div>

        <div class=""editor-label"">
            <p>Upload one or more files using this form:</p>
            <input type=""file"" name=""files"" multiple>
        </div>
        <br />
        <p>
            <input type=""submit"" class=""btn btn-primary"" value=""Add book"" />
        </p>
    </fieldset>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookCreateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
