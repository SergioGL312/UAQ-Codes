let w;
let tam, longi, k = 0;
let sigma = [];

const pedirDatos = () => {
	tam = prompt("Digite el tamanio del alfabeto");
    document.write(`Tamaño del alfabeto: ${tam}<br><br>`);
	for (let i = 0; i < tam; i++) {
		sigma.push(prompt(`${(i + 1)}.- Digite la letra`));
	}
    w = prompt("Digite la palabra");
    w = w.split('');
    console.log(w);
}


const palindromo = (sigma, w) => {
    for (let i = 0; i < sigma.length; i++) {
        let elemento = sigma[i];
        if (w.includes(elemento)){
            k++;
        }   
    }
    let p = w.reverse();
    console.log(p);
    if (k == w.length && w == p) {
        document.write("La palabra si tiene los simbolos del alfabeto y es un palindromo");
    }
    if(k == w.length) {
        document.write("La palabra si tiene los simbolos del alfabeto pero no es un palindromo");
    }
    if (w == p) {
        document.write("La palabra si es un palindromo pero algun simbolo no esta en el alfabeto");
    }


}

pedirDatos();
palindromo(sigma, w);
