/* Escribir un programa que llene un arreglo con los números enteros
comprendidos entre 4 y 14. */
#include <iostream>
#include <stdlib.h>

using namespace std;

int tam = 0, *array;

void tamanio();
void llenarArreglo(int tam, int *a);
void mostrarArreglo(int tam, int *a);

int main() {
	
	tamanio();
	llenarArreglo(tam, array);
	mostrarArreglo(tam, array);
	
	system("pause");
	return 0;
}

void tamanio() {
	cout << "Digite el tamanio del arreglo: ";
	cin >> tam;
	cout << "\n";
	
	array = new int[tam];
}

void llenarArreglo(int tam, int *a) {
	for(int i = 0; i < tam; i++) {
		*(array + i) = 4 + (rand() % 10);
	}
}

void mostrarArreglo(int tam, int *a) {
	for(int i = 0; i < tam; i++) {
		cout << *(a + i) << " ";
	}
	cout << "\n\n";
}
