var musicas = LerMusicas()
var musica = null

function SalvarMusicas(musicas = []) {
    localStorage.setItem('musicas', JSON.stringify(musicas))
}

function SalvarId(id) {
    localStorage.setItem('id', JSON.stringify(id))
}

function LerId() {
    return JSON.parse(localStorage.getItem('id'))
}

function LerMusicas() {
    return JSON.parse(localStorage.getItem('musicas'))
}

localStorage.setItem('musicas', JSON.stringify([new Musica(1, 'Santo Espirito', 'E', 90,
    [
        new Secao('Intro',
            [
                Acorde.criarAcorde('E7(9)11+|8'),
                Acorde.criarAcorde('A4|8'),
            ])
    ]), new Musica(2, 'Deixa eu te usar', 'A', 90,
    [
        new Secao('Intro',
            [
                Acorde.criarAcorde('A|8'),
                Acorde.criarAcorde('D|4'),
                Acorde.criarAcorde('E|4'),

            ])
    ]),  new Musica(3, 'Ele Reina', 'E', 90,
    [
        new Secao('Intro',
            [
                Acorde.criarAcorde('E|2'),
                Acorde.criarAcorde('G|2'),
                Acorde.criarAcorde('E|2'),

            ])
    ])

]))

function MusicaPorId() {
    musicas.forEach(mus => {
        if (mus.id == LerId()) {
            musica = mus
        }
     });
}
