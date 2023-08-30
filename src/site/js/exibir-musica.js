
let musica = musicas[0]

let titulo = document.getElementById('titulo')
titulo.innerHTML = musica.titulo

let tom = document.getElementById('tom')
tom.innerHTML = `Tom: ${musica.tom}`

let tempo = document.getElementById('tempo')
tempo.innerHTML = `Tempo: ${musica.tempo}BPM`

let conteudo = document.getElementById('conteudo')
let divIntroducao = document.createElement('div')
divIntroducao.id = 'introducao'
conteudo.appendChild(divIntroducao)

let divNotas = document.createElement('div')
divNotas.classList.add('notas')
divIntroducao.appendChild(divNotas)

musica.acordes.forEach(acorde => {
    let divNotaComTempo = document.createElement('div')
    divNotaComTempo.classList.add('nota-com-tempo')
    divNotas.appendChild(divNotaComTempo)

    let tempo = document.createElement('small')
    tempo.classList.add('tempo')
    tempo.innerHTML = acorde.split('|')[1]
    divNotaComTempo.appendChild(tempo)

    let nota = document.createElement('span')
    nota.classList.add('nota')
    nota.innerHTML = acorde.split('|')[0]
    divNotaComTempo.appendChild(nota)
})
