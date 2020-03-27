var blg = (function(){
    var beluga = {};
    
    beluga.$ = document.querySelector.bind(document);
    beluga.$$ = document.querySelectorAll.bind(document);
    
    Array.prototype.getMedia = function(){
        //return _calcularMedia.apply(this, this);
        return _calcularMedia(...this);
        //SPEAD OPERATOR - igual VAR ARGS do JAVA - É COMO SE PASSASSE CADA ELEMENTO DO ARRAY COMO PARÂMETRO
    };
    
    function _calcularMedia(){        
        let _arr = Array.prototype.map.apply(arguments, (n) => parseFloat(n) );
        let hasNaN = _arr.some( (n) => isNaN(n) ); 
        if(hasNaN) throw new Error('somente números');       
        
        let total = (_arr.reduce(function(total, atual, i){
            return total + atual;
        }) ) / _arr.length;
        return total;
    }
    
    beluga.calcularMedia = _calcularMedia;
    
    function _each(sel, fn){
        var _sel = this.$$(sel);
        //this é o proprio beluga
        Array.prototype.forEach.call(_sel, fn)
    }
    beluga.each = _each;
    
    return beluga;
})()