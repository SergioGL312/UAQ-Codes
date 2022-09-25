
//Ordenamiento por Selecci?n

#include<iostream>
#include<conio.h>

using namespace std;

//int tam = 0, *array;
int *array;

/*
int tamanio();
void llenarArreglo(int tam, int array[]);
void ordenacionSeleccion(int tam, int array[]);
void ascendingSort(int tam, int array[]);
void descendentSort(int tam, int array[]);*/

int tamanio() {
	int tam = 0;
	cout << "Digite el tamanio del arreglo: ";
	cin >> tam;
	cout << "\n\n";
	array = new int[tam];
	return tam;
}

void llenarArreglo(int tam, int array[]) {
	for(int i = 0; i < tam; i++) {
		cout << "Digite el numero en la pos [" << i << "]: ";
		cin >> array[i];
	}
}

void ordenacionSeleccion(int tam, int array[]) {
	//Algoritmo del Ordenamiento por Selecci?n
	int aux = 0, min = 0;
	for(int i = 0; i < tam; i++){
		min = i;
		for(int j = i + 1; j < tam; j++){
			if(array[j] < array[min]){
				min = j;
			}
		}
		aux = array[i];
		array[i] = array[min];
		array[min] = aux;
	}
}

void ascendingSort(int tam, int array[]) {
	cout << "\n\n";
	cout<<"Numeros de forma Ascendente: ";
	for(int i = 0; i < tam; i++){
		cout << array[i] <<" ";
	}
	cout << "\n\n";
}

void descendentSort(int tam, int array[]) {
	cout<<"\nNumeros de forma Descendente: ";
	for(int i = tam - 1; i >= 0; i--){
		cout<<array[i]<<" ";
	}
}

int main(){

	int tam;
	tam = tamanio();
	llenarArreglo(tam, array);
	ordenacionSeleccion(tam, array);
	ascendingSort(tam, array);
	descendentSort(tam, array);	
	getch();
	return 0;
}


