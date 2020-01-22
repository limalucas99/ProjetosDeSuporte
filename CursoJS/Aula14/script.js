function carregar() {
    var msg = window.document.getElementById("msg");
    var img = window.document.getElementById("imagem");
    var data = new Date();
    var hora = data.getHours();
    msg.innerHTML = `Agora sao ${hora} horas.`;
    if (hora >= 0 && hora < 12) {
        //BOM DIA!
        img.src = "fotomanha.jpg";
        document.body.style.background = "orange";
    }
    else if (hora >= 12 && hora < 18) {
        // BOA TARDE!
        img.src = "fototarde.jpg";
        document.body.style.background = "white";
    }
    else {
        // BOA NOITE!
        img.src = "fotonoite.jpg";
        document.body.style.background = "gray";
    }
}