#pragma checksum "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d35ea724653bb62dd5d0f96fdb43c1c373e31d78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Library_Login), @"mvc.1.0.view", @"/Views/Library/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Library/Login.cshtml", typeof(AspNetCore.Views_Library_Login))]
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
#line 1 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Login.cshtml"
using ILabrary.ModelViews.Libraries;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d35ea724653bb62dd5d0f96fdb43c1c373e31d78", @"/Views/Library/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d259f4a223f3bfacd8cd4f6d00f50b5d3ec9eab", @"/Views/_ViewImports.cshtml")]
    public class Views_Library_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryLoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(110, 187, true);
            WriteLiteral("<style>\r\n    #Username {\r\n        width: 300px;\r\n    }\r\n    #Password{\r\n        width: 300px;\r\n    }\r\n    .field-validation-error{\r\n        color: red\r\n    }\r\n</style>\r\n<h1>Login</h1>\r\n\r\n");
            EndContext();
            BeginContext(297, 853, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d35ea724653bb62dd5d0f96fdb43c1c373e31d784618", async() => {
                BeginContext(336, 152, true);
                WriteLiteral("\r\n    <fieldset style=\"        margin-left: auto;\r\n        margin-right: auto;\r\n        width: 500px\">\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(489, 38, false);
#line 24 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Login.cshtml"
       Write(Html.LabelFor(model => model.Username));

#line default
#line hidden
                EndContext();
                BeginContext(527, 66, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(594, 63, false);
#line 27 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Login.cshtml"
       Write(Html.EditorFor(x => x.Username, new { style = "width: 200px" }));

#line default
#line hidden
                EndContext();
                BeginContext(657, 19, true);
                WriteLiteral(" <br>\r\n            ");
                EndContext();
                BeginContext(677, 42, false);
#line 28 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Login.cshtml"
       Write(Html.ValidationMessageFor(x => x.Username));

#line default
#line hidden
                EndContext();
                BeginContext(719, 68, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(788, 38, false);
#line 32 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Login.cshtml"
       Write(Html.LabelFor(model => model.Password));

#line default
#line hidden
                EndContext();
                BeginContext(826, 66, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");
                EndContext();
                BeginContext(893, 33, false);
#line 35 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Login.cshtml"
       Write(Html.PasswordFor(x => x.Password));

#line default
#line hidden
                EndContext();
                BeginContext(926, 19, true);
                WriteLiteral(" <br>\r\n            ");
                EndContext();
                BeginContext(946, 42, false);
#line 36 "C:\Users\user\Documents\Visual Studio 2019\Projects\Final years projects\ILabrary\Views\Library\Login.cshtml"
       Write(Html.ValidationMessageFor(x => x.Password));

#line default
#line hidden
                EndContext();
                BeginContext(988, 155, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <br />\r\n        <p>\r\n            <input type=\"submit\" class=\"btn btn-primary\" value=\"Login\" />\r\n        </p>\r\n    </fieldset>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryLoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
