function validaExclusao(id, evento) {
        
        if (confirm("Você realmente quer deletar esse registro?")) {
            return true;
        }
    else {
        evento.preventDefault();
    return false;
        }
    }