#pragma checksum "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/Member.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "246bde92fe2af5a08184f76df92e313be7f9e239"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_Member), @"mvc.1.0.view", @"/Views/Member/Member.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"246bde92fe2af5a08184f76df92e313be7f9e239", @"/Views/Member/Member.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d3e48c21ef3d23a008ee365fec8b5c11df5a827", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_Member : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Inu_web_clone.Models.DTO.DtoMember>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewMember", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("    <!--모델 단의 Dto list 데이터 객체를 가져오기 위해서-->\r\n");
#nullable restore
#line 6 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/Member.cshtml"
  
    ViewData["Title"] = "Membr Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Member</h1>\r\n\r\n\r\n        <p>\r\n            <button class=\"btn-light\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "246bde92fe2af5a08184f76df92e313be7f9e2393807", async() => {
                WriteLiteral("NewMember");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</button>
        </p>
        <!--새로운 데이터 형성 버튼-->

        <table class=""table"">
            <tr>
                <th>id</th>
                <th>title</th>
                <th>author</th>
                <th>e_mail</th>
                <th>cnt</th>
                <th>date</th>
                <th>password</th>
                <th>content</th>
                <!--th = 테이블의 제목들에 해당하는 태그-->
            </tr>

");
#nullable restore
#line 33 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/Member.cshtml"
             foreach (var member in Model)
                //cshtml안에서 함수를 사용하기 위한 문법
                //Model에 들어온 list들 중 member 빼오기 위한 코 
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <label>");
#nullable restore
#line 39 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/Member.cshtml"
                          Write(member.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </td>\r\n                    <td>\r\n                        <label>");
#nullable restore
#line 42 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/Member.cshtml"
                          Write(member.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </td>\r\n                    <td>\r\n                        <label>");
#nullable restore
#line 45 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/Member.cshtml"
                          Write(member.author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </td>\r\n                    <td>\r\n                        <label>");
#nullable restore
#line 48 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/Member.cshtml"
                          Write(member.e_mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </td>\r\n                    <td>\r\n                        <label>");
#nullable restore
#line 51 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/Member.cshtml"
                          Write(member.cnt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </td>\r\n                    <td>\r\n                        <label>");
#nullable restore
#line 54 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/Member.cshtml"
                          Write(member.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </td>\r\n                    <td>\r\n                        <label>");
#nullable restore
#line 57 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/Member.cshtml"
                          Write(member.password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </td>\r\n                    <td>\r\n                        <label>");
#nullable restore
#line 60 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/Member.cshtml"
                          Write(member.content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </td>\r\n                    <td>\r\n                        <button class=\"btn-light\" value=\"Edit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1996, "\"", 2085, 5);
            WriteAttributeValue("", 2006, "location.href", 2006, 13, true);
            WriteAttributeValue(" ", 2019, "=", 2020, 2, true);
            WriteAttributeValue(" ", 2021, "\'", 2022, 2, true);
#nullable restore
#line 63 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/Member.cshtml"
WriteAttributeValue("", 2023, Url.Action("EditMember", "Member", new { id = member.id }), 2023, 61, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2084, "\'", 2084, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                            Edit
                        </button>
                        <!--마우스 클릭시 Editmember로 보내주는 이벤트 함
                            , id 값의 전달-->
                    </td>
                    <!-- td = 테이블 열의 요소들에 해당하는 태그-->
                </tr>
");
#nullable restore
#line 71 "/Users/choeseung-won/Projects/Inu_web_clone/Inu_web_clone/Views/Member/Member.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Inu_web_clone.Models.DTO.DtoMember>> Html { get; private set; }
    }
}
#pragma warning restore 1591
