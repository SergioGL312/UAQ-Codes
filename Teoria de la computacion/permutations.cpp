/*
Programa debe de preguntar los signos del alfabeto y cant

Genere palabras de cualquier longitud 

Ejemplo: desde 0 - 3

y un do-while
*/
#include <iostream>
#include <stdlib.h>

using namespace std;

void pedirTamanio();
void pedirDatosAlfabeto(int tam, char array[]);
void imprimir(int tam, char array[]);
void longitud();
void intercambio(char *a, char *b);
void permutaciones(char array[], int start, int tam);
void imprimir(int tam, char array[]);

int tam, count, longi;
char *array;

int main(){
	pedirTamanio();
	pedirDatosAlfabeto(tam, array);
	longitud();
	
	system("pause");
}

void pedirTamanio() {
	cout << "Digite el tamnio del alfabeto: ";
	cin >> tam;
	array = new char[tam];
}

void pedirDatosAlfabeto(int tam, char array[]) {
	for(int i = 0; i < tam; i++) {
		cout << (i + 1) << ".- Digite el caracter: ";
		cin >> array[i];
	}
}

void longitud() {
	cout << "Digite la longitud del conjunto: ";
	cin >> longi;
	
	if(longi < 1) {
		cout << "^";
	} else if(longi == 1){
		imprimir(tam, array);
	} else {
//		permutaciones(array, 0, tam);
	}
}

void intercambio(char *a, char *b){
	char temp = *a;
	*a = *b;
	*b = temp;
}

//void permutaciones(char array[], int start, int tam){
//    if(start == (tam - 1)){
//        cout <<"\t\t" << array << endl;
//        count++;
//    }else{
//        for(int i = start; i <= (log - 1); i++){
//            intercambio(&array[start], &array[i]);
//            permutaciones(array,start + 1, tam);
//        }
//    }
//}

void imprimir(int tam, char array[]) {
	for(int i = 0; i < tam; i++) {
		cout << array[i] << "\n";
	}
}
