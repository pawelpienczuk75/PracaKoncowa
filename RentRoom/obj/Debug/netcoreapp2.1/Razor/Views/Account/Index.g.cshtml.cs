#pragma checksum "C:\PracaKoncowa\RentRoom\RentRoom\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9670f78b1e793ac2417fd079ef81bd56b2cddf86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Index.cshtml", typeof(AspNetCore.Views_Account_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9670f78b1e793ac2417fd079ef81bd56b2cddf86", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("magin-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 94, true);
            WriteLiteral("\r\n\r\n<nav class=\"navbar navbar-expand-sm navbar-light\" style=\"background-color: #e3f2fd\">\r\n    ");
            EndContext();
            BeginContext(138, 43, false);
#line 8 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Account\Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(181, 179, true);
            WriteLiteral("\r\n    \r\n    <div class=\"collapse navbar-collapse\" id=\"navbarSupportedContent\">\r\n        <ul class=\"navbar-nav mr-auto\">\r\n            <li class=\"nav-item active\">\r\n                ");
            EndContext();
            BeginContext(360, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a50bc5b57ab463895893c9566c5f191", async() => {
                BeginContext(402, 11, true);
                WriteLiteral("Rejestracja");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(417, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(519, 71, true);
            WriteLiteral("            </li>          \r\n            <li class=\"nav-item active\">\r\n");
            EndContext();
#line 17 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Account\Index.cshtml"
             if (!User.Identity.IsAuthenticated)
            {

#line default
#line hidden
            BeginContext(655, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(671, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1590a477fa0240f8a360ecb0acdae966", async() => {
                BeginContext(710, 5, true);
                WriteLiteral("Login");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(719, 17, true);
            WriteLiteral("               \r\n");
            EndContext();
#line 20 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Account\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(751, 61, true);
            WriteLiteral("            </li>\r\n            <li class=\"nav-link active\">\r\n");
            EndContext();
#line 23 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Account\Index.cshtml"
                 if (User.Identity.IsAuthenticated)
                {
                    

#line default
#line hidden
            BeginContext(905, 55, false);
#line 25 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Account\Index.cshtml"
               Write(Html.ActionLink("Moje Dane", "CustomerDane", "Account"));

#line default
#line hidden
            EndContext();
#line 25 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Account\Index.cshtml"
                                                                            
                }

#line default
#line hidden
            BeginContext(981, 75, true);
            WriteLiteral("            </li>\r\n            \r\n            <li class=\"nav-link active\">\r\n");
            EndContext();
#line 30 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Account\Index.cshtml"
                 if (User.Identity.IsAuthenticated)
                {
                    

#line default
#line hidden
            BeginContext(1149, 51, false);
#line 32 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Account\Index.cshtml"
               Write(Html.ActionLink("Rezerwacja Sali", "Index", "Rent"));

#line default
#line hidden
            EndContext();
#line 32 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Account\Index.cshtml"
                                                                        

                }

#line default
#line hidden
            BeginContext(1223, 35, true);
            WriteLiteral("            </li>\r\n            \r\n\r\n");
            EndContext();
            BeginContext(1490, 27, true);
            WriteLiteral("\r\n        </ul>\r\n        \r\n");
            EndContext();
#line 48 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Account\Index.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
            BeginContext(1573, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1585, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "065720d450c040cbb9baa01654ce52e6", async() => {
                BeginContext(1628, 6, true);
                WriteLiteral("Logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1638, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 51 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Account\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1651, 9, true);
            WriteLiteral("       \r\n");
            EndContext();
#line 53 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Account\Index.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
            BeginContext(1716, 67, true);
            WriteLiteral("            <div class=\"magin-right\">Użytkownik Zalogowany.</div>\r\n");
            EndContext();
#line 56 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Account\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1819, 70, true);
            WriteLiteral("            <div class=\"magin-right\">Użytkownik Niezalogowany.</div>\r\n");
            EndContext();
#line 60 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Account\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1900, 36, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
