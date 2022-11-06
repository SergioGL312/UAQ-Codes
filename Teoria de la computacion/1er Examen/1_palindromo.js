let word;
let tam, longi, k = 0;
let sigma = [];

const pedirDatos = () => {
	tam = prompt("Digite el tamanio del alfabeto");
    document.write(`Tamaño del alfabeto: ${tam}<br><br>`);
	for (let i = 0; i < tam; i++) {
		sigma.push(prompt(`${(i + 1)}.- Digite la letra`));
	}
    word = prompt("Digite la palabra");
    word = word.split('');
    console.log(word);
}


const palindromo = (sigma, word) => {
    for (let i = 0; i < word.length; i++) {
        if (sigma.includes(word[i])){
            k++;
        }   
    }
    let palindrome = word.reverse();
    console.log(palindrome);
    if (k == word.length && word == palindrome) {
        document.write("La palabra si tiene los simbolos del alfabeto y es un palindromo");
    } else if(k == word.length) {
        document.write("La palabra si tiene los simbolos del alfabeto pero no es un palindromo");
    } else if (word == palindrome) {
        document.write("La palabra si es un palindromo pero algun simbolo no esta en el alfabeto");
    }


}

pedirDatos();
palindromo(sigma, word);
