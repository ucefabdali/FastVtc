#pragma checksum "D:\WorkSpace\Projects\FastVtc\Views\Shared\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a675fc02ebc113a4df63765008e672d366de35e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Header), @"mvc.1.0.view", @"/Views/Shared/_Header.cshtml")]
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
#line 1 "D:\WorkSpace\Projects\FastVtc\Views\_ViewImports.cshtml"
using FastVtc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a675fc02ebc113a4df63765008e672d366de35e6", @"/Views/Shared/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92dab776ae30782efa0c9392776af497b00745ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<header class=\"cp_header\">\n    <div id=\"cp-slide-menu\" class=\"cp_side-navigation\">\n        <ul class=\"navbar-nav\">\n            <li id=\"close\"><a href=\"#\"><i class=\"fa fa-close\"></i></a></li>\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 209, "\"", 249, 1);
#nullable restore
#line 5 "D:\WorkSpace\Projects\FastVtc\Views\Shared\_Header.cshtml"
WriteAttributeValue("", 216, Url.Action("GetHomePage","Main"), 216, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Accueil</a></li>\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 286, "\"", 329, 1);
#nullable restore
#line 6 "D:\WorkSpace\Projects\FastVtc\Views\Shared\_Header.cshtml"
WriteAttributeValue("", 293, Url.Action("GetAboutUsPage","Main"), 293, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">À Propos</a></li>\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 367, "\"", 410, 1);
#nullable restore
#line 7 "D:\WorkSpace\Projects\FastVtc\Views\Shared\_Header.cshtml"
WriteAttributeValue("", 374, Url.Action("GetBookingPage","Main"), 374, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Prix et Réservation</a></li>\n        </ul>\n    </div>\n    <div id=\"cp-slide-search\" class=\"cp_side-search\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a675fc02ebc113a4df63765008e672d366de35e65639", async() => {
                WriteLiteral("\n            <input type=\"text\" placeholder=\"Enter Your Name...\" required>\n            <button type=\"submit\"><i class=\"fa fa-search\"></i></button>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <!--Navigation Start-->
    <div class=""cp-navigation-row"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <!--Top Bar Start-->
                    <div class=""cp-topbar"">
                        <span class=""tp-num"">Contactez-nous. +33 ‭6 59 36 23 90 / + 33 7 77 36 89 75</span>
                    </div><!--Top Bar Start-->
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-3 col-sm-12 col-xs-6"">
                    <!--Logo Start-->
                    <strong class=""cp-logo"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 1366, "\"", 1407, 1);
#nullable restore
#line 31 "D:\WorkSpace\Projects\FastVtc\Views\Shared\_Header.cshtml"
WriteAttributeValue("", 1373, Url.Action("GetHomePage", "Main"), 1373, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a675fc02ebc113a4df63765008e672d366de35e68268", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                    </strong><!--Logo End-->
                </div>
                <div class=""col-md-9 col-sm-12 col-xs-6"">
                    <!--Nav Holder Start-->
                    <div class=""cp-nav-holder"">
                        <ul class=""navbar-nav"">
                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1750, "\"", 1790, 1);
#nullable restore
#line 38 "D:\WorkSpace\Projects\FastVtc\Views\Shared\_Header.cshtml"
WriteAttributeValue("", 1757, Url.Action("GetHomePage","Main"), 1757, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Accueil</a></li>\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1843, "\"", 1886, 1);
#nullable restore
#line 39 "D:\WorkSpace\Projects\FastVtc\Views\Shared\_Header.cshtml"
WriteAttributeValue("", 1850, Url.Action("GetAboutUsPage","Main"), 1850, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">À Propos</a></li>\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1940, "\"", 1983, 1);
#nullable restore
#line 40 "D:\WorkSpace\Projects\FastVtc\Views\Shared\_Header.cshtml"
WriteAttributeValue("", 1947, Url.Action("GetBookingPage","Main"), 1947, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Prix et Réservation</a></li>
                        </ul>
                        <ul class=""nav-right-listed"">
                            <li id=""push"" class=""cp-sidemenu""><a href=""#""><i class=""fa fa-align-justify""></i></a></li>
                        </ul>
                    </div>
                    <!--Nav Holder End-->
                </div>
            </div>
        </div>
    </div>
    <!--Navigation End-->
</header>");
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
