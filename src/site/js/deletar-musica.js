const modal = document.querySelector("dialog")
const btnCancelar = document.getElementById("btn-cancelar")
const btnConfirmar = document.getElementById("btn-confirmar")

let botaoDeletarMusica = document.createElement('button')
botaoDeletarMusica.classList.add('btn-delete')
botaoDeletarMusica.innerHTML = '<span class="material-symbols-outlined">delete</span>'
conteudo.appendChild(botaoDeletarMusica)

// Mostra o Modal
botaoDeletarMusica.onclick = function () {
    modal.showModal()
}

btnCancelar.onclick = function () {
    modal.close()
}

btnConfirmar.onclick = function () {
    musicas.pop()
    alert(musicas.length)
    exibirMusica()
    // musicas.pop()
}

// alert(musicas.splice)