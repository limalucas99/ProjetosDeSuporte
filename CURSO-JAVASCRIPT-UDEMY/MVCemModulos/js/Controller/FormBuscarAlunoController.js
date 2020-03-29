export class FormBuscarAlunoController{
    //PERMITE QUE A CLASSE SEJA IMPORTADA EM OUTROS ARQUIVOS .js
    constructor(model, view){
        this.model = model;
        this.view = view;
    }
    
    buscarAluno( callback ){
        var nome = this.view.$seletor.querySelector('input').value;
        var filtrados = this.model.buscarAlunos(nome);
        
        if(filtrados && typeof callback === 'function'){
            callback(filtrados)
        }
    }
    
    limparInput(){
        this.view.$seletor.querySelector('input').value = '';
    }
}