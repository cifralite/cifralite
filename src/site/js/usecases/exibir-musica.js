MusicaPorId() // A variável música receberá a música que foi escolhida na página da lista de músicas

let titulo = document.getElementById('titulo')
titulo.innerHTML = musica.titulo

let tom = document.getElementById('tom')
tom.innerHTML = `${musica.tom}`

// let tempo = document.getElementById('tempo')
// tempo.innerHTML = `Tempo: ${musica.tempo}BPM`

let conteudo = document.getElementById('container')

musica.secoes.forEach(secao => {
    let divSecao = document.createElement('div')
    divSecao.classList.add('secao')
    divSecao.id = secao.nota

    let divAcordes = document.createElement('div')
    divAcordes.classList.add('notas')

    secao.acordes.forEach(acorde => {

        let divNotaComTempo = document.createElement('div')
        divNotaComTempo.classList.add('nota-com-tempo')

        let tempo = document.createElement('small')
        tempo.classList.add('tempo')
        tempo.innerHTML = acorde.tempo
        divNotaComTempo.appendChild(tempo)

        let nota = document.createElement('span')
        nota.classList.add('nota')
        nota.innerHTML = acorde.nota + acorde.complemento
        divNotaComTempo.appendChild(nota)

        divAcordes.appendChild(divNotaComTempo)

    })

    divSecao.appendChild(divAcordes)
    conteudo.appendChild(divSecao)
})