#pragma checksum "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2503a96ea595114f1efa9d62eb6f0150a441f156"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receitas_Lista), @"mvc.1.0.view", @"/Views/Receitas/Lista.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Receitas/Lista.cshtml", typeof(AspNetCore.Views_Receitas_Lista))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2503a96ea595114f1efa9d62eb6f0150a441f156", @"/Views/Receitas/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2b1ceadc538df1f5ab041de02d3d2dd336819e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Receitas_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Eloise.Models.ReceitaViewModel>>
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
            BeginContext(45, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
            BeginContext(84, 10, true);
            WriteLiteral("    <p><b>");
            EndContext();
            BeginContext(95, 44, false);
#line 7 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
     Write(Html.DisplayFor(modelItem => item.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(139, 156, true);
            WriteLiteral("</b></p>\r\n    <div class=\"container\" style=\"background-color:#E3F2FD\">\r\n\r\n        <div class=\"row px-2\">\r\n            <div class=\"col-sm\">\r\n                ");
            EndContext();
            BeginContext(295, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2503a96ea595114f1efa9d62eb6f0150a441f1569061", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 305, "~/images/", 305, 9, true);
#line 12 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
AddHtmlAttributeValue("", 314, Html.DisplayFor(modelItem => item.imagem), 314, 42, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
AddHtmlAttributeValue("", 363, Html.DisplayFor(modelItem => item.descricao), 363, 45, false);

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
            BeginContext(435, 108, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-sm px-2\">\r\n                <p align=\"left\"><b>Regime:</b> ");
            EndContext();
            BeginContext(544, 41, false);
#line 15 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.regime));

#line default
#line hidden
            EndContext();
            BeginContext(585, 51, true);
            WriteLiteral("</p>\r\n                <p align=\"left\"><b>Tipo:</b> ");
            EndContext();
            BeginContext(637, 39, false);
#line 16 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.tipo));

#line default
#line hidden
            EndContext();
            BeginContext(676, 64, true);
            WriteLiteral("</p>\r\n                <p align=\"left\"><b>Tempo de confeção:</b> ");
            EndContext();
            BeginContext(741, 53, false);
#line 17 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.tempo.TotalMinutes));

#line default
#line hidden
            EndContext();
            BeginContext(794, 81, true);
            WriteLiteral(" min. <i class=\"fas fa-clock\"></i>\r\n                <p align=\"left\"><b>Dose:</b> ");
            EndContext();
            BeginContext(876, 39, false);
#line 18 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.dose));

#line default
#line hidden
            EndContext();
            BeginContext(915, 86, true);
            WriteLiteral(" <i class=\"fas fa-male\"></i></p>\r\n                <p align=\"left\"><b>Dificuldade:</b> ");
            EndContext();
            BeginContext(1002, 46, false);
#line 19 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 53, true);
            WriteLiteral("</p>\r\n                <p align=\"left\"><b>Passos:</b> ");
            EndContext();
            BeginContext(1102, 47, false);
#line 20 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.Passos.Count));

#line default
#line hidden
            EndContext();
            BeginContext(1149, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 21 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                  
                    var result = (item.classificacao / 5) * 100;

                

#line default
#line hidden
            BeginContext(1262, 84, true);
            WriteLiteral("\r\n                <b>Classificação:</b> <div class=\"media star-ratings-sprite\"><span");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1346, "\"", 1368, 3);
            WriteAttributeValue("", 1354, "width:", 1354, 6, true);
#line 26 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
WriteAttributeValue("", 1360, result, 1360, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 1367, "%", 1367, 1, true);
            EndWriteAttribute();
            BeginContext(1369, 167, true);
            WriteLiteral(" class=\"star-ratings-sprite-rating\"></span></div>\r\n\r\n            </div>\r\n            <div class=\"col-sm\">\r\n                <p align=\"center\"><b>Ingredientes:</b></p>\r\n");
            EndContext();
#line 31 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                 foreach (var ing in item.Ingredientes)
                {

#line default
#line hidden
            BeginContext(1612, 38, true);
            WriteLiteral("                    <p align=\"center\">");
            EndContext();
            BeginContext(1651, 43, false);
#line 33 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                                 Write(Html.DisplayFor(modelItem => ing.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1694, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 34 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                }

#line default
#line hidden
            BeginContext(1719, 54, true);
            WriteLiteral("\r\n            </div>\r\n\r\n\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(1777, 464, true);
            WriteLiteral(@"    <div class=""container""  style=""background-color:#E3F2FD"">
        <div class=""row"">
            <div class=""col-6"">
                <ul class=""share-buttons"">
                    <li><a href=""https://www.facebook.com/sharer/sharer.php?u=&quote="" title=""Share on Facebook"" target=""_blank"" onclick=""window.open('https://www.facebook.com/sharer/sharer.php?u=' + encodeURIComponent(document.URL) + '&quote=' + encodeURIComponent(document.URL)); return false;"">");
            EndContext();
            BeginContext(2241, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2503a96ea595114f1efa9d62eb6f0150a441f15616647", async() => {
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
            BeginContext(2330, 287, true);
            WriteLiteral(@"</a></li>
                    <li><a href=""https://twitter.com/intent/tweet?source=&text=:%20"" target=""_blank"" title=""Tweet"" onclick=""window.open('https://twitter.com/intent/tweet?text=' + encodeURIComponent(document.title) + ':%20'  + encodeURIComponent(document.URL)); return false;"">");
            EndContext();
            BeginContext(2617, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2503a96ea595114f1efa9d62eb6f0150a441f15618195", async() => {
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
            BeginContext(2693, 289, true);
            WriteLiteral(@"</a></li>
                    <li><a href=""http://www.tumblr.com/share?v=3&u=&quote=&s="" target=""_blank"" title=""Post to Tumblr"" onclick=""window.open('http://www.tumblr.com/share?v=3&u=' + encodeURIComponent(document.URL) + '&quote=' +  encodeURIComponent(document.title)); return false;"">");
            EndContext();
            BeginContext(2982, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2503a96ea595114f1efa9d62eb6f0150a441f15619745", async() => {
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
            BeginContext(3066, 310, true);
            WriteLiteral(@"</a></li>
                    <li><a href=""http://pinterest.com/pin/create/button/?url=&description="" target=""_blank"" title=""Pin it"" onclick=""window.open('http://pinterest.com/pin/create/button/?url=' + encodeURIComponent(document.URL) + '&description=' +  encodeURIComponent(document.title)); return false;"">");
            EndContext();
            BeginContext(3376, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2503a96ea595114f1efa9d62eb6f0150a441f15621316", async() => {
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
            BeginContext(3455, 286, true);
            WriteLiteral(@"</a></li>
                    <li><a href=""http://www.reddit.com/submit?url=&title="" target=""_blank"" title=""Submit to Reddit"" onclick=""window.open('http://www.reddit.com/submit?url=' + encodeURIComponent(document.URL) + '&title=' +  encodeURIComponent(document.title)); return false;"">");
            EndContext();
            BeginContext(3741, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2503a96ea595114f1efa9d62eb6f0150a441f15622863", async() => {
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
            BeginContext(3827, 248, true);
            WriteLiteral("</a></li>\r\n                    <li><a href=\"mailto:?subject=&body=:%20\" target=\"_blank\" title=\"Send email\" onclick=\"window.open(\'mailto:?subject=\' + encodeURIComponent(document.title) + \'&body=\' +  encodeURIComponent(document.URL)); return false;\">");
            EndContext();
            BeginContext(4075, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2503a96ea595114f1efa9d62eb6f0150a441f15624379", async() => {
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
            BeginContext(4154, 234, true);
            WriteLiteral("</a></li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"col\">\r\n                <button type=\"button\" class=\"btn btn-danger\" />\r\n                <input type=\"button\" value=\"Preparar Receita\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4388, "\"", 4471, 3);
            WriteAttributeValue("", 4398, "location.href=\'", 4398, 15, true);
#line 56 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
WriteAttributeValue("", 4413, Url.Action("GetReceita", "Receitas",new { id = item.id}), 4413, 57, false);

#line default
#line hidden
            WriteAttributeValue("", 4470, "\'", 4470, 1, true);
            EndWriteAttribute();
            BeginContext(4472, 202, true);
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col\">\r\n                <button type=\"button\" class=\"btn btn-warning\" />\r\n                <input type=\"button\" value=\"Ver Receita\" class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4674, "\"", 4757, 3);
            WriteAttributeValue("", 4684, "location.href=\'", 4684, 15, true);
#line 60 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
WriteAttributeValue("", 4699, Url.Action("GetReceita", "Receitas",new { id = item.id}), 4699, 57, false);

#line default
#line hidden
            WriteAttributeValue("", 4756, "\'", 4756, 1, true);
            EndWriteAttribute();
            BeginContext(4758, 53, true);
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 64 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Eloise.Models.ReceitaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
