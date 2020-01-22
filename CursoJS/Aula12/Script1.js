function verificar() {
    var data = new Date();
    var ano = data.getFullYear();
    var fano = document.getElementById("txtano");
    var res = document.querySelector("div#res");
    if (fano.value.length == 0 || fano.value > ano) {
        window.alert("Erro");
    }
    else {
        var fsex = document.getElementsByName("radsex");
        var idade = ano - Number(fano.value);
        var genero = "";
        var img = document.createElement("img");
        img.setAttribute("id", "foto");
        if (fsex[0].checked) {
            genero = "homem";
            if (idade >= 0 && idade < 10) {
                //Criança
                img.setAttribute("src", "homem-bebe.jpg");
            }
            else if (idade >= 10 && idade < 21) {
                //jovem
                img.setAttribute("src", "homem-jovem.jpg");
            }
            else if (idade >= 21 && idade< 50) {
                //adulto
                img.setAttribute("src", "homem-adulto.jpg");
            }
            else {
                //idoso
                img.setAttribute("src", "homem-idoso.jpg");
            }

        }
        else if (fsex[1].checked) {
            genero = "mulher"
            if (idade >= 0 && idade < 10) {
                //Criança
                img.setAttribute("src", "mulher-bebe.jpg");
            }
            else if (idade >= 10 && idade < 21) {
                //jovem
                img.setAttribute("src", "mulher-jovem.jpg");
            }
            else if (idade >= 21 && idade< 50) {
                //adulta
                img.setAttribute("src", "mulher-adulta.jpg");
            }
            else {
                //idosa
                img.setAttribute("src", "mulher-idosa.jpg");
            }
        }
       // res.style.textAlign = "left"; //formatar alinhamento pelo Javascript
        res.innerHTML = `Detectamos ${genero} com ${idade} anos.`;
        //style="border-radius: 50%" width="230" height="230"
        res.appendChild(img);
        img.style.borderRadius = "50%";
        img.width = "230";
        img.height = "230";
    }
   
}