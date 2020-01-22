(function($){ //dolar será o objeto padrão
    
    $('.paroller').paroller()
    var contentWaypoint = function(){
        //selecionar o elemento que será animado, nesse caso é a classe .element-animate
        $('.element-animate').waypoint( function( direction ){//a função recebe um parametro c a direction
            console.log(direction);
            console.log(this);
            console.log(this.element);
            
            const $element = $(this.element);
            let effect = $element.data('animate-effect') || 'fadeInUp';
                        
            //if(direction === 'down') = se o usuário estiver rolando o scroll para baixo
            
            if(direction === 'down' && !$element.hasClass('element-animated')){
                $element.removeClass('element-animate').addClass('element-animated ' + effect)
            }
        }, {
            offset: '90%'
        })
    }
    
    contentWaypoint()
})(jQuery)