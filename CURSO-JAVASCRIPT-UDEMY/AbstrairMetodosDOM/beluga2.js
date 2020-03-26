var blg = (function(){
    var beluga = {};
    
    beluga.$ = document.querySelector.bind(document);
    //AO INVÉS DE TER QUE DIGITAR TODA ESSA PARADA DO DOCUMENTO, É POSSÍVEL DIGITAR SÓ beluga.$
    //É NECESSÁRIO O BIND PARA QUE FAÇA A VARIÁVEL blg VIRAR O THIS QUE ESTÁ IMPLICITO NO QUERYSELECTOR
    //PEGA SÓ O PRIMEIRO VALOR
    beluga.$$ = document.querySelectorAll.bind(document);
    //PEGA TODOS OS VALORES
        
    return beluga;
})()