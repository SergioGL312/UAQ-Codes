#include <iostream>
#include <conio.h>
#include <stdlib.h>
#include <cstring>

using namespace std;

int n = 0;

struct conjunto{
	char letra[2];
};

conjunto *letras;
conjunto aux;

void pedirDatos();
void pedirLetras(conjunto letras[]);
void bubbleSort(conjunto letras[]);
void ascendingSort(conjunto letras[]);

int main(){
	
	pedirDatos();
	pedirLetras(letras);
	bubbleSort(letras);
	ascendingSort(letras);
	
	system("pause");
	return 0;
}

void pedirDatos() {
	cout << "Digite la cantidad de letras: "; 
	cin >> n;
	letras = new conjunto[n];
}

void pedirLetras(conjunto letras[]) {
	for(int i = 0; i < n; i++){
		fflush(stdin);
		cout << "Digite la letra: ";
		cin.getline(letras[i].letra, 2, '\n');

	}
}

void bubbleSort(conjunto letras[]) {
	for(int i = 0; i < n; i++){
		for(int j = i + 1; j < n; j++){
			if((strcoll(letras[i].letra, letras[j].letra)) > 0) {
                strcpy(aux.letra, letras[i].letra );
                strcpy(letras[i].letra, letras[j].letra );
                strcpy(letras[j].letra, aux.letra );
            }
		}
	}
}

void ascendingSort(conjunto letras[]) {
	cout << "\n\n";
	cout<<"Numeros de forma Ascendente: ";
	for(int i = 0; i < n; i++){
		cout << letras[i].letra <<" ";
	}
	cout << "\n\n";
}
