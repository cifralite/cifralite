// exibir dialog
const button = document.getElementById("btn-adicionar-musica")
const modalAdicionando = document.getElementById("adicionar-musica-modal")
const botaoFechar = document.getElementById("botao-fechar")

button.onclick = function () {
    modalAdicionando.showModal()
}

botaoFechar.onclick = function () {
    modalAdicionando.close()
}

document.addEventListener("DOMContentLoaded", function () {
    const chordsContainer = document.getElementById("chordsContainer");
    const addChordButton = document.querySelector(".add-chord-button");

    addChordButton.addEventListener("click", function () {
        const chordInput = document.createElement("div");
        chordInput.classList.add("chord-input");
        chordInput.innerHTML = `
            <label for="chord">Acorde:</label>
            <input type="text" class="chord" name="chord" placeholder="Nota|Tempo">
            <button type="button" class="remove-chord-button">Delete</button>
        `;

        const removeChordButton = chordInput.querySelector(".remove-chord-button");
        removeChordButton.addEventListener("click", function () {
            chordsContainer.removeChild(chordInput);
        });

        chordsContainer.appendChild(chordInput);
    });
});

// pegar os valores
document.addEventListener("DOMContentLoaded", function () {
    const enviar = document.getElementById("botao-enviar");

    enviar.addEventListener("click", function () {


        const tempoInput = document.getElementById("campo-tempo");
        const tomInput = document.getElementById("campo-tom");
        const tituloInput = document.getElementById("campo-titulo");
        const conteudoInput = document.getElementById("conteudo-musica-texto");

        const tempoValor = tempoInput.value;
        const tomValor = tomInput.value;
        const tituloValor = tituloInput.value;
        const conteudoValor = conteudoInput.value

        processarMusicas(tituloValor, tomValor, tempoValor, conteudoValor)

        const chordsForm = document.getElementById("chordsForm");
        const chordInputs = chordsForm.querySelectorAll(".chord");

        const chordValues = [];

        chordInputs.forEach(function (input) {
            chordValues.push(Acorde.criarAcorde(input.value));
        });

        const musicas = LerMusicas();

        const novaMusica = new Musica(tituloValor, tomValor, tempoValor, secaoValor);

        musicas.push(novaMusica);

        SalvarMusicas(musicas);
    });


})

function processarMusicas(titulo, tom, tempo, conteudoTexto = "") {

    const secoes = []
    const linhas = conteudoTexto.split('\n');

    let secao = null

    // linha = string
    linhas.forEach(linha => {

        if (linha.trim() === '') return;

        const inicioDaSecao = linha.match(/^\[(.+)\]$/);
        const fimDaSecao = linha.match(/^\[\/(.+)\]$/);

        if (inicioDaSecao && !linha.includes('/')) {
            secao = inicioDaSecao[1];
            secoes[secao] = '';
            return
        }

        if (fimDaSecao) {
            secao = null;
            return
        }

        secoes[secao] += linha + ' ';
    });

    console.log(secoes);
}

