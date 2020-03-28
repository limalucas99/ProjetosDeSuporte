var alunos = ["Daniel", "Maria", "Jose"];
alunos = alunos.map( aluno => new Aluno(aluno) );

alunos[0].adicionarNotas(5,2,3,8);
alunos[1].adicionarNotas(5,10,3,8);
alunos[2].adicionarNotas(5,2,8,8);

var listaAlunos = new ListaAlunos(alunos);
console.log(listaAlunos);

var listaAlunosView = new ListaAlunosView('#listaAlunos');
listaAlunosView.atualiza(listaAlunos);

var listaAlunosController = new ListaAlunosController(listaAlunos, listaAlunosView);

blg.$('#form-adiciona form').addEventListener('submit',function(e){
    e.preventDefault();
    
    var nome = blg.$('#nome').value;
   
    var notas = [];
    
    var i = 1;
    while(blg.$('#nota'+i)){ //executa até existir notas
        notas.push(parseFloat(blg.$('#nota'+i).value));
        i++;
    }
    
    
    listaAlunosController.adicionarAluno(nome, notas);
    var nome = blg.$('#nome').value = '';
    var nome = blg.$('#nota1').value = '';
    var nome = blg.$('#nota2').value = '';
    var nome = blg.$('#nota3').value = '';
    var nome = blg.$('#nota4').value = '';
    var nome = blg.$('#nome').focus();
    
    
})