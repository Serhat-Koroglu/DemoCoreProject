#pragma checksum "C:\Users\Serhat\Desktop\DemoCoreProject\Demo.Core.MvcUI\Views\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a066887f0ddae93522da07fe518dfc89cfcc1d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__AdminLayout), @"mvc.1.0.view", @"/Views/_AdminLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/_AdminLayout.cshtml", typeof(AspNetCore.Views__AdminLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a066887f0ddae93522da07fe518dfc89cfcc1d0", @"/Views/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"057a61269882b156b0266be8415ae9116118d878", @"/Views/_ViewImports.cshtml")]
    public class Views__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 581, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a066887f0ddae93522da07fe518dfc89cfcc1d03881", async() => {
                BeginContext(31, 121, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
                EndContext();
                BeginContext(153, 17, false);
#line 6 "C:\Users\Serhat\Desktop\DemoCoreProject\Demo.Core.MvcUI\Views\_AdminLayout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(170, 429, true);
                WriteLiteral(@"</title>
      <link href=""/node_modules/bootstrap/dist/css/bootstrap.css"" rel=""stylesheet"" />
    <script src=""/node_modules/jquery/dist/jquery.min.js""></script>
    <script src=""/node_modules/bootstrap/dist/js/bootstrap.js""></script>
    <script src=""/node_modules/jquery-validation/dist/jquery.validate.js""></script>
    <script src=""/node_modules/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(606, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(608, 2000, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a066887f0ddae93522da07fe518dfc89cfcc1d05983", async() => {
                BeginContext(614, 1073, true);
                WriteLiteral(@"
       <div class=""col-md-12"">
        <nav class=""navbar navbar-default"">
            <div class=""container-fluid"">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class=""navbar-header"">
                    <button type=""button"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target=""#bs-example-navbar-collapse-1"" aria-expanded=""false"">
                        <span class=""sr-only"">Toggle navigation</span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                    </button>
                    <a class=""navbar-brand"" href=""#"">Northwind Admin Panel</a>
                </div>
                                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class=""collapse navbar-collapse"" id=""bs-example-navbar-collapse-1"">
                    <ul class=""nav navbar-n");
                WriteLiteral("av\">\r\n                        <li class=\"active\">");
                EndContext();
                BeginContext(1687, 99, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a066887f0ddae93522da07fe518dfc89cfcc1d07513", async() => {
                    BeginContext(1734, 48, true);
                    WriteLiteral("Admin<span class=\"sr-only\">Product Store<</span>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1786, 339, true);
                WriteLiteral(@"</li>
                    </ul>
                    <ul class=""nav navbar-nav navbar-right"">
                        <li class=""dropdown"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false""> <span class=""caret""></span></a>
                  ");
                EndContext();
                BeginContext(2126, 42, false);
#line 35 "C:\Users\Serhat\Desktop\DemoCoreProject\Demo.Core.MvcUI\Views\_AdminLayout.cshtml"
             Write(await Component.InvokeAsync("UserSummary"));

#line default
#line hidden
                EndContext();
                BeginContext(2168, 214, true);
                WriteLiteral("\r\n                      </li>\r\n                    </ul>\r\n                </div><!-- /.navbar-collapse -->\r\n            </div><!-- /.container-fluid -->\r\n        </nav>\r\n    </div>\r\n       <div class=\"col-md-10\">\r\n");
                EndContext();
#line 43 "C:\Users\Serhat\Desktop\DemoCoreProject\Demo.Core.MvcUI\Views\_AdminLayout.cshtml"
         if(TempData["message"]!=null)
        {

#line default
#line hidden
                BeginContext(2433, 55, true);
                WriteLiteral("            <div class=\"alert alert-info\" role=\"alert\">");
                EndContext();
                BeginContext(2489, 19, false);
#line 45 "C:\Users\Serhat\Desktop\DemoCoreProject\Demo.Core.MvcUI\Views\_AdminLayout.cshtml"
                                                  Write(TempData["message"]);

#line default
#line hidden
                EndContext();
                BeginContext(2508, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 46 "C:\Users\Serhat\Desktop\DemoCoreProject\Demo.Core.MvcUI\Views\_AdminLayout.cshtml"
        }

#line default
#line hidden
                BeginContext(2527, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2538, 12, false);
#line 48 "C:\Users\Serhat\Desktop\DemoCoreProject\Demo.Core.MvcUI\Views\_AdminLayout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2550, 51, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-12\"></div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2608, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
