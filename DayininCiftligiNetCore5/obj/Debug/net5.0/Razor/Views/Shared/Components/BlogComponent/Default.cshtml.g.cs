#pragma checksum "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\BlogComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "722d97dedcb511372e8893547f8640ca2ffc7ece"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogComponent/Default.cshtml")]
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
#nullable restore
#line 1 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\_ViewImports.cshtml"
using DayininCiftligiNetCore5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\_ViewImports.cshtml"
using DayininCiftligiNetCore5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\_ViewImports.cshtml"
using DayininCiftligiNetCore5.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\_ViewImports.cshtml"
using DayininCiftligiNetCore5.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\_ViewImports.cshtml"
using DayininCiftligiNetCore5.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"722d97dedcb511372e8893547f8640ca2ffc7ece", @"/Views/Shared/Components/BlogComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7b034373e4d1000e7436d9f6fa74bff58a4bdfd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogSectionModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--================ Start Blog Area =================-->\r\n<section class=\"latest-blog-area area-padding-top\" id=\"blog\">\r\n    <div class=\"container\">\r\n        <h1 class=\"text-center\">");
#nullable restore
#line 8 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\BlogComponent\Default.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p class=\"page-description text-center\">");
#nullable restore
#line 9 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\BlogComponent\Default.cshtml"
                                           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <div class=\"row\" style=\"padding-top: 40px;\">\r\n");
#nullable restore
#line 11 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\BlogComponent\Default.cshtml"
             foreach (var blog in Model.HomeBlogModels)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 \">\r\n                    <div class=\"single-blog\">\r\n                        <div class=\"thumb\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "722d97dedcb511372e8893547f8640ca2ffc7ece6074", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 696, "~/img/", 696, 6, true);
#nullable restore
#line 16 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\BlogComponent\Default.cshtml"
AddHtmlAttributeValue("", 702, blog.SmallImageUrl, 702, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""single-blog-content"">
                            <p class=""tag"">Haberler, Etkinlikler</p>
                            <p class=""date"">24 Haziran 2019</p>
                            <h4>
                                <a");
            BeginWriteAttribute("href", " href=\"", 1026, "\"", 1042, 1);
#nullable restore
#line 22 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\BlogComponent\Default.cshtml"
WriteAttributeValue("", 1033, blog.Url, 1033, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\BlogComponent\Default.cshtml"
                                               Write(blog.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                            </h4>
                            <div class=""meta-bottom d-flex"">
                                <p class=""likes""><i class=""ti-comments""></i> 0 Yorum</p>
                                <p><i class=""ti-heart""></i> 0 </p>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 31 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\BlogComponent\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div> <!-- row end-->\r\n        <div class=\"row\">\r\n            <div class=\"mx-auto\">\r\n                <a class=\"galeri-baglanti\"");
            BeginWriteAttribute("href", " href=\"", 1588, "\"", 1611, 1);
#nullable restore
#line 35 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\BlogComponent\Default.cshtml"
WriteAttributeValue("", 1595, Model.ButtonUrl, 1595, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\BlogComponent\Default.cshtml"
                                                              Write(Model.ButtonText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!--================ End Blog Area =================-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogSectionModel> Html { get; private set; }
    }
}
#pragma warning restore 1591