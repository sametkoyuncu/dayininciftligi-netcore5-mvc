#pragma checksum "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\FooterComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0169a41813144b4102a7e23ac0cc8abc166def6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FooterComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FooterComponent/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0169a41813144b4102a7e23ac0cc8abc166def6", @"/Views/Shared/Components/FooterComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7b034373e4d1000e7436d9f6fa74bff58a4bdfd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FooterComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FooterModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 50%; height:auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddSubscriber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- ================ start footer Area ================= -->
<footer class=""footer-area"" id=""footer"">
    <div class=""container"">
        <div class=""row"">

            <div class=""col-lg-3 col-sm-6 mb-4 mb-xl-0 single-footer-widget"">
                <h4>");
#nullable restore
#line 8 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\FooterComponent\Default.cshtml"
               Write(Model.FooterWidgets[0].Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p>");
#nullable restore
#line 9 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\FooterComponent\Default.cshtml"
              Write(Model.FooterWidgets[0].Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"footer-logo\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b0169a41813144b4102a7e23ac0cc8abc166def66838", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 478, "~/img/logos/", 478, 12, true);
#nullable restore
#line 11 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\FooterComponent\Default.cshtml"
AddHtmlAttributeValue("", 490, Model.FooterWidgets[0].ImageUrl, 490, 32, false);

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
            </div>

            <div class=""col-lg-3 col-sm-6 mb-4 mb-xl-0 single-footer-widget"">
                <h4>İletişim Bilgileri</h4>
                <div class=""footer-address"">
                    <p><i style=""color: #94fc13;"">Adres :</i> <br>");
#nullable restore
#line 18 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\FooterComponent\Default.cshtml"
                                                             Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 18 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\FooterComponent\Default.cshtml"
                                                                             Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <span><i style=\"color: #94fc13;\">Telefon :</i> <br>");
#nullable restore
#line 19 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\FooterComponent\Default.cshtml"
                                                                  Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span><i style=\"color: #94fc13;\">E-posta :</i> <br>");
#nullable restore
#line 20 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\FooterComponent\Default.cshtml"
                                                                  Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"col-lg-3 col-sm-6 mb-4 mb-xl-0 single-footer-widget\">\r\n                <h4>Bağlantılar</h4>\r\n                <ul>\r\n");
#nullable restore
#line 27 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\FooterComponent\Default.cshtml"
                     foreach (var navItem in Model.NavItems)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1357, "\"", 1420, 3);
            WriteAttributeValue("", 1367, "smoothScroll(document.getElementById(\'", 1367, 38, true);
#nullable restore
#line 29 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\FooterComponent\Default.cshtml"
WriteAttributeValue("", 1405, navItem.Url, 1405, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1417, "\'))", 1417, 3, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\FooterComponent\Default.cshtml"
                                                                                                                   Write(navItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 30 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\FooterComponent\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n\r\n            <div class=\"col-lg-3 col-sm-6 mb-4 mb-xl-0 single-footer-widget\">\r\n                <h4>");
#nullable restore
#line 35 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\FooterComponent\Default.cshtml"
               Write(Model.FooterWidgets[1].Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p>");
#nullable restore
#line 36 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\FooterComponent\Default.cshtml"
              Write(Model.FooterWidgets[1].Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <div class=\"form-wrap\"");
            BeginWriteAttribute("id", " id=\"", 1743, "\"", 1748, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0169a41813144b4102a7e23ac0cc8abc166def613124", async() => {
                WriteLiteral(@"
                        <div class=""input-group"">
                            <input type=""Email"" class=""form-control"" name=""Email"" placeholder=""Abone olmak için tıkla.."" onfocus=""this.placeholder = 'E-posta veya Telefon..'"" onblur=""this.placeholder = 'E-posta veya Telefon..'"">
                            <div class=""input-group-append"">
                                <button class=""btn click-btn"" type=""submit"">
                                    <i class=""fab fa-telegram-plane""></i>
                                </button>
                            </div>
                        </div>

                        <div class=""info""></div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"footer-bottom row align-items-center text-center text-lg-left no-gutters\">\r\n");
            WriteLiteral(@"            <p class=""footer-text m-0 col-lg-8 col-md-12"">
                <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                Copyright &copy;
                <script>document.write(new Date().getFullYear());</script> All rights reserved | This template is made with <i class=""fa fa-heart"" aria-hidden=""true""></i> by <a href=""https://colorlib.com"" target=""_blank"">Colorlib</a> and edited by <a href=""https://www.instagram.com/sametkoyuncu_/"" target=""_blank"">sk.</a>
                <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                <br>
                ");
#nullable restore
#line 63 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\FooterComponent\Default.cshtml"
           Write(ViewBag.CopyrightForFooter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <div class=\"col-lg-4 col-md-12 text-center text-lg-right footer-social\">\r\n");
#nullable restore
#line 66 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\FooterComponent\Default.cshtml"
                 foreach (var socialMedia in Model.SocialMedias)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 3640, "\"", 3663, 1);
#nullable restore
#line 68 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\FooterComponent\Default.cshtml"
WriteAttributeValue("", 3647, socialMedia.Url, 3647, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><i");
            BeginWriteAttribute("class", " class=\"", 3683, "\"", 3708, 1);
#nullable restore
#line 68 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\FooterComponent\Default.cshtml"
WriteAttributeValue("", 3691, socialMedia.Icon, 3691, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n");
#nullable restore
#line 69 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Views\Shared\Components\FooterComponent\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</footer>\r\n<!-- ================ End footer Area ================= -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FooterModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
