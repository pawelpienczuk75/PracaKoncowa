#pragma checksum "C:\PracaKoncowa\RentRoom\RentRoom\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0737ddd6273d4cda634782c70365553b00ca745e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Default/Index.cshtml", typeof(AspNetCore.Views_Default_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0737ddd6273d4cda634782c70365553b00ca745e", @"/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "ViewTableOfWeek";

#line default
#line hidden
            BeginContext(53, 38, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pl-PL\">\r\n");
            EndContext();
            BeginContext(91, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "440be67cdee34278afd300b828c5dc0d", async() => {
                BeginContext(97, 58, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/css/StyleSheet.css\">\r\n");
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
            BeginContext(162, 793, true);
            WriteLiteral(@"


<p></p>
<h2 class=""display"" style=""width: 77%"">ViewTableOfWeek</h2>
<p></p>
<p></p>
<table id=""example"" class=""display"" clss=""tablespaces"" style=""width: 80%"">
    <thead class=""tableheadstyle"">
        <tr>
            <th>        </th>
            <th>Poniedziałek</th>
            <th>Wtorek</th>
            <th>Środa</th>
            <th>Czwartek</th>
            <th>Piątek</th>
            <th>Sobota</th>
            <th>Niedziela</th>
        </tr>
        <tr>
            <th>Godzina</th>
            <th>25.05.2018</th>
            <th>26.05.2018</th>
            <th>27.05.2018</th>
            <th>28.05.2018</th>
            <th>29.05.2018</th>
            <th>30.05.2018</th>
            <th>31.05.2018</th>
        </tr>
    </thead>
    <tr>
");
            EndContext();
#line 40 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Default\Index.cshtml"
             for (int j = 0; j < 24; j++)
            {

#line default
#line hidden
            BeginContext(1013, 22, true);
            WriteLiteral("                <tr>\r\n");
            EndContext();
#line 43 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Default\Index.cshtml"
                     for (int i = 0; i < 8; i++)
                    {
                        if (i == 0)
                        {

#line default
#line hidden
            BeginContext(1172, 64, true);
            WriteLiteral("                            <td id =\"14\" class=\"tablebodystyle\">");
            EndContext();
            BeginContext(1237, 1, false);
#line 47 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Default\Index.cshtml"
                                                           Write(j);

#line default
#line hidden
            EndContext();
            BeginContext(1238, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 48 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Default\Index.cshtml"
                        }
                        else

                        {

#line default
#line hidden
            BeginContext(1331, 64, true);
            WriteLiteral("                            <td id =\"12\" class=\"tablebodystyle\">");
            EndContext();
            BeginContext(1396, 1, false);
#line 52 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Default\Index.cshtml"
                                                           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1397, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 53 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Default\Index.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(1454, 45, true);
            WriteLiteral("                    \r\n                </tr>\r\n");
            EndContext();
#line 57 "C:\PracaKoncowa\RentRoom\RentRoom\Views\Default\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1514, 212, true);
            WriteLiteral("        </tr>\r\n\r\n     \r\n</table>\r\n\r\n    <!-- jQuery -->\r\n    <script src=\"/js/jquery-3.2.1.min.js\" type=\"text/javascript\"></script>\r\n    <script src=\"/js/VievTableOfWeek.js\" type=\"text/javascript\"></script>\r\n\r\n\r\n");
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
