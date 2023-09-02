const modal = document.querySelector("dialog")
const btnCancelar = document.getElementById("btn-cancelar")
const btnConfirmar = document.getElementById("btn-confirmar")
const cabecalho = document.getElementById("cabecalho")

let btnDeletarMusica = document.createElement('button')
btnDeletarMusica.classList.add('btn-delete')
btnDeletarMusica.innerHTML = '<span class="material-symbols-outlined">delete</span>'
cabecalho.appendChild(btnDeletarMusica)

// Mostra o Modal
btnDeletarMusica.onclick = function () {
    modal.showModal()
}

// Fecha o Modal
btnCancelar.onclick = function () {
    modal.close()
}

// Exclui a música da lista de músicas 
btnConfirmar.onclick = function () {
    if (musicas.indexOf(musica) >= 0) {
        musicas.splice(musicas.indexOf(musica), 1)
    }
    modal.close()
    const divMain = document.getElementById("main")
    divMain.removeChild(conteudo)
    divMain.removeChild(cabecalho)
}