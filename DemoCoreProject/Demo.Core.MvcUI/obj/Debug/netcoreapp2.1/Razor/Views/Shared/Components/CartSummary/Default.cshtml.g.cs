#pragma checksum "C:\Users\Serhat\Desktop\DemoCoreProject\Demo.Core.MvcUI\Views\Shared\Components\CartSummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd4af077e20f6377bc076b669ed677bf1f11e5da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CartSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CartSummary/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CartSummary_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd4af077e20f6377bc076b669ed677bf1f11e5da", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"057a61269882b156b0266be8415ae9116118d878", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CartSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Demo.Core.MvcUI.Model.CartSummaryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 32, true);
            WriteLiteral("\r\n<ul class=\"dropdown-menu\">\r\n\r\n");
            EndContext();
#line 5 "C:\Users\Serhat\Desktop\DemoCoreProject\Demo.Core.MvcUI\Views\Shared\Components\CartSummary\Default.cshtml"
     foreach (var item in Model.Cart.CartLine)
    {

#line default
#line hidden
            BeginContext(138, 29, true);
            WriteLiteral("        <li>\r\n            <a>");
            EndContext();
            BeginContext(168, 25, false);
#line 8 "C:\Users\Serhat\Desktop\DemoCoreProject\Demo.Core.MvcUI\Views\Shared\Components\CartSummary\Default.cshtml"
          Write(item.Products.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(193, 20, true);
            WriteLiteral("<span class=\"badge\">");
            EndContext();
            BeginContext(214, 13, false);
#line 8 "C:\Users\Serhat\Desktop\DemoCoreProject\Demo.Core.MvcUI\Views\Shared\Components\CartSummary\Default.cshtml"
                                                        Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(227, 28, true);
            WriteLiteral("</span></a>\r\n        </li>\r\n");
            EndContext();
#line 10 "C:\Users\Serhat\Desktop\DemoCoreProject\Demo.Core.MvcUI\Views\Shared\Components\CartSummary\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(262, 149, true);
            WriteLiteral("    <li role=\"separator\" class=\"divider\"></li>\r\n\r\n    <li>\r\n        <a><span class=\"glyphicon-align-left glyphicon-shopping-cart\" aria-hidden=\"true\">");
            EndContext();
            BeginContext(412, 16, false);
#line 14 "C:\Users\Serhat\Desktop\DemoCoreProject\Demo.Core.MvcUI\Views\Shared\Components\CartSummary\Default.cshtml"
                                                                                    Write(Model.Cart.Total);

#line default
#line hidden
            EndContext();
            BeginContext(428, 92, true);
            WriteLiteral("</span></a>\r\n    </li>\r\n    <li role=\"separator\" class=\"divider\"></li>\r\n\r\n    <li>\r\n        ");
            EndContext();
            BeginContext(520, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd4af077e20f6377bc076b669ed677bf1f11e5da5927", async() => {
                BeginContext(563, 17, true);
                WriteLiteral("Goto cart details");
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
            BeginContext(584, 20, true);
            WriteLiteral("\r\n    </li>\r\n\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Demo.Core.MvcUI.Model.CartSummaryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591