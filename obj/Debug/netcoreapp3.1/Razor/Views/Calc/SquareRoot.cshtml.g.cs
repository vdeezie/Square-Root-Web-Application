#pragma checksum "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\Calc\SquareRoot.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afa571fabba4a115fe4a479e624eaacc274234d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calc_SquareRoot), @"mvc.1.0.view", @"/Views/Calc/SquareRoot.cshtml")]
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
#line 1 "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\_ViewImports.cshtml"
using DeezieWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\_ViewImports.cshtml"
using DeezieWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afa571fabba4a115fe4a479e624eaacc274234d0", @"/Views/Calc/SquareRoot.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"556c11720224a1d36e9f092ec2a3020a8a390251", @"/Views/_ViewImports.cshtml")]
    public class Views_Calc_SquareRoot : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Calc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SquareRoot", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\Calc\SquareRoot.cshtml"
  
    ViewData["Title"] = "Square Root Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">The Square Root Calculator </h1>\r\n</div>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\Calc\SquareRoot.cshtml"
   
    try {
        if(ViewBag.Result1 > ViewBag.Result2){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n            <p> The number ");
#nullable restore
#line 13 "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\Calc\SquareRoot.cshtml"
                      Write(ViewBag.N1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with Square Root: ");
#nullable restore
#line 13 "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\Calc\SquareRoot.cshtml"
                                                    Write(ViewBag.Result1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has a higher Square Root than ");
#nullable restore
#line 13 "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\Calc\SquareRoot.cshtml"
                                                                                                   Write(ViewBag.N2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with Square Root: ");
#nullable restore
#line 13 "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\Calc\SquareRoot.cshtml"
                                                                                                                                 Write(ViewBag.Result2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 15 "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\Calc\SquareRoot.cshtml"

        }else if(ViewBag.Result2 > ViewBag.Result1){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <p> The number ");
#nullable restore
#line 18 "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\Calc\SquareRoot.cshtml"
                          Write(ViewBag.N2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with Square Root: ");
#nullable restore
#line 18 "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\Calc\SquareRoot.cshtml"
                                                        Write(ViewBag.Result2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has a higher Square Root than ");
#nullable restore
#line 18 "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\Calc\SquareRoot.cshtml"
                                                                                                       Write(ViewBag.N1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with Square Root: ");
#nullable restore
#line 18 "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\Calc\SquareRoot.cshtml"
                                                                                                                                     Write(ViewBag.Result1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 20 "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\Calc\SquareRoot.cshtml"

        }else if(ViewBag.Result1 == ViewBag.Result2){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <p> The number ");
#nullable restore
#line 23 "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\Calc\SquareRoot.cshtml"
                          Write(ViewBag.N1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has the same result with ");
#nullable restore
#line 23 "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\Calc\SquareRoot.cshtml"
                                                               Write(ViewBag.N2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" which is: ");
#nullable restore
#line 23 "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\Calc\SquareRoot.cshtml"
                                                                                     Write(ViewBag.Result2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" please enter another value! </p>\r\n            </div>\r\n");
#nullable restore
#line 25 "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\Calc\SquareRoot.cshtml"

        }else if (ViewBag.N1 && ViewBag.N2 > 0 ) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <p> Error! negative number </p>\r\n            </div>\r\n");
#nullable restore
#line 30 "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\Calc\SquareRoot.cshtml"

        }
    } 
    catch (FormatException) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <p> Wrong Input... PLEASE ENTER A NUMBER. </p>\r\n        </div>\r\n");
#nullable restore
#line 37 "C:\Users\EIC DAUPHINE E&R\C#\DeezieWeb\Views\Calc\SquareRoot.cshtml"
    }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afa571fabba4a115fe4a479e624eaacc274234d09573", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afa571fabba4a115fe4a479e624eaacc274234d09835", async() => {
                    WriteLiteral("\r\n\r\n        <input type=\"number\" placeholder=\"First Number\" name=\"firstNumber\"/>\r\n        <input type=\"number\" placeholder=\"Second Number\" name=\"secondNumber\"/>\r\n        <button type=\"submit\">Submit</button>\r\n\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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