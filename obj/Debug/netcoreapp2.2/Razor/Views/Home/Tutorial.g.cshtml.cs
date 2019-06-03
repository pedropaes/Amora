#pragma checksum "C:\Users\Pedro\source\repos\Eloise\Views\Home\Tutorial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58415a1ff5b97a6f6ffbe3f4f0b6255b740a4e92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Tutorial), @"mvc.1.0.view", @"/Views/Home/Tutorial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Tutorial.cshtml", typeof(AspNetCore.Views_Home_Tutorial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58415a1ff5b97a6f6ffbe3f4f0b6255b740a4e92", @"/Views/Home/Tutorial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2b1ceadc538df1f5ab041de02d3d2dd336819e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Tutorial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Pedro\source\repos\Eloise\Views\Home\Tutorial.cshtml"
  
    ViewData["Title"] = "Tutorial";

#line default
#line hidden
            BeginContext(44, 4994, true);
            WriteLiteral(@"<script src=""//code.responsivevoice.org/responsivevoice.js?key=3G053CLH""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/annyang/2.6.0/annyang.min.js""></script>
<script>
    function speak(input) {
        responsiveVoice.speak(input, ""Portuguese Female"");
    }
</script>


<script>
    function wait(ms) {
        var d = new Date();
        var d2 = null;
        do { d2 = new Date(); }
        while (d2 - d < ms);
    }

    var SpeechRecognition = SpeechRecognition || webkitSpeechRecognition;
    var SpeechGrammarList = SpeechGrammarList || webkitSpeechGrammarList;
    var audio = new Audio('/sounds/beep.mp3');
    var grammar = '#JSGF V1.0;'
    var recognition = new SpeechRecognition();
    var speechRecognitionList = new SpeechGrammarList();
    speechRecognitionList.addFromString(grammar, 1);
    recognition.grammars = speechRecognitionList;
    recognition.lang = 'pt-PT';
    recognition.interimResults = false;
    window.onload = function () {
        if (ann");
            WriteLiteral(@"yang) {
            // Let's define a command.
            console.log(""It detected annyang"");
            var commands = {
                'eloise': function () {
                    audio.play();

                    recognition.start();

                    wait(4000);



                }
            };

            // Add our commands to annyang
            annyang.addCommands(commands);

            // Start listening.
            annyang.start();
        }
    }



</script>

<script>


    recognition.onresult = function (event) {

        var last = event.results.length - 1;
        var command = event.results[last][0].transcript;
        document.getElementById('procura').setAttribute('value', command);
        document.getElementById('procurar').click();
        switch (command.toLowerCase()) {
            case 'procura *tag':
                document.getElementById('procura').setAttribute('value', tag);
                alert('cdoijcd' + tag);
              ");
            WriteLiteral(@"  break;

                break;
            default:

            // code block
        }

    };
    recognition.onspeechend = function () {
        recognition.stop();
    };

    recognition.onerror = function (event) {
        message.textContent = 'Error occurred in recognition: ' + event.error;
    }
    document.querySelector('#btnGiveCommand').addEventListener('click', function () {
        recognition.start();
    });

</script>

<script>speak('Olá eu sou a Éloíse, consigo executar vários comandos de voz, e assistir o processo de preparação de uma receita. Poderá procurar uma receita usando o comando procurar. seguido do nome do ingrediente, ou descrição da receita a procurar. Durante a preparação da receita poderá usar os comandos. próximo. anterior. sair. repete.  Consulte a tabela abaixo para ver todos os comandos disponíveis. Quando terminar, experimente dizer procurar.  e  o nome de um qualquer ingrediente');</script>
<div class=""text-center"">
    <h1 class=""display-4"">T");
            WriteLiteral(@"utorial</h1>
    <p> Olá eu sou a <b>Eloíse</b>, consigo executar vários comandos de voz e assistir o processo de prepração de uma receita </p>

    <p>Poderá procurar uma receita usando o comando procurar seguido de um ingrediente ou descrição da receita</p>

    <p>
        Durante a preparação da receita os comandos disponíveis são:


        <table class=""table"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">Comando</th>
                    <th scope=""col"">Resultado</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope=""row"">começar</th>
                    <td>Inicia a preparação da receita</td>
                </tr>
                <tr>
                    <th scope=""row"">próximo/seguinte</th>
                    <td>Vai para o próximo passo</td>
                </tr>
                <tr>
                    <th scope=""row"">volta/anterior</th>
                    ");
            WriteLiteral(@"<td>Vai para o próximo passo</td>
                </tr>
                <tr>
                    <th scope=""row"">passo ""número"" </th>
                    <td>Vai para o passo correspondente</td>
                </tr>
                <tr>
                    <th scope=""row"">sair</th>
                    <td>Abandona a preparação da receita</td>
                </tr>
                <tr>
                    <th scope=""row"">repete/repetir</th>
                    <td>Repete a instrução do passo</td>
                </tr>
                <tr>
                    <th scope=""row"">tutorial</th>
                    <td>Regressa a esta página</td>
                </tr>
                <tr>
                    <th scope=""row"">favorito</th>
                    <td>Adiciona a receita aos favoritos</td>
                </tr>

            </tbody>
        </table>


</div>");
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
