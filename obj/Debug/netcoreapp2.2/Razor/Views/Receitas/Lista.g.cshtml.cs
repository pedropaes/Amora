#pragma checksum "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b371095437801a44c7b302a9218043b23c61015c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b371095437801a44c7b302a9218043b23c61015c", @"/Views/Receitas/Lista.cshtml")]
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
            BeginContext(45, 590, true);
            WriteLiteral(@"<script src=""https://cdnjs.cloudflare.com/ajax/libs/annyang/2.6.0/annyang.min.js""></script>
<script type='text/javascript' src=""/js/eloise.js""></script>

<script src=""//code.responsivevoice.org/responsivevoice.js?key=3G053CLH""></script>

<script>
    function speak(input) {
        responsiveVoice.speak(input, ""Portuguese Female"");
    }

    function wait(ms) {
        var d = new Date();
        var d2 = null;
        do { d2 = new Date(); }
        while (d2 - d < ms);
    }

    function executeAsync(func) {
        setTimeout(func, 0);
    }


</script>

");
            EndContext();
#line 26 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(662, 139, true);
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        Não foram encontrados resultados <i class=\"fas fa-frown-open\"></i>\r\n    </div>\r\n");
            EndContext();
#line 31 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
}
else
{
    

#line default
#line hidden
#line 34 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
            BeginContext(856, 14, true);
            WriteLiteral("        <p><b>");
            EndContext();
            BeginContext(871, 44, false);
#line 37 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
         Write(Html.DisplayFor(modelItem => item.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(915, 201, true);
            WriteLiteral("</b></p>\r\n        <div class=\"container\" style=\"background-color:#E3F2FD\">\r\n\r\n            <div class=\"row px-2\">\r\n                <div class=\"col-sm\">\r\n                    <p></p>\r\n                    ");
            EndContext();
            BeginContext(1116, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b371095437801a44c7b302a9218043b23c61015c10231", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1126, "~/images/", 1126, 9, true);
#line 43 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
AddHtmlAttributeValue("", 1135, Html.DisplayFor(modelItem => item.imagem), 1135, 42, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 43 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
AddHtmlAttributeValue("", 1184, Html.DisplayFor(modelItem => item.descricao), 1184, 45, false);

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
            BeginContext(1256, 149, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm px-2\">\r\n                    <p></p>\r\n                    <p align=\"left\"><b>Regime:</b> ");
            EndContext();
            BeginContext(1406, 41, false);
#line 47 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.regime));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 55, true);
            WriteLiteral("</p>\r\n                    <p align=\"left\"><b>Tipo:</b> ");
            EndContext();
            BeginContext(1503, 39, false);
#line 48 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.tipo));

#line default
#line hidden
            EndContext();
            BeginContext(1542, 68, true);
            WriteLiteral("</p>\r\n                    <p align=\"left\"><b>Tempo de confeção:</b> ");
            EndContext();
            BeginContext(1611, 53, false);
#line 49 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.tempo.TotalMinutes));

#line default
#line hidden
            EndContext();
            BeginContext(1664, 85, true);
            WriteLiteral(" min. <i class=\"fas fa-clock\"></i>\r\n                    <p align=\"left\"><b>Dose:</b> ");
            EndContext();
            BeginContext(1750, 39, false);
#line 50 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.dose));

#line default
#line hidden
            EndContext();
            BeginContext(1789, 90, true);
            WriteLiteral(" <i class=\"fas fa-male\"></i></p>\r\n                    <p align=\"left\"><b>Dificuldade:</b> ");
            EndContext();
            BeginContext(1880, 46, false);
#line 51 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(1926, 57, true);
            WriteLiteral("</p>\r\n                    <p align=\"left\"><b>Passos:</b> ");
            EndContext();
            BeginContext(1984, 47, false);
#line 52 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.Passos.Count));

#line default
#line hidden
            EndContext();
            BeginContext(2031, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 53 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                      
                        var result = (item.classificacao / 5) * 100;

                    

#line default
#line hidden
            BeginContext(2156, 88, true);
            WriteLiteral("\r\n                    <b>Classificação:</b> <div class=\"media star-ratings-sprite\"><span");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2244, "\"", 2266, 3);
            WriteAttributeValue("", 2252, "width:", 2252, 6, true);
#line 58 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
WriteAttributeValue("", 2258, result, 2258, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 2265, "%", 2265, 1, true);
            EndWriteAttribute();
            BeginContext(2267, 179, true);
            WriteLiteral(" class=\"star-ratings-sprite-rating\"></span></div>\r\n\r\n                </div>\r\n                <div class=\"col-sm\">\r\n                    <p align=\"center\"><b>Ingredientes:</b></p>\r\n");
            EndContext();
#line 63 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                     foreach (var ing in item.Ingredientes)
                    {

#line default
#line hidden
            BeginContext(2530, 42, true);
            WriteLiteral("                        <p align=\"center\">");
            EndContext();
            BeginContext(2573, 47, false);
#line 65 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                                     Write(Html.DisplayFor(modelItem => ing.Key.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(2620, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 66 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                    }

#line default
#line hidden
            BeginContext(2649, 66, true);
            WriteLiteral("\r\n                </div>\r\n\r\n\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(2717, 481, true);
            WriteLiteral(@"        <div class=""container"" style=""background-color:#E3F2FD"">
            <div class=""row"">
                <div class=""col"">
                    <ul class=""share-buttons"">
                        <li><a href=""https://www.facebook.com/sharer/sharer.php?u=&quote="" title=""Share on Facebook"" target=""_blank"" onclick=""window.open('https://www.facebook.com/sharer/sharer.php?u=' + encodeURIComponent(document.URL) + '&quote=' + encodeURIComponent(document.URL)); return false;"">");
            EndContext();
            BeginContext(3198, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b371095437801a44c7b302a9218043b23c61015c18001", async() => {
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
            BeginContext(3287, 291, true);
            WriteLiteral(@"</a></li>
                        <li><a href=""https://twitter.com/intent/tweet?source=&text=:%20"" target=""_blank"" title=""Tweet"" onclick=""window.open('https://twitter.com/intent/tweet?text=' + encodeURIComponent(document.title) + ':%20'  + encodeURIComponent(document.URL)); return false;"">");
            EndContext();
            BeginContext(3578, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b371095437801a44c7b302a9218043b23c61015c19553", async() => {
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
            BeginContext(3654, 293, true);
            WriteLiteral(@"</a></li>
                        <li><a href=""http://www.tumblr.com/share?v=3&u=&quote=&s="" target=""_blank"" title=""Post to Tumblr"" onclick=""window.open('http://www.tumblr.com/share?v=3&u=' + encodeURIComponent(document.URL) + '&quote=' +  encodeURIComponent(document.title)); return false;"">");
            EndContext();
            BeginContext(3947, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b371095437801a44c7b302a9218043b23c61015c21107", async() => {
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
            BeginContext(4031, 314, true);
            WriteLiteral(@"</a></li>
                        <li><a href=""http://pinterest.com/pin/create/button/?url=&description="" target=""_blank"" title=""Pin it"" onclick=""window.open('http://pinterest.com/pin/create/button/?url=' + encodeURIComponent(document.URL) + '&description=' +  encodeURIComponent(document.title)); return false;"">");
            EndContext();
            BeginContext(4345, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b371095437801a44c7b302a9218043b23c61015c22682", async() => {
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
            BeginContext(4424, 290, true);
            WriteLiteral(@"</a></li>
                        <li><a href=""http://www.reddit.com/submit?url=&title="" target=""_blank"" title=""Submit to Reddit"" onclick=""window.open('http://www.reddit.com/submit?url=' + encodeURIComponent(document.URL) + '&title=' +  encodeURIComponent(document.title)); return false;"">");
            EndContext();
            BeginContext(4714, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b371095437801a44c7b302a9218043b23c61015c24233", async() => {
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
            BeginContext(4800, 252, true);
            WriteLiteral("</a></li>\r\n                        <li><a href=\"mailto:?subject=&body=:%20\" target=\"_blank\" title=\"Send email\" onclick=\"window.open(\'mailto:?subject=\' + encodeURIComponent(document.title) + \'&body=\' +  encodeURIComponent(document.URL)); return false;\">");
            EndContext();
            BeginContext(5052, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b371095437801a44c7b302a9218043b23c61015c25753", async() => {
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
            BeginContext(5131, 135, true);
            WriteLiteral("</a></li>\r\n                    </ul>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <small><b>Fat:</b>");
            EndContext();
            BeginContext(5267, 44, false);
#line 87 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Valor.Fat));

#line default
#line hidden
            EndContext();
            BeginContext(5311, 49, true);
            WriteLiteral("</small>\r\n                    <small><b>Kcal:</b>");
            EndContext();
            BeginContext(5361, 45, false);
#line 88 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Valor.Kcal));

#line default
#line hidden
            EndContext();
            BeginContext(5406, 49, true);
            WriteLiteral("</small>\r\n                    <small><b>Prot:</b>");
            EndContext();
            BeginContext(5456, 45, false);
#line 89 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Valor.Prot));

#line default
#line hidden
            EndContext();
            BeginContext(5501, 49, true);
            WriteLiteral("</small>\r\n                    <small><b>Carb:</b>");
            EndContext();
            BeginContext(5551, 45, false);
#line 90 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Valor.Carb));

#line default
#line hidden
            EndContext();
            BeginContext(5596, 240, true);
            WriteLiteral("</small>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <button type=\"button\" class=\"btn btn-danger\" />\r\n                    <input type=\"button\" id=\"preparar\" value=\"Preparar Receita\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5836, "\"", 5924, 3);
            WriteAttributeValue("", 5846, "location.href=\'", 5846, 15, true);
#line 94 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
WriteAttributeValue("", 5861, Url.Action("PrepararReceita", "Receitas",new { id = item.id}), 5861, 62, false);

#line default
#line hidden
            WriteAttributeValue("", 5923, "\'", 5923, 1, true);
            EndWriteAttribute();
            BeginContext(5925, 227, true);
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col\">\r\n                    <button type=\"button\" class=\"btn btn-warning\" />\r\n                    <input type=\"button\" id=\"ver\" value=\"Ver Receita\" class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6152, "\"", 6235, 3);
            WriteAttributeValue("", 6162, "location.href=\'", 6162, 15, true);
#line 98 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
WriteAttributeValue("", 6177, Url.Action("GetReceita", "Receitas",new { id = item.id}), 6177, 57, false);

#line default
#line hidden
            WriteAttributeValue("", 6234, "\'", 6234, 1, true);
            EndWriteAttribute();
            BeginContext(6236, 65, true);
            WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 102 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
    }

#line default
#line hidden
#line 102 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\Lista.cshtml"
     
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
