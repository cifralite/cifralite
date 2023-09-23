class Musica {

    constructor(id, titulo, tom, tempo, secoes) {
        this.id = id
        this.titulo = titulo
        this.tom = tom
        this.tempo = tempo
        this.secoes = secoes
    }

    subirTom() {
        let notas = ['C', 'C#', 'D', 'D#', 'E', 'F', 'F#', 'G', 'G#', 'A', 'A#', 'B']
        if (this.tom == 'B') {
            this.tom = 'C'
            return
        }
        let index = notas.indexOf(this.tom)
        this.tom = notas[index + 1]

    }

}

var musicas2 = [
    {
        titulo: 'Santo Espirito',
        tom: 'E',
        tempo: 90,
        acordes: [
            'E|8', 'A|8',
        ]
    },
    new Musica('Santo Espirito', 'E', 90,
        [
            new Secao('Intro',
                [
                    Acorde.criarAcorde('E7(9)11+|8'),
                    Acorde.criarAcorde('A4|8'),
                ])
        ])

]