#pragma checksum "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\Message\Trash.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "054a7301e4d35c93f631b5d37f1f763ee330018b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Message_Trash), @"mvc.1.0.view", @"/Areas/Admin/Views/Message/Trash.cshtml")]
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
#line 1 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\_ViewImports.cshtml"
using DayininCiftligiNetCore5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\_ViewImports.cshtml"
using DayininCiftligiNetCore5.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\_ViewImports.cshtml"
using DayininCiftligiNetCore5.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\_ViewImports.cshtml"
using DayininCiftligiNetCore5.Areas.Admin.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\_ViewImports.cshtml"
using DayininCiftligiNetCore5.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"054a7301e4d35c93f631b5d37f1f763ee330018b", @"/Areas/Admin/Views/Message/Trash.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"428b298594cad92f77a30d49540cb92675cb99dd", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Message_Trash : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MessageModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ResultMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/Message/MoveToInbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/Message/MoveToArchive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\Message\Trash.cshtml"
  
    int index = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\Message\Trash.cshtml"
 if (TempData["message"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "054a7301e4d35c93f631b5d37f1f763ee330018b6429", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 8 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\Message\Trash.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = (TempData.Get<AlertMessageAdmin>("message"));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\Message\Trash.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- sosyal medya start -->
<div class=""col-12 mt-3 mb-5"">
    <div class=""card"">
        <div class=""card-body"">
            <div class=""row"">
                <div class=""col"">
                    <h4 class=""header-title"">Çöp Kutusu&nbsp;&nbsp;</h4>
                </div>
            </div>
");
            WriteLiteral(@"            <div class=""single-table"">
                <div class=""table-responsive"">
                    <table class=""table table-hover progress-table text-left"">
                        <thead class=""text-uppercase bg-mor"">
                            <tr>
                                <th scope=""col"">Sıra</th>
                                <th scope=""col"">Konu</th>
                                <th scope=""col"">Ad Soyad</th>
                                <th scope=""col"">Eposta</th>
                                <th class=""text-center"" scope=""col"">İşlemler</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 34 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\Message\Trash.cshtml"
                             foreach (var message in Model.Messages)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr");
            BeginWriteAttribute("class", " class=\"", 1389, "\"", 1436, 1);
#nullable restore
#line 36 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\Message\Trash.cshtml"
WriteAttributeValue("", 1397, !message.IsRead?"table-secondary":"", 1397, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <td>");
#nullable restore
#line 37 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\Message\Trash.cshtml"
                                   Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 38 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\Message\Trash.cshtml"
                                   Write(message.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 39 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\Message\Trash.cshtml"
                                   Write(message.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 40 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\Message\Trash.cshtml"
                                   Write(message.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <ul class=\"d-flex justify-content-center\">\r\n                                            <li class=\"mr-3\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 1916, "\"", 1984, 4);
            WriteAttributeValue("", 1923, "/Admin/Message/Read/", 1923, 20, true);
#nullable restore
#line 44 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\Message\Trash.cshtml"
WriteAttributeValue("", 1943, message.Id, 1943, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1954, "/", 1954, 1, true);
#nullable restore
#line 44 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\Message\Trash.cshtml"
WriteAttributeValue("", 1955, Model.ReturnUrlMessageAction, 1955, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-success\" title=\"Oku\"><i class=\"ti-eye\"></i></a>\r\n                                            </li>\r\n                                            <li class=\"mr-3\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "054a7301e4d35c93f631b5d37f1f763ee330018b12748", async() => {
                WriteLiteral("\r\n                                                    <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 2374, "\"", 2393, 1);
#nullable restore
#line 48 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\Message\Trash.cshtml"
WriteAttributeValue("", 2382, message.Id, 2382, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                    <input type=""hidden"" name=""ReturnUrl"" value=""/Admin/Message/Trash"">
                                                    <button type=""submit"" class=""text-info"" style=""border: none; background-color: transparent;"" title=""Çöpten Çıkar""><i class=""ti-email""></i></button>
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </li>\r\n                                            <li class=\"mr-3\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "054a7301e4d35c93f631b5d37f1f763ee330018b15397", async() => {
                WriteLiteral("\r\n                                                    <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 3105, "\"", 3124, 1);
#nullable restore
#line 55 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\Message\Trash.cshtml"
WriteAttributeValue("", 3113, message.Id, 3113, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                    <input type=""hidden"" name=""ReturnUrl"" value=""/Admin/Message/Trash"">
                                                    <button type=""submit"" class=""text-info"" style=""border: none; background-color: transparent;"" title=""Arşivle""><i class=""ti-archive""></i></button>
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </li>\r\n");
            WriteLiteral("                                        </ul>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 69 "C:\xampp\htdocs\gitRepo\DayininCiftligiNetCore5\DayininCiftligiNetCore5\Areas\Admin\Views\Message\Trash.cshtml"
                                index = index + 1;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- sosyal medya end -->\r\n<!-- yeni sosyal medya hesabı ekleyin -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MessageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591