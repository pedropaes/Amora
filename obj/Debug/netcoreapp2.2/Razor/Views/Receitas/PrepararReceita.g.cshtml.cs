#pragma checksum "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\PrepararReceita.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9908813ab8bdfb8f46571a2b107aac960e8a0360"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receitas_PrepararReceita), @"mvc.1.0.view", @"/Views/Receitas/PrepararReceita.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Receitas/PrepararReceita.cshtml", typeof(AspNetCore.Views_Receitas_PrepararReceita))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9908813ab8bdfb8f46571a2b107aac960e8a0360", @"/Views/Receitas/PrepararReceita.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2b1ceadc538df1f5ab041de02d3d2dd336819e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Receitas_PrepararReceita : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReceitaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/eloise.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("charset", new global::Microsoft.AspNetCore.Html.HtmlString("iso-8859-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/background.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("First slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("500"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("500"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/favorite.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("35"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("35"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(".d-none .d-lg-block .d-xl-none w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Second slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("350"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/button_loja.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(25, 182, true);
            WriteLiteral("<script src=\"https://cdnjs.cloudflare.com/ajax/libs/annyang/2.6.0/annyang.min.js\"></script>\r\n<script src=\"//code.responsivevoice.org/responsivevoice.js?key=3G053CLH\"></script>\r\n\r\n<b>");
            EndContext();
            BeginContext(208, 45, false);
#line 5 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\PrepararReceita.cshtml"
Write(Html.DisplayFor(modelItem => Model.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(253, 144, true);
            WriteLiteral("</b>\r\n\r\n<script  charset=\"utf-8\">\r\n    function speak(input) {\r\n        responsiveVoice.speak(input, \"Portuguese Female\");\r\n    }\r\n</script>\r\n\r\n");
            EndContext();
            BeginContext(397, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9908813ab8bdfb8f46571a2b107aac960e8a03609566", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(479, 316, true);
            WriteLiteral(@"

<script charset=""iso-8859-1"">
    var arr = [""Antes de iniciar a receita, certifique-se que tem todos os ingredientes.  Quando estiver pronto para iniciar a receita, diga iniciar ou seguinte. Se não tiver todos os ingredientes poderá descobrir a loja mais próxima através do comando loja.""];
    var numero = '");
            EndContext();
            BeginContext(796, 18, false);
#line 17 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\PrepararReceita.cshtml"
             Write(Model.Passos.Count);

#line default
#line hidden
            EndContext();
            BeginContext(814, 258, true);
            WriteLiteral(@"';
    var actual = 0;
    var proximo;
</script>

<div class=""container"">

   
    <div class=""row"">

        <div class=""col-6"">
            <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"" data-interval=""false"">
");
            EndContext();
#line 29 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\PrepararReceita.cshtml"
                  
                    var total = @Model.Passos.Count + 1;
                

#line default
#line hidden
            BeginContext(1169, 50, true);
            WriteLiteral("                <ol class=\"carousel-indicators\">\r\n");
            EndContext();
#line 33 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\PrepararReceita.cshtml"
                     foreach (var item in Model.Passos.Values)
                    {


#line default
#line hidden
            BeginContext(1308, 89, true);
            WriteLiteral("                        <li slidedata-target=\"#carouselExampleIndicators\" data-slide-to=\"");
            EndContext();
            BeginContext(1398, 40, false);
#line 36 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\PrepararReceita.cshtml"
                                                                                    Write(Html.DisplayFor(modelItem => item.passo));

#line default
#line hidden
            EndContext();
            BeginContext(1438, 24, true);
            WriteLiteral("\" class=\"active\"></li>\r\n");
            EndContext();
#line 37 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\PrepararReceita.cshtml"

                    }

#line default
#line hidden
            BeginContext(1487, 85, true);
            WriteLiteral("                    <li slidedata-target=\"#carouselExampleIndicators\" data-slide-to=\"");
            EndContext();
            BeginContext(1573, 5, false);
#line 39 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\PrepararReceita.cshtml"
                                                                                Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(1578, 264, true);
            WriteLiteral(@""" class=""active""></li>
                </ol>
          
                   
                        

                   

          
                <div class=""carousel-inner"">
                    <script>speak(arr[0]);</script>

                    ");
            EndContext();
            BeginContext(1842, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9908813ab8bdfb8f46571a2b107aac960e8a036014030", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
            BeginContext(1942, 307, true);
            WriteLiteral(@"
                    <div class=""carousel-item active"">
                        <div class=""carousel-caption d-none d-md-block"">

                            <b>Antes de iniciar a receita, certifique-se que tem todos os ingredientes:</b>
                            <ul style=""list-style-type:none;"">
");
            EndContext();
#line 57 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\PrepararReceita.cshtml"
                                 foreach (var item in Model.Ingredientes)
                                {

#line default
#line hidden
            BeginContext(2359, 36, true);
            WriteLiteral("                                <li>");
            EndContext();
            BeginContext(2396, 48, false);
#line 59 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\PrepararReceita.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Key.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(2444, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(2448, 40, false);
#line 59 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\PrepararReceita.cshtml"
                                                                                   Write(Html.DisplayFor(modelItem => item.Value));

#line default
#line hidden
            EndContext();
            BeginContext(2488, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 60 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\PrepararReceita.cshtml"
                                }

#line default
#line hidden
            BeginContext(2530, 265, true);
            WriteLiteral(@"                            </ul>
                            <b>Quando estiver pronto para iniciar a receita diga 'Iniciar' ou 'Seguinte'</b>
                            
                            
                        </div>
                    </div>
");
            EndContext();
#line 67 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\PrepararReceita.cshtml"
                     foreach (var item in Model.Passos.Values)
                    {


#line default
#line hidden
            BeginContext(2884, 174, true);
            WriteLiteral("                        <div class=\"carousel-item\">\r\n                            <div class=\"carousel-caption d-none d-md-block\">\r\n                                <h1>Passo  ");
            EndContext();
            BeginContext(3059, 40, false);
#line 72 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\PrepararReceita.cshtml"
                                      Write(Html.DisplayFor(modelItem => item.passo));

#line default
#line hidden
            EndContext();
            BeginContext(3099, 46, true);
            WriteLiteral("</h1>\r\n                                <h2><p>");
            EndContext();
            BeginContext(3146, 42, false);
#line 73 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\PrepararReceita.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.tecnica));

#line default
#line hidden
            EndContext();
            BeginContext(3188, 138, true);
            WriteLiteral("</p></h2>\r\n                                <script type=\"text/javascript\" charset=\"utf-8\">\r\n                                    arr.push(\'");
            EndContext();
            BeginContext(3327, 22, false);
#line 75 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\PrepararReceita.cshtml"
                                         Write(Html.Raw(item.tecnica));

#line default
#line hidden
            EndContext();
            BeginContext(3349, 116, true);
            WriteLiteral("\');\r\n                                </script>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 79 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\PrepararReceita.cshtml"
                    }

#line default
#line hidden
            BeginContext(3488, 378, true);
            WriteLiteral(@"                    <div class=""carousel-item"">
                        <div class=""carousel-caption d-none d-md-block"">
                            <h1>Receita Concluída</h1>
                            <p><h2>Bom apetite!</h2></p>
                            <b>Não se esqueça de adicionar aos favoritos:</b>
                            <p align=""center""><a id=""favorita""");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 3866, "\'", 3941, 1);
#line 85 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\PrepararReceita.cshtml"
WriteAttributeValue("", 3873, Url.Action("SetFavorito", "Receitas", new { id_receita = Model.id}), 3873, 68, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3942, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3943, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9908813ab8bdfb8f46571a2b107aac960e8a036020530", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
            BeginContext(4033, 1040, true);
            WriteLiteral(@"</a></p>
                            <script type=""text/javascript"" charset=""utf-8"">

                                arr.push('A receita foi concluída, bom apetite! Se desejar adicionar a receita aos seus favoritos use o comando, Favorita.');
                            </script>
                        </div>
                    </div>
                </div>
                <a id='previous' class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a id='next' class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
        </div>
        <div class=""col");
            WriteLiteral("\">\r\n            ");
            EndContext();
            BeginContext(5073, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9908813ab8bdfb8f46571a2b107aac960e8a036023144", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5128, "~/images/", 5128, 9, true);
#line 104 "C:\Users\Pedro\source\repos\Eloise\Views\Receitas\PrepararReceita.cshtml"
AddHtmlAttributeValue("", 5137, Html.DisplayFor(modelItem => Model.imagem), 5137, 43, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5226, 184, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n<p></p>\r\n<p></p>\r\n<p align=\"center\"><a id=\"loja\" target=\"_blank\" rel=\"noopener noreferrer\" href=\"https://www.google.com/maps/search/continente\">");
            EndContext();
            BeginContext(5410, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9908813ab8bdfb8f46571a2b107aac960e8a036025294", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5480, 10, true);
            WriteLiteral("</a></p>\r\n");
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
