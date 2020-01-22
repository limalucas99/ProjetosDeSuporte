function contar() {
    let ini = document.getElementById("txti"); 
    let fim = document.getElementById("txtf"); 
    let passo = document.getElementById("txtp");
    let res = document.getElementById("res");

    if (ini.value.length == 0 || fim.value.length == 0 || passo.value.length == 0) {
        window.alert("Faltam dados");
    }
    else {
        res.innerHTML = `Contando: `;
        let i = Number(ini.value);
        let f = Number(fim.value);
        let p = Number(passo.value);

        if (p <= 0) {
            window.alert(`Passo Inválido! Considerando PASSO: 1`);
            p = 1;
        }

        if (i < f) {
            //crescente
            for (let c = i; c <= f; c += p) {
                res.innerHTML += `${c} \u{27A1}`;//U+27A1 unicode emoji list, tirar o U+ colocar \u e por do 2 até o 1 entre colchetes
            }
        }
        else {
            for (let c = i; c >= f; c -= p) {
                //decrescente
                res.innerHTML += `${c} \u{27A1}`;//U+27A1 unicode emoji list, tirar o U+ colocar \u e por do 2 até o 1 entre colchetes
            }
        }  
        res.innerHTML += `\u{1F3C1} + são çç~~`;
    }
}
//