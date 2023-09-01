// exibir dialog
const button = document.getElementById("addDialogButton")
const modalAdicionando = document.getElementById("addDialog")
const buttonClose = document.getElementById("buttonClose")

button.onclick = function () {
    modalAdicionando.showModal()
}

buttonClose.onclick = function () {
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
    const enviar = document.getElementById("buttonEnviar");

    enviar.addEventListener("click", function () {
        const tempoInput = document.getElementById("buttonTempo");
        const tomInput = document.getElementById("buttonTom");
        const tituloInput = document.getElementById("buttonTitulo");

        const tempoValor = tempoInput.value;
        const tomValor = tomInput.value;
        const tituloValor = tituloInput.value;

        // console.log("Valor do título:", tituloValor);
        // console.log("Qual tom está:", tomValor);
        // console.log("Qual o tempo:", tempoValor);

        const chordsForm = document.getElementById("chordsForm");
        const chordInputs = chordsForm.querySelectorAll(".chord");

        // Armazena os valores dos acordes
        const chordValues = [];

        // Itera pelos campos de entrada de acorde e obtém seus valores
        chordInputs.forEach(function (input) {
            chordValues.push(input.value);
        });

        // console.log("Valores dos Acordes:", chordValues);
    });
})
