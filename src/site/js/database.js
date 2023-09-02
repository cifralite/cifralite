function SalvarMusicas(musicas = []) {
    localStorage.setItem('musicas', JSON.stringify(musicas))
}

function LerMusicas() {
    return JSON.parse(localStorage.getItem('musicas'))
}

localStorage.setItem('musicas', JSON.stringify([new Musica('Santo Espirito', 'E', 90,
    [
        new Secao('Intro',
            [
                Acorde.criarAcorde('E7(9)11+|8'),
                Acorde.criarAcorde('A4|8'),
            ])
    ])]))
