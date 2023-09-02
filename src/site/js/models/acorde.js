class Acorde {
    constructor(nota, tempo, complemento) {
        this.nota = nota;
        this.tempo = tempo;
        this.complemento = complemento;
    }

    static criarAcorde(novaNota = "") {
        let notaDividida = novaNota.split('|');

        let tempo = notaDividida[1];

        let nota = notaDividida[0].substring(0, 1);
        let complemento = notaDividida[0].substring(1);

        if (notaDividida[0].includes('#')) {
            nota = notaDividida[0].substring(0, 2);
            complemento = notaDividida[0].substring(2);
        }

        return new Acorde(nota, tempo, complemento);
    }

    subirNota() {
        let notas = ['C', 'C#', 'D', 'D#', 'E', 'F', 'F#', 'G', 'G#', 'A', 'A#', 'B'];
        if (this.nota == 'B') {
            this.nota = 'C';
            return;
        }
        let index = notas.indexOf(this.nota);
        this.nota = notas[index + 1];
    }
}
