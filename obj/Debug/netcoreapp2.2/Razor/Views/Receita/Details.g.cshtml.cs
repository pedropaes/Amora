#pragma checksum "C:\Users\Pedro\source\repos\Eloise\Views\Receita\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45c8b13c280bbcaad2127da317f5c8522d5a0b12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receita_Details), @"mvc.1.0.view", @"/Views/Receita/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Receita/Details.cshtml", typeof(AspNetCore.Views_Receita_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45c8b13c280bbcaad2127da317f5c8522d5a0b12", @"/Views/Receita/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2b1ceadc538df1f5ab041de02d3d2dd336819e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Receita_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Eloise.Models.Receita>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Pedro\source\repos\Eloise\Views\Receita\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(75, 130, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Receita</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(206, 45, false);
#line 14 "C:\Users\Pedro\source\repos\Eloise\Views\Receita\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(251, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(315, 41, false);
#line 17 "C:\Users\Pedro\source\repos\Eloise\Views\Receita\Details.cshtml"
       Write(Html.DisplayFor(model => model.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(356, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(419, 42, false);
#line 20 "C:\Users\Pedro\source\repos\Eloise\Views\Receita\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.regime));

#line default
#line hidden
            EndContext();
            BeginContext(461, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(525, 38, false);
#line 23 "C:\Users\Pedro\source\repos\Eloise\Views\Receita\Details.cshtml"
       Write(Html.DisplayFor(model => model.regime));

#line default
#line hidden
            EndContext();
            BeginContext(563, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(626, 40, false);
#line 26 "C:\Users\Pedro\source\repos\Eloise\Views\Receita\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.tipo));

#line default
#line hidden
            EndContext();
            BeginContext(666, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(730, 36, false);
#line 29 "C:\Users\Pedro\source\repos\Eloise\Views\Receita\Details.cshtml"
       Write(Html.DisplayFor(model => model.tipo));

#line default
#line hidden
            EndContext();
            BeginContext(766, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(829, 47, false);
#line 32 "C:\Users\Pedro\source\repos\Eloise\Views\Receita\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(876, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(940, 43, false);
#line 35 "C:\Users\Pedro\source\repos\Eloise\Views\Receita\Details.cshtml"
       Write(Html.DisplayFor(model => model.dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(983, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1046, 41, false);
#line 38 "C:\Users\Pedro\source\repos\Eloise\Views\Receita\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.tempo));

#line default
#line hidden
            EndContext();
            BeginContext(1087, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1151, 37, false);
#line 41 "C:\Users\Pedro\source\repos\Eloise\Views\Receita\Details.cshtml"
       Write(Html.DisplayFor(model => model.tempo));

#line default
#line hidden
            EndContext();
            BeginContext(1188, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1251, 41, false);
#line 44 "C:\Users\Pedro\source\repos\Eloise\Views\Receita\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.valor));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1356, 37, false);
#line 47 "C:\Users\Pedro\source\repos\Eloise\Views\Receita\Details.cshtml"
       Write(Html.DisplayFor(model => model.valor));

#line default
#line hidden
            EndContext();
            BeginContext(1393, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1456, 40, false);
#line 50 "C:\Users\Pedro\source\repos\Eloise\Views\Receita\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.dose));

#line default
#line hidden
            EndContext();
            BeginContext(1496, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1560, 36, false);
#line 53 "C:\Users\Pedro\source\repos\Eloise\Views\Receita\Details.cshtml"
       Write(Html.DisplayFor(model => model.dose));

#line default
#line hidden
            EndContext();
            BeginContext(1596, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1643, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c8b13c280bbcaad2127da317f5c8522d5a0b129813", async() => {
                BeginContext(1689, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\Pedro\source\repos\Eloise\Views\Receita\Details.cshtml"
                           WriteLiteral(Model.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1697, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1705, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c8b13c280bbcaad2127da317f5c8522d5a0b1212118", async() => {
                BeginContext(1727, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1743, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Eloise.Models.Receita> Html { get; private set; }
    }
}
#pragma warning restore 1591
