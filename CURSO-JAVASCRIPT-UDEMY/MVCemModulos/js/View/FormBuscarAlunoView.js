import { View } from './View.js';
export class FormBuscarAlunoView extends View{
    //PERMITE QUE A CLASSE SEJA IMPORTADA EM OUTROS ARQUIVOS .js
    constructor(seletor){
        super(seletor);
        this.$seletor.innerHTML = this.getTemplate();
    }
    
    getTemplate(){
        return `
            <form class="form-inline">
			  <div class="form-group">
			    Busca: <input type="text" class="form-control" placeholder="Nome" name="nome" id="nome" required>
			  </div>
			  
			  <button type="submit" class="btn btn-default" id="btnBuscar">Buscar</button>
			  <button type="button" class="btn btn-default" id="btnLimparFiltro">Limpar Filtro</button>
			</form>
        `
    }
}