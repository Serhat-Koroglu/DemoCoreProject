#pragma checksum "C:\Users\Serhat\Desktop\DemoCoreProject\Demo.Core.MvcUI\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e150bfac0bcb3652e38c58e603ff7ab78bf035c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CategoryList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CategoryList_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e150bfac0bcb3652e38c58e603ff7ab78bf035c1", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"057a61269882b156b0266be8415ae9116118d878", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Demo.Core.MvcUI.Model.CategoryListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 32, true);
            WriteLiteral("\r\n<div class=\"list-group\">\r\n\r\n\r\n");
            EndContext();
#line 6 "C:\Users\Serhat\Desktop\DemoCoreProject\Demo.Core.MvcUI\Views\Shared\Components\CategoryList\Default.cshtml"
     foreach ( var category in  Model.Categories)
    {
        var css = "list-group-item";
        if ( category.CategoryID==Model.CurrentCategory)
        {
            css += "active";
        }

#line default
#line hidden
            BeginContext(290, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 300, "\"", 352, 2);
            WriteAttributeValue("", 307, "/product/index?/category=", 307, 25, true);
#line 13 "C:\Users\Serhat\Desktop\DemoCoreProject\Demo.Core.MvcUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 332, category.CategoryID, 332, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 353, "\"", 365, 1);
#line 13 "C:\Users\Serhat\Desktop\DemoCoreProject\Demo.Core.MvcUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 361, css, 361, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(366, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(368, 21, false);
#line 13 "C:\Users\Serhat\Desktop\DemoCoreProject\Demo.Core.MvcUI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                        Write(category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(389, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 14 "C:\Users\Serhat\Desktop\DemoCoreProject\Demo.Core.MvcUI\Views\Shared\Components\CategoryList\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(402, 10, true);
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Demo.Core.MvcUI.Model.CategoryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
