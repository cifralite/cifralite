const button = document.getElementById("addDialogButton")
const modal = document.getElementById("addDialog")
const buttonClose = document.getElementById("buttonClose")

button.onclick = function () {
    modal.showModal()
}

buttonClose.onclick = function () {
    modal.close()
}

document.addEventListener("DOMContentLoaded", function() {
    const chordsContainer = document.getElementById("chordsContainer");
    const addChordButton = document.querySelector(".add-chord-button");

    addChordButton.addEventListener("click", function() {
        const chordInput = document.createElement("div");
        chordInput.classList.add("chord-input");
        chordInput.innerHTML = `
            <label for="chord">Acorde:</label>
            <input type="text" class="chord" name="chord" placeholder="Nota|Tempo">
            <button type="button" class="remove-chord-button">Delete</button>
        `;

        const removeChordButton = chordInput.querySelector(".remove-chord-button");
        removeChordButton.addEventListener("click", function() {
            chordsContainer.removeChild(chordInput);
        });

        chordsContainer.appendChild(chordInput);
    });
});