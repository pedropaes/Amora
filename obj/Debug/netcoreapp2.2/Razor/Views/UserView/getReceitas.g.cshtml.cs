#pragma checksum "C:\Users\Pedro\source\repos\Eloise\Views\UserView\getReceitas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "859abc118bd84a7d0ef0f914b8cc70c555e33541"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserView_getReceitas), @"mvc.1.0.view", @"/Views/UserView/getReceitas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserView/getReceitas.cshtml", typeof(AspNetCore.Views_UserView_getReceitas))]
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
#line 1 "C:\Users\Pedro\source\repos\Eloise\Views\_ViewImports.cshtml"
using Eloise;

#line default
#line hidden
#line 2 "C:\Users\Pedro\source\repos\Eloise\Views\_ViewImports.cshtml"
using Eloise.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"859abc118bd84a7d0ef0f914b8cc70c555e33541", @"/Views/UserView/getReceitas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2b1ceadc538df1f5ab041de02d3d2dd336819e5", @"/Views/_ViewImports.cshtml")]
    public class Views_UserView_getReceitas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Eloise.Models.Receita>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Pedro\source\repos\Eloise\Views\UserView\getReceitas.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(79, 101, true);
            WriteLiteral("<table class=\"table table-borderless\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(181, 45, false);
#line 9 "C:\Users\Pedro\source\repos\Eloise\Views\UserView\getReceitas.cshtml"
           Write(Html.DisplayNameFor(model => model.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(226, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(282, 48, false);
#line 12 "C:\Users\Pedro\source\repos\Eloise\Views\UserView\getReceitas.cshtml"
           Write(Html.DisplayNameFor(modelItem => item.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(330, 228, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n            </th>\r\n            <th>\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr >\r\n            <td class=\"table-info\">\r\n                ");
            EndContext();
            BeginContext(558, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "859abc118bd84a7d0ef0f914b8cc70c555e335414598", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 568, "~/images/", 568, 9, true);
#line 24 "C:\Users\Pedro\source\repos\Eloise\Views\UserView\getReceitas.cshtml"
AddHtmlAttributeValue("", 577, Html.DisplayFor(modelItem => item.imagem), 577, 42, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "C:\Users\Pedro\source\repos\Eloise\Views\UserView\getReceitas.cshtml"
AddHtmlAttributeValue("", 626, Html.DisplayFor(modelItem => item.descricao), 626, 45, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(673, 74, true);
            WriteLiteral("\r\n            </td>\r\n            <td class=\"table-info\">\r\n                ");
            EndContext();
            BeginContext(748, 41, false);
#line 27 "C:\Users\Pedro\source\repos\Eloise\Views\UserView\getReceitas.cshtml"
           Write(Html.DisplayFor(modelItem => item.regime));

#line default
#line hidden
            EndContext();
            BeginContext(789, 74, true);
            WriteLiteral("\r\n            </td>\r\n            <td class=\"table-info\">\r\n                ");
            EndContext();
            BeginContext(864, 39, false);
#line 30 "C:\Users\Pedro\source\repos\Eloise\Views\UserView\getReceitas.cshtml"
           Write(Html.DisplayFor(modelItem => item.tipo));

#line default
#line hidden
            EndContext();
            BeginContext(903, 74, true);
            WriteLiteral("\r\n            </td>\r\n            <td class=\"table-info\">\r\n                ");
            EndContext();
            BeginContext(978, 40, false);
#line 33 "C:\Users\Pedro\source\repos\Eloise\Views\UserView\getReceitas.cshtml"
           Write(Html.DisplayFor(modelItem => item.tempo));

#line default
#line hidden
            EndContext();
            BeginContext(1018, 64, true);
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n\r\n    </tbody>\r\n</table>\r\n");
            EndContext();
#line 40 "C:\Users\Pedro\source\repos\Eloise\Views\UserView\getReceitas.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Eloise.Models.Receita>> Html { get; private set; }
    }
}
#pragma warning restore 1591
