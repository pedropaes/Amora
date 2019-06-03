
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
		if (annyang) {
                // Let's define a command.
                console.log("It detected annyang");
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



        recognition.onresult = function (event) {

            var last = event.results.length - 1;
            var command = event.results[last][0].transcript;
            switch (command.toLowerCase()) {
                case 'preparar receita':
                    document.getElementById('preparar').click();
                    annyang.stop();
                    break;
                case 'ver receita':
                    document.getElementById('ver').click();
                    annyang.stop();
                    break;

                    break;
                default:
                    break;
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
