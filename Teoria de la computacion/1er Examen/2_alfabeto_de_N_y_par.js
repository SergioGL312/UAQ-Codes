let tam, longi;
let lista = [];
let nuevaLista = [];
let w = [];
let a, b = [];

const pedirDatos = () => {
	tam = prompt("Digite el tamanio del lenguaje");
	for (let i = 0; i < tam; i++) {
		lista.push(prompt(`${(i + 1)}.- Digite la letra`));
	}
	longi = prompt("Digite la longitud del conjunto");
}

const lenguaje = (letra) =>{
    if(letra.length > longi){
        return;
    }
    let letra2 = letra;
    nuevaLista.push(letra2);
    for(let i = 0; i < tam; i++){
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

const arregloPar = () => {
    
    for (let i = 0; i < lista.length; i++) {
        a = lista[i];
        a += a;
        b.push(a);
    }
}

const palabrasPar = () => {
    let j = 0, c = 0;
    for (let i = 0; i < nuevaLista.length; i++) {
        for(let j = 0; j < b.length; j++) {
            let x = b[j];
            let y = nuevaLista[i];
            if(y.includes(x)) {
                console.log(nuevaLista[i]);
                c++;
            }
            
        }
        // if(c == 2) {
        //     console.log(nuevaLista[i]);
        // }
    }
}

pedirDatos();
bucle();
mostrar();
// arregloPar();
// palabrasPar();