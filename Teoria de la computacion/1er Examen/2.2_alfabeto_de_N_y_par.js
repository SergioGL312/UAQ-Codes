let lista = [];
let nuevaLista = [];
let w = [];
let cont = 0, tam, longi;

const pedirDatos = () => {
	tam = prompt("Digite el tamanio del lenguaje");
	for (let i = 0; i < tam; i++) {
		lista.push(prompt(`${(i + 1)}.- Digite la letra`));
	}
	longi = prompt("Digite la longitud del conjunto");
}

const lenguaje = (letra) =>{
    if(letra.length > 4){
        return;
    }
    let letra2 = letra;
    nuevaLista.push(letra2);
    for(let i = 0; i < 3; i++){
        lenguaje(letra2 + lista[i]);
    }
}

const bucle = () =>{
    for (let i = 0; i < lista.length; i++) {
        lenguaje(lista[i]);
    }   
}

const mostrar = () => {
    document.write(`^<br>`);
    for (const iterator of nuevaLista) {
        document.write(`${iterator} <br>`);
    }
}

const pares = () => {
    document.write(`<br><br>Par de los simbolos del alfabeto<br><br>`);
    let x;
    for (let i = 0; i < nuevaLista.length; i++) {
        if (nuevaLista[i].length % 2 == 0) w.push(nuevaLista[i]);
    }
    for (let palabra of w) {
        let mapa = new Map();
        x = palabra.split('');
        for (const letras of x) {
            if (mapa.has(letras) == false) {
                mapa.set(letras, 1);
            } else {
                let cant = mapa.get(letras);
                cant++;
                mapa.set(letras, cant);
            }
            
        }
        let banderaPar = true;
        //console.log(`termino las letras: ${palabra}`);
        for (const iterator of mapa) {
            if (iterator[1] % 2 === 1) {
                banderaPar = false;
                break;
            }
        }
        if (banderaPar) {
            document.write(`${palabra}<br>`);
        }
    }
}

pedirDatos();
bucle();
mostrar();
pares();
