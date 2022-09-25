#include<iostream>
#include<conio.h>

using namespace std;

int tam = 0, *array, i, j, aux;

void tamanio();
void llenarArreglo(int tam, int *array);
void bubbleSort(int tam, int *array);
void ascendingSort(int tam, int *array);
void descendentSort(int tam, int *array);


int main(){
		
	tamanio();
	llenarArreglo(tam, array);
	bubbleSort(tam, array);
	ascendingSort(tam, array);
	descendentSort(tam, array);

	getch();
	return 0;
}

void tamanio() {
	cout << "Digite el tamanio del arreglo: ";
	cin >> tam;
	cout << "\n\n";
	array = new int[tam];
}

void llenarArreglo(int tam, int *array) {
	for(int i = 0; i < tam; i++) {
		cout << "Digite el numero en la pos [" << i << "]: ";
		cin >> *(array + i);
	}
}

void bubbleSort(int tam, int *array) {
	for(i = 0; i < tam; i++){
		for(j = 0; j < tam - 1 ; j++){
			if(*(array + j) > *(array + j + 1)){
				aux = *(array + j);
				*(array + j) = *(array + j + 1);
				*(array + j + 1) = aux;
			}
		}
	}
}

void ascendingSort(int tam, int *array) {
	cout << "\n\n";
	cout<<"Numeros de forma Ascendente: ";
	for(i = 0; i < tam; i++){
		cout << *(array + i) <<" ";
	}
	cout << "\n\n";
}

void descendentSort(int tam, int *array) {
	cout<<"\nNumeros de forma Descendente: ";
	for(i = tam - 1; i >= 0; i--){
		cout<<*(array + i)<<" ";
	}
}
