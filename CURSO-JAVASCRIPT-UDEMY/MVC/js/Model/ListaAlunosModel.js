class ListaAlunos{
    constructor(_lista){
        this.lista = [].concat(_lista);
    }
    
    obterPorId(_id){
        return this.lista.filter( aluno => aluno._id === _id )[0]; //COMO O FILTER RETORNA UM ARRAY COM UM VALOR SÓ, PORQUE O ÍNDICE É UNICO, PEGO A PRIMEIRA POSIÇÃO DO ARRAY, QUE SERÁ O ALUNO BUSCADO
        //RETORNA O ALUNO COM ID QUE FOI PASSADO
    }
    
    
    adicionarAluno(aluno){
        this.lista.push(aluno);
    }
    
}