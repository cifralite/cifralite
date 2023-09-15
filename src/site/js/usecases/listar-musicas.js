let conteudo = document.getElementById("conteudo")

//Listar Músicas
musicas.forEach(musica => {
        let itemMusica = document.createElement("div")
        itemMusica.classList.add("musica")

        let informacoes = document.createElement("div")
        informacoes.classList.add("informacoes")

        informacoes.innerHTML += `<h2>${musica.titulo}</h2>`
        informacoes.innerHTML += `<p>Autor: não cadastrado</p>`
        conteudo.appendChild(itemMusica)
        itemMusica.appendChild(informacoes)

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