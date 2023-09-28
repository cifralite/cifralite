let modal = document.getElementById("modal-delete")
let btnDeletarMusica = document.getElementById("btn-delete")
let btnCancelar = document.getElementById("btn-cancelar")
let btnConfirmar = document.getElementById("btn-confirmar")
let cabecalho = document.getElementById("cabecalho")

btnDeletarMusica.onclick = function () {
    modal.showModal()
}

btnCancelar.onclick = function () {
    modal.close()
}

btnConfirmar.onclick = function () {
    if (musicas.indexOf(musica) >= 0) {
        musicas.splice(musicas.indexOf(musica), 1)
        SalvarMusicas(musicas)
    }
    modal.close()
    let divMain = document.getElementById("main")
    divMain.removeChild(conteudo)
    divMain.removeChild(cabecalho)
}