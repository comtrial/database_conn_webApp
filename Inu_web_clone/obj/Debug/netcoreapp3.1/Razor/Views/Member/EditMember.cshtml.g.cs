#pragma checksum "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/EditMember.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e74e15b78cc145c478ca9826a9165ec33160fef4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_EditMember), @"mvc.1.0.view", @"/Views/Member/EditMember.cshtml")]
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
#line 1 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/_ViewImports.cshtml"
using Inu_web_clone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/_ViewImports.cshtml"
using Inu_web_clone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e74e15b78cc145c478ca9826a9165ec33160fef4", @"/Views/Member/EditMember.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d3e48c21ef3d23a008ee365fec8b5c11df5a827", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_EditMember : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Inu_web_clone.Models.DTO.DtoMember>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Member", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateMember", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteMember", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <!--모델 단의 Dto 데이터 객체를 가져오기 위해서-->\r\n");
#nullable restore
#line 6 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/EditMember.cshtml"
  
    ViewData["Title"] = "Edit Member";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e74e15b78cc145c478ca9826a9165ec33160fef45216", async() => {
                WriteLiteral(@"
        <!---method: GET 방식의 경우 전송하는 url에 입력한 정보가 담기고,
            별로 바람직한 방식은 아니기에 url에는 정보가 담기지 않는
            POST의 방식을 사용하는 것이 권장 된다.

            이를 통해 form안의 데이터가 각 함수로 전달이 된다.-->
        <table class=""table"">
            <tr>
                <td>ID</td>
                <td><input type=""text"" name=""id"" readonly");
                BeginWriteAttribute("value", " value=\"", 608, "\"", 625, 1);
#nullable restore
#line 20 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/EditMember.cshtml"
WriteAttributeValue("", 616, Model.id, 616, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td>Title</td>\r\n                <td><input type=\"text\" name=\"title\"");
                BeginWriteAttribute("value", " value=\"", 756, "\"", 776, 1);
#nullable restore
#line 24 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/EditMember.cshtml"
WriteAttributeValue("", 764, Model.title, 764, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td>Author</td>\r\n                <td><input type=\"text\" name=\"author\"");
                BeginWriteAttribute("value", " value=\"", 909, "\"", 930, 1);
#nullable restore
#line 28 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/EditMember.cshtml"
WriteAttributeValue("", 917, Model.author, 917, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td>E-Mail</td>\r\n                <td><input type=\"text\" name=\"e_mail\"");
                BeginWriteAttribute("value", " value=\"", 1063, "\"", 1084, 1);
#nullable restore
#line 32 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/EditMember.cshtml"
WriteAttributeValue("", 1071, Model.e_mail, 1071, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td>Count</td>\r\n                <td><input type=\"text\" readonly name=\"cnt\"");
                BeginWriteAttribute("value", " value=\"", 1222, "\"", 1240, 1);
#nullable restore
#line 36 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/EditMember.cshtml"
WriteAttributeValue("", 1230, Model.cnt, 1230, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n            </tr>\r\n            <tr style=\"display:none;\">\r\n                <td>Date</td>\r\n                <td><input type=\"text\" name=\"date\"");
                BeginWriteAttribute("value", " value=\"", 1391, "\"", 1410, 1);
#nullable restore
#line 40 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/EditMember.cshtml"
WriteAttributeValue("", 1399, Model.date, 1399, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td>Password</td>\r\n                <td><input type=\"text\" name=\"password\"");
                BeginWriteAttribute("value", " value=\"", 1547, "\"", 1570, 1);
#nullable restore
#line 44 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/EditMember.cshtml"
WriteAttributeValue("", 1555, Model.password, 1555, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td>Content</td>\r\n                <td><input type=\"text\" name=\"content\"");
                BeginWriteAttribute("value", " value=\"", 1705, "\"", 1727, 1);
#nullable restore
#line 48 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/EditMember.cshtml"
WriteAttributeValue("", 1713, Model.content, 1713, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n            </tr>\r\n            <!--nochool 값을 굳이 표현하지 않아도 될 것 같다.-->\r\n            <tr>\r\n                <td>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e74e15b78cc145c478ca9826a9165ec33160fef49986", async() => {
                    WriteLiteral("\r\n                        Update\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e74e15b78cc145c478ca9826a9165ec33160fef411584", async() => {
                    WriteLiteral("\r\n                        Delete\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n\r\n        </table>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inu_web_clone.Models.DTO.DtoMember> Html { get; private set; }
    }
}
#pragma warning restore 1591
