class ListaAlunosController{
    constructor(model, view){
        this.model = model;
        this.view = view;
        
        this.view.$seletor.addEventListener('click', this.editarAluno.bind(this));
        //É NECESSÁRIO COLOCAR O BIND, DESSA MANEIRA SEMPRE QUE FOR CLICADO E INSTANCIADO, ELE SERÁ O THIS
    }
    
    editarAluno(e){
        console.log(e.target);
        console.log(e.currentTarget);
        //É A <tbody>
        console.log(this);
        
        let target = e.target;
        
        while(target !== e.currentTarget){
            if (target.getAttribute('data-id')){
                break;
                //SE FOR O TARGET QUE EU QUERO, PARA O LOOP
            }
            target = target.parentNode;
        }
        console.log('----')
        console.log(target)
        
        if(target){
            let _id = parseInt(target.getAttribute('data-id'));
            //TUDO QUE VEM DO HTML, VEM COMO STRING, POR ISSO É NECESSÁRIO CONVERTE PARA NÚMERO, NESSE CASO UTILIZANDO parseInt para converter para int
            let _notas = prompt('digite as novas notas separadas por virgula');
            //ABRE UM PROMPT PARA O USUÁRIO DIGITAR AS NOTAS
            
            if(!_notas) return;
            
            _notas = _notas.split(',').map( nota => parseFloat(nota) );
            //PEGA AS NOTAS, UTILIZANDO A VIRGULA COMO SEPARAÇÃO E CONVERTE PARA PARSE FLOAT, PORQUE A NOTA PODE SER QUEBRADA EX: 2.7
            console.log(_notas)
            
            let aluno = this.model.obterPorId(_id);
            aluno.atualizarNotas(_notas);
            
            this.view.atualiza(this.model);
        }
    }
    
    
    adicionarAluno(nome, notas){
        this.model.adicionarAluno(new Aluno(nome, notas));
        this.view.atualiza(this.model);
    }
    
}