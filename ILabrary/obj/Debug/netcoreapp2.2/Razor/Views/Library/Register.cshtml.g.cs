#pragma checksum "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "867bed65122428c1ad4e6d4f6f943ecf72e1e1a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Library_Register), @"mvc.1.0.view", @"/Views/Library/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Library/Register.cshtml", typeof(AspNetCore.Views_Library_Register))]
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
#line 1 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
using ILabrary.ModelViews.Libraries;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"867bed65122428c1ad4e6d4f6f943ecf72e1e1a0", @"/Views/Library/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d259f4a223f3bfacd8cd4f6d00f50b5d3ec9eab", @"/Views/_ViewImports.cshtml")]
    public class Views_Library_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryCreateViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateLibrary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
            BeginContext(116, 212, true);
            WriteLiteral("\r\n<h1>Register</h1>\r\n<style>\r\n    .text-box, password {\r\n        width: 350px;\r\n       \r\n    }\r\n    label{\r\n         font-weight: 600\r\n    }\r\n\r\n    .field-validation-valid {\r\n        color: red\r\n    }\r\n</style>\r\n");
            EndContext();
            BeginContext(328, 2808, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "867bed65122428c1ad4e6d4f6f943ecf72e1e1a04687", async() => {
                BeginContext(375, 200, true);
                WriteLiteral("\r\n    <fieldset style=\"        margin-left: auto;\r\n        margin-right: auto;\r\n        width: 500px\">\r\n        <legend> Library information </legend>\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(576, 34, false);
#line 27 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(610, 66, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(677, 27, false);
#line 30 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.EditorFor(x => x.Name));

#line default
#line hidden
                EndContext();
                BeginContext(704, 19, true);
                WriteLiteral(" <br>\r\n            ");
                EndContext();
                BeginContext(724, 71, false);
#line 31 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.ValidationMessageFor(x => x.Name, "", new { style = "color:red" }));

#line default
#line hidden
                EndContext();
                BeginContext(795, 143, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            Unique ID\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(939, 31, false);
#line 38 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.EditorFor(x => x.UniqueId));

#line default
#line hidden
                EndContext();
                BeginContext(970, 19, true);
                WriteLiteral(" <br>\r\n            ");
                EndContext();
                BeginContext(990, 75, false);
#line 39 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.ValidationMessageFor(x => x.UniqueId, "", new { style = "color:red" }));

#line default
#line hidden
                EndContext();
                BeginContext(1065, 68, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(1134, 29, false);
#line 43 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.LabelFor(x => x.Address));

#line default
#line hidden
                EndContext();
                BeginContext(1163, 66, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(1230, 63, false);
#line 46 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.TextAreaFor(x => x.Address, new { style = "width:350px" }));

#line default
#line hidden
                EndContext();
                BeginContext(1293, 18, true);
                WriteLiteral("<br>\r\n            ");
                EndContext();
                BeginContext(1312, 74, false);
#line 47 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.ValidationMessageFor(x => x.Address, "", new { style = "color:red" }));

#line default
#line hidden
                EndContext();
                BeginContext(1386, 117, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <legend>Personal information</legend>\r\n\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(1504, 31, false);
#line 53 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.LabelFor(x => x.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(1535, 66, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(1602, 32, false);
#line 56 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.EditorFor(x => x.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(1634, 19, true);
                WriteLiteral(" <br>\r\n            ");
                EndContext();
                BeginContext(1654, 76, false);
#line 57 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.ValidationMessageFor(x => x.FirstName, "", new { style = "color:red" }));

#line default
#line hidden
                EndContext();
                BeginContext(1730, 68, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(1799, 30, false);
#line 61 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.LabelFor(x => x.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(1829, 66, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(1896, 31, false);
#line 64 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.EditorFor(x => x.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(1927, 19, true);
                WriteLiteral(" <br>\r\n            ");
                EndContext();
                BeginContext(1947, 75, false);
#line 65 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.ValidationMessageFor(x => x.LastName, "", new { style = "color:red" }));

#line default
#line hidden
                EndContext();
                BeginContext(2022, 68, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(2091, 27, false);
#line 69 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.LabelFor(x => x.Email));

#line default
#line hidden
                EndContext();
                BeginContext(2118, 66, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(2185, 28, false);
#line 72 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.EditorFor(x => x.Email));

#line default
#line hidden
                EndContext();
                BeginContext(2213, 19, true);
                WriteLiteral(" <br>\r\n            ");
                EndContext();
                BeginContext(2233, 72, false);
#line 73 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.ValidationMessageFor(x => x.Email, "", new { style = "color:red" }));

#line default
#line hidden
                EndContext();
                BeginContext(2305, 68, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(2374, 30, false);
#line 77 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.LabelFor(x => x.Username));

#line default
#line hidden
                EndContext();
                BeginContext(2404, 66, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(2471, 31, false);
#line 80 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.EditorFor(x => x.Username));

#line default
#line hidden
                EndContext();
                BeginContext(2502, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2504, 13, false);
#line 80 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
                                        Write(Html.Raw("@"));

#line default
#line hidden
                EndContext();
                BeginContext(2517, 53, true);
                WriteLiteral(" <span id=\"unique_id_span\"></span> <br>\r\n            ");
                EndContext();
                BeginContext(2571, 75, false);
#line 81 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.ValidationMessageFor(x => x.Username, "", new { style = "color:red" }));

#line default
#line hidden
                EndContext();
                BeginContext(2646, 68, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(2715, 30, false);
#line 85 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.LabelFor(x => x.Password));

#line default
#line hidden
                EndContext();
                BeginContext(2745, 66, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(2812, 64, false);
#line 88 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.PasswordFor(x => x.Password, new { style = "width:350px" }));

#line default
#line hidden
                EndContext();
                BeginContext(2876, 19, true);
                WriteLiteral(" <br>\r\n            ");
                EndContext();
                BeginContext(2896, 75, false);
#line 89 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Register.cshtml"
       Write(Html.ValidationMessageFor(x => x.Password, "", new { style = "color:red" }));

#line default
#line hidden
                EndContext();
                BeginContext(2971, 158, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <br />\r\n        <p>\r\n            <input type=\"submit\" class=\"btn btn-primary\" value=\"Register\" />\r\n        </p>\r\n    </fieldset>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3136, 191, true);
            WriteLiteral("\r\n<script>\r\n    $(\"#UniqueId\").keyup(function () {\r\n        $(\"#unique_id_span\").html($(\"#UniqueId\").val());\r\n        console.log(\"value changed \" + $(\"#UniqueId\").val());\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryCreateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
