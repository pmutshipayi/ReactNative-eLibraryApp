#pragma checksum "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16b85e403dc79c02c7632516ac4a5b8ab7eb350e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LibraryUser_Update), @"mvc.1.0.view", @"/Views/LibraryUser/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LibraryUser/Update.cshtml", typeof(AspNetCore.Views_LibraryUser_Update))]
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
#line 5 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
using ILabrary.ModelViews.Libraries;

#line default
#line hidden
#line 6 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
using ILabrary.Services.Libraries;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16b85e403dc79c02c7632516ac4a5b8ab7eb350e", @"/Views/LibraryUser/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d259f4a223f3bfacd8cd4f6d00f50b5d3ec9eab", @"/Views/_ViewImports.cshtml")]
    public class Views_LibraryUser_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryUserUpdateViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "LibraryUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:600px;margin-left:auto;margin-right:auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
  
    ViewData["Title"] = "Update";

#line default
#line hidden
            BeginContext(202, 168, true);
            WriteLiteral("\r\n<div class=\"d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pb-2 mb-3 border-bottom\">\r\n    <div class=\"btn-toolbar mb-2 mb-md-0\">\r\n        ");
            EndContext();
            BeginContext(370, 171, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16b85e403dc79c02c7632516ac4a5b8ab7eb350e6420", async() => {
                BeginContext(474, 63, true);
                WriteLiteral("\r\n            <span data-feather=\"arrow-left\"></span>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(541, 218, true);
            WriteLiteral(" <span style=\"width:10px\"></span>\r\n        <h1 class=\"h4\"></h1>\r\n        <div class=\"btn-group mr-2\">\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<style>\r\n    .field-validation-error {\r\n        color: red\r\n    }\r\n</style>\r\n");
            EndContext();
            BeginContext(759, 2701, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16b85e403dc79c02c7632516ac4a5b8ab7eb350e8590", async() => {
                BeginContext(834, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 27 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
     if (TempData["updated"] != null)
    {
        

#line default
#line hidden
#line 29 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
         if ((bool)TempData["updated"])
        {

#line default
#line hidden
                BeginContext(934, 373, true);
                WriteLiteral(@"            <div class=""alert alert-success alert-dismissible fade show"" role=""alert"">
                <strong>Done!</strong> The account has been updated successfully.
                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
");
                EndContext();
#line 37 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
        }
        else
        {

#line default
#line hidden
                BeginContext(1343, 349, true);
                WriteLiteral(@"            <div class=""alert alert-danger alert-dismissible fade show"" role=""alert"">
                <strong>Hoops!</strong> The update failed.
                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
");
                EndContext();
#line 46 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
        }

#line default
#line hidden
#line 46 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
         
    }

#line default
#line hidden
                BeginContext(1710, 83, true);
                WriteLiteral("    <div class=\"form-row\">\r\n        <div class=\"form-group col-md-6\">\r\n            ");
                EndContext();
                BeginContext(1794, 31, false);
#line 50 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
       Write(Html.LabelFor(x => x.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(1825, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1840, 66, false);
#line 51 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
       Write(Html.TextBoxFor(x => x.FirstName, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1906, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1921, 43, false);
#line 52 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
       Write(Html.ValidationMessageFor(x => x.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(1964, 75, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-6\">\r\n            ");
                EndContext();
                BeginContext(2040, 30, false);
#line 56 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
       Write(Html.LabelFor(x => x.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(2070, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2085, 65, false);
#line 57 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
       Write(Html.TextBoxFor(x => x.LastName, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(2150, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2165, 42, false);
#line 58 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
       Write(Html.ValidationMessageFor(x => x.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(2207, 113, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-row\">\r\n        <div class=\"form-group col-md-8\">\r\n            ");
                EndContext();
                BeginContext(2321, 30, false);
#line 63 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
       Write(Html.LabelFor(x => x.Username));

#line default
#line hidden
                EndContext();
                BeginContext(2351, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2366, 65, false);
#line 64 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
       Write(Html.TextBoxFor(x => x.Username, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(2431, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2446, 42, false);
#line 65 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
       Write(Html.ValidationMessageFor(x => x.Username));

#line default
#line hidden
                EndContext();
                BeginContext(2488, 182, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group col-md-4\">\r\n            <label style=\"visibility:hidden\">Hidden</label>\r\n            <input type=\"text\" class=\"form-control\" disabled");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2670, "\"", 2735, 2);
#line 69 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
WriteAttributeValue("", 2678, Html.Raw("@"), 2678, 14, false);

#line default
#line hidden
#line 69 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
WriteAttributeValue("", 2692, libraryService.GetCurrentLibraryUniqueId(), 2692, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2736, 69, true);
                WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(2806, 27, false);
#line 73 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
   Write(Html.LabelFor(x => x.Email));

#line default
#line hidden
                EndContext();
                BeginContext(2833, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2844, 62, false);
#line 74 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
   Write(Html.TextBoxFor(x => x.Email, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(2906, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2917, 39, false);
#line 75 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
   Write(Html.ValidationMessageFor(x => x.Email));

#line default
#line hidden
                EndContext();
                BeginContext(2956, 52, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(3009, 27, false);
#line 78 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
   Write(Html.LabelFor(x => x.Phone));

#line default
#line hidden
                EndContext();
                BeginContext(3036, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3047, 62, false);
#line 79 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
   Write(Html.TextBoxFor(x => x.Phone, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(3109, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3120, 39, false);
#line 80 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
   Write(Html.ValidationMessageFor(x => x.Phone));

#line default
#line hidden
                EndContext();
                BeginContext(3159, 52, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(3212, 30, false);
#line 83 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
   Write(Html.LabelFor(x => x.Password));

#line default
#line hidden
                EndContext();
                BeginContext(3242, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3253, 66, false);
#line 84 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
   Write(Html.PasswordFor(x => x.Password, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(3319, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3330, 42, false);
#line 85 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\LibraryUser\Update.cshtml"
   Write(Html.ValidationMessageFor(x => x.Password));

#line default
#line hidden
                EndContext();
                BeginContext(3372, 81, true);
                WriteLiteral("\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Update</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
        public ILibrarySessionService libraryService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryUserUpdateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
