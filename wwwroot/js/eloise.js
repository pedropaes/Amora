function speak(input) {
    responsiveVoice.speak(input, "Portuguese Female");
}

function wait(ms) {
    var d = new Date();
    var d2 = null;
    do { d2 = new Date(); }
    while (d2 - d < ms);
}

window.onload = function () {
    //var numero = 1;
    var audio = new Audio('/sounds/beep.mp3');
    //alert('passos:' + unescape(numero));
    //var arr = ["Antes de iniciar a receita, certifique-se que tem todos os ingredientes.  Quando estiver pronto para iniciar a receita, diga começar."];
    //var actual = 0;
    //var proximo;
    annyang.setLanguage('pt-PT');
    if (annyang) {
        // Let's define a command.

        console.log("It detected annyang");

        var commands = {
            'procura *tag': procura,
            'procurar *tag': procura,
            'preparar receita': preparar,
            'ver receita': ver,
            'tutorial': tutorial,
            'iniciar': comecar,
            'próximo': next,
            'seguinte': next,
            'anterior': previous,
            'volta': previous,
            'passo *num': passo,
            'repete': repete,
            'repetir': repete,
            'sair': sair,
            'favorita': favorita,
            'loja': loja,
        };

        function procura(tag) {
            //audio.play();
            //speak('A procurar ' + tag);
            //wait(1000);
            document.getElementById('procura').setAttribute('value', tag);
            document.getElementById('procurar').click();
        };

        function comecar() {
            if (actual == 0) {
                speak(arr[actual]);
                actual += 1;
                document.getElementById('next').click();
                speak(arr[actual]);
            }
        };

        function repete() {
            speak(arr[actual]);
        };

        function next() {
            proximo = 1;
            if (actual > numero) {
                speak('não é possível avançar');
            }
            else {
                //alert("" + actual + " " + proximo + " " + numero);
                actual = actual + proximo;
                document.getElementById('next').click();
                speak(arr[actual]);
            }
        };

        function previous() {
            proximo = -1;
            if (actual + proximo < 1) {
                speak('não existe anterior');
            }
            else {
                    actual = actual + proximo;
                    document.getElementById('previous').click();
                    speak(arr[actual]);
            }
        };

            function preparar() {
                document.getElementById('preparar').click();
            };

            function ver() {
                document.getElementById('ver').click();
            };

            function tutorial() {
                document.getElementById('tutorial').click();
            };

            function passo(num) {
                $(document).ready(function () {
                    $('#carouselExampleIndicators').carousel(parseInt(num));
                });
                if (parseInt(num) <= numero + 1) {
                    actual = parseInt(num);
                    speak(arr[actual]);
                }
                else speak('Passo não existe');
            };

            function sair() {
                speak('Sair');
                wait(1000);
                document.getElementById('inicio').click();
            };

            function loja() {
                document.getElementById('loja').click();
            };

            function favorita() {
                //audio.play();
                //speak('A procurar ' + tag);
                //wait(1000);
                document.getElementById('favorita').click();
            };

            // Add our commands to annyang
            annyang.addCommands(commands);

            // Start listening.
            annyang.start();
        }

    }
