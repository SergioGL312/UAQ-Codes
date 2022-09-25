#include<iostream>
#include<conio.h>

using namespace std;

int tam, *numeros, pos, aux;

void tamanio();
void llenarArreglo(int tam, int numeros[]);
void ordenacionInsercion(int tam, int numeros[]);
void ascendingSort(int tam, int numeros[]);
void descendentSort(int tam, int numeros[]);

int main(){
	
	tamanio();
	llenarArreglo(tam, numeros);
	ordenacionInsercion(tam, numeros);
	ascendingSort(tam, numeros);
	descendentSort(tam, numeros);
	
	
	getch();
	return 0;
}

void tamanio() {
	cout << "Digite el tamanio del arreglo: ";
	cin >> tam;
	cout << "\n\n";
	numeros = new int[tam];
}

void llenarArreglo(int tam, int numeros[]) {
	for(int i = 0; i < tam; i++) {
		cout << "Digite el numero en la pos [" << i << "]: ";
		cin >> numeros[i];
	}
}

void ordenacionInsercion(int tam, int numeros[]) {
	//Algoritmo del Ordenamiento por Inserción
	for(int i = 0; i < tam; i++){
		pos = i; 
		aux = numeros[i];
		
		while((pos>0) && (numeros[pos-1] > aux)){
			numeros[pos] = numeros[pos-1];
			pos--;
		}
		numeros[pos] = aux;
	}
}

void ascendingSort(int tam, int numeros[]) {
	cout << "\n\n";
	cout<<"Numeros de forma Ascendente: ";
	for(int i = 0; i < tam; i++){
		cout << numeros[i] <<" ";
	}
	cout << "\n\n";
}

void descendentSort(int tam, int array[]) {
	cout<<"\nNumeros de forma Descendente: ";
	for(int i = tam - 1; i >= 0; i--){
		cout<<array[i]<<" ";
	}
}
