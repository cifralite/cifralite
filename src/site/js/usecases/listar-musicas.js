let conteudo = document.getElementById("conteudo")

//Listar Músicas
musicas.forEach(musica => {
        let itemMusica = document.createElement("div");

        itemMusica.innerHTML += `<p>${musica.titulo}</p>`
        conteudo.appendChild(itemMusica)

        let botaoEscolherMusica = document.createElement("a")
        botaoEscolherMusica.setAttribute("href", "index.html")
        botaoEscolherMusica.setAttribute("onclick", `AcessarMusica(${musica.id})`)
        botaoEscolherMusica.innerHTML = `<span class="material-symbols-outlined">trending_flat</span>`
        itemMusica.appendChild(botaoEscolherMusica)
});

//Acessar Música escolhida
function AcessarMusica(id) {
    SalvarId(id)
}