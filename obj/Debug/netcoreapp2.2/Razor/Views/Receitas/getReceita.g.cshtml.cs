#pragma checksum "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6131deb466018fda930aed0db3291e6f5a7409a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receitas_getReceita), @"mvc.1.0.view", @"/Views/Receitas/getReceita.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Receitas/getReceita.cshtml", typeof(AspNetCore.Views_Receitas_getReceita))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6131deb466018fda930aed0db3291e6f5a7409a", @"/Views/Receitas/getReceita.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2b1ceadc538df1f5ab041de02d3d2dd336819e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Receitas_getReceita : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReceitaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Share on Facebook"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/social_flat_rounded_rects_svg/Facebook.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Tweet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/social_flat_rounded_rects_svg/Twitter.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Post to Tumblr"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/social_flat_rounded_rects_svg/Tumblr.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Pin it"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/social_flat_rounded_rects_svg/Pinterest.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Submit to Reddit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/social_flat_rounded_rects_svg/Reddit.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Send email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/social_flat_rounded_rects_svg/Email.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(25, 217, true);
            WriteLiteral("\r\n<link href=\"Bootstrap/css/star-rating.css\" rel=\"stylesheet\" />\r\n<div class=\"container\" style=\"background-color:#E3F2FD\">\r\n\r\n    <div class=\"row px-2\">\r\n        <div class=\"col-sm\">\r\n            <p></p>\r\n            ");
            EndContext();
            BeginContext(242, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c6131deb466018fda930aed0db3291e6f5a7409a8556", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 252, "~/images/", 252, 9, true);
#line 9 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
AddHtmlAttributeValue("", 261, Html.DisplayFor(modelItem => Model.imagem), 261, 43, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 9 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
AddHtmlAttributeValue("", 311, Html.DisplayFor(modelItem => Model.descricao), 311, 46, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(384, 117, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-sm px-2\">\r\n            <p></p>\r\n            <p align=\"left\"><b>Regime:</b> ");
            EndContext();
            BeginContext(502, 42, false);
#line 13 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
                                      Write(Html.DisplayFor(modelItem => Model.regime));

#line default
#line hidden
            EndContext();
            BeginContext(544, 47, true);
            WriteLiteral("</p>\r\n            <p align=\"left\"><b>Tipo:</b> ");
            EndContext();
            BeginContext(592, 40, false);
#line 14 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
                                    Write(Html.DisplayFor(modelItem => Model.tipo));

#line default
#line hidden
            EndContext();
            BeginContext(632, 60, true);
            WriteLiteral("</p>\r\n            <p align=\"left\"><b>Tempo de confeção:</b> ");
            EndContext();
            BeginContext(693, 54, false);
#line 15 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
                                                 Write(Html.DisplayFor(modelItem => Model.tempo.TotalMinutes));

#line default
#line hidden
            EndContext();
            BeginContext(747, 77, true);
            WriteLiteral(" min. <i class=\"fas fa-clock\"></i>\r\n            <p align=\"left\"><b>Dose:</b> ");
            EndContext();
            BeginContext(825, 40, false);
#line 16 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
                                    Write(Html.DisplayFor(modelItem => Model.dose));

#line default
#line hidden
            EndContext();
            BeginContext(865, 82, true);
            WriteLiteral(" <i class=\"fas fa-male\"></i></p>\r\n            <p align=\"left\"><b>Dificuldade:</b> ");
            EndContext();
            BeginContext(948, 47, false);
#line 17 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
                                           Write(Html.DisplayFor(modelItem => Model.dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(995, 49, true);
            WriteLiteral("</p>\r\n            <p align=\"left\"><b>Passos:</b> ");
            EndContext();
            BeginContext(1045, 48, false);
#line 18 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
                                      Write(Html.DisplayFor(modelItem => Model.Passos.Count));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 19 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
              
                var result = (Model.classificacao / 5) * 100;

            

#line default
#line hidden
            BeginContext(1195, 80, true);
            WriteLiteral("\r\n            <b>Classificação:</b> <div class=\"media star-ratings-sprite\"><span");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1275, "\"", 1297, 3);
            WriteAttributeValue("", 1283, "width:", 1283, 6, true);
#line 24 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
WriteAttributeValue("", 1289, result, 1289, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 1296, "%", 1296, 1, true);
            EndWriteAttribute();
            BeginContext(1298, 51, true);
            WriteLiteral(" class=\"star-ratings-sprite-rating\"></span></div>\r\n");
            EndContext();
#line 25 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
             if (Model.Alergenios.Count != 0)
            {

#line default
#line hidden
            BeginContext(1411, 227, true);
            WriteLiteral("                <div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n                    <i class=\"fas fa-exclamation-triangle\"></i><strong>Atenção!</strong> Esta receita contém os seguintes alergénios:\r\n");
            EndContext();
#line 29 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
                     foreach (var a in Model.Alergenios)
                    {
                        

#line default
#line hidden
            BeginContext(1744, 36, false);
#line 31 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
                   Write(Html.DisplayFor(modelItem => a.nome));

#line default
#line hidden
            EndContext();
            BeginContext(1780, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1783, 8, true);
            WriteLiteral("&nbsp;\r\n");
            EndContext();
#line 32 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
                    }

#line default
#line hidden
            BeginContext(1814, 218, true);
            WriteLiteral("                    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                </div>\r\n");
            EndContext();
#line 37 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
            }

#line default
#line hidden
            BeginContext(2047, 104, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-sm\">\r\n            <p align=\"center\"><b>Ingredientes:</b></p>\r\n");
            EndContext();
#line 42 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
             foreach (var ing in Model.Ingredientes)
            {

#line default
#line hidden
            BeginContext(2220, 34, true);
            WriteLiteral("                <p align=\"center\">");
            EndContext();
            BeginContext(2255, 43, false);
#line 44 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
                             Write(Html.DisplayFor(modelItem => ing.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(2298, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 45 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
            }

#line default
#line hidden
            BeginContext(2319, 485, true);
            WriteLiteral(@"
        </div>


    </div>
</div>
<div class=""container"" style=""background-color:#E3F2FD"">
    <div class=""row"">
        <div class=""col-6"">
            <ul class=""share-buttons"">
                <li><a href=""https://www.facebook.com/sharer/sharer.php?u=&quote="" title=""Share on Facebook"" target=""_blank"" onclick=""window.open('https://www.facebook.com/sharer/sharer.php?u=' + encodeURIComponent(document.URL) + '&quote=' + encodeURIComponent(document.URL)); return false;"">");
            EndContext();
            BeginContext(2804, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c6131deb466018fda930aed0db3291e6f5a7409a17873", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2893, 283, true);
            WriteLiteral(@"</a></li>
                <li><a href=""https://twitter.com/intent/tweet?source=&text=:%20"" target=""_blank"" title=""Tweet"" onclick=""window.open('https://twitter.com/intent/tweet?text=' + encodeURIComponent(document.title) + ':%20'  + encodeURIComponent(document.URL)); return false;"">");
            EndContext();
            BeginContext(3176, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c6131deb466018fda930aed0db3291e6f5a7409a19417", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3252, 285, true);
            WriteLiteral(@"</a></li>
                <li><a href=""http://www.tumblr.com/share?v=3&u=&quote=&s="" target=""_blank"" title=""Post to Tumblr"" onclick=""window.open('http://www.tumblr.com/share?v=3&u=' + encodeURIComponent(document.URL) + '&quote=' +  encodeURIComponent(document.title)); return false;"">");
            EndContext();
            BeginContext(3537, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c6131deb466018fda930aed0db3291e6f5a7409a20963", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3621, 306, true);
            WriteLiteral(@"</a></li>
                <li><a href=""http://pinterest.com/pin/create/button/?url=&description="" target=""_blank"" title=""Pin it"" onclick=""window.open('http://pinterest.com/pin/create/button/?url=' + encodeURIComponent(document.URL) + '&description=' +  encodeURIComponent(document.title)); return false;"">");
            EndContext();
            BeginContext(3927, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c6131deb466018fda930aed0db3291e6f5a7409a22530", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4006, 282, true);
            WriteLiteral(@"</a></li>
                <li><a href=""http://www.reddit.com/submit?url=&title="" target=""_blank"" title=""Submit to Reddit"" onclick=""window.open('http://www.reddit.com/submit?url=' + encodeURIComponent(document.URL) + '&title=' +  encodeURIComponent(document.title)); return false;"">");
            EndContext();
            BeginContext(4288, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c6131deb466018fda930aed0db3291e6f5a7409a24073", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4374, 244, true);
            WriteLiteral("</a></li>\r\n                <li><a href=\"mailto:?subject=&body=:%20\" target=\"_blank\" title=\"Send email\" onclick=\"window.open(\'mailto:?subject=\' + encodeURIComponent(document.title) + \'&body=\' +  encodeURIComponent(document.URL)); return false;\">");
            EndContext();
            BeginContext(4618, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c6131deb466018fda930aed0db3291e6f5a7409a25585", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4697, 271, true);
            WriteLiteral(@"</a></li>
            </ul>
        </div>
        <div class=""col"">
            
        </div>
        <div class=""col"">
            <button type=""button"" class=""btn btn-danger"" />
            <input type=""button"" value=""Preparar Receita"" class=""btn btn-danger""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4968, "\"", 5057, 3);
            WriteAttributeValue("", 4978, "location.href=\'", 4978, 15, true);
#line 69 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
WriteAttributeValue("", 4993, Url.Action("PrepararReceita", "Receitas",new { id = Model.id}), 4993, 63, false);

#line default
#line hidden
            WriteAttributeValue("", 5056, "\'", 5056, 1, true);
            EndWriteAttribute();
            BeginContext(5058, 68, true);
            WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"container\">\r\n");
            EndContext();
#line 75 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
     foreach (var item in Model.Passos.Values)
    {

#line default
#line hidden
            BeginContext(5181, 89, true);
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col\">              <p align=\"left\"><b>");
            EndContext();
            BeginContext(5271, 40, false);
#line 78 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.passo));

#line default
#line hidden
            EndContext();
            BeginContext(5311, 6, true);
            WriteLiteral(". </b>");
            EndContext();
            BeginContext(5318, 42, false);
#line 78 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"
                                                                                                        Write(Html.DisplayFor(modelItem => item.tecnica));

#line default
#line hidden
            EndContext();
            BeginContext(5360, 33, true);
            WriteLiteral("</p> </div>\r\n\r\n\r\n        </div>\r\n");
            EndContext();
#line 82 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\getReceita.cshtml"

    }

#line default
#line hidden
            BeginContext(5402, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReceitaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
