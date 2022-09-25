#include <iostream>
#include <stdlib.h>

using namespace std;

struct Nodo{
	int dato;
	Nodo *siguiente;
};

void menu();
void insertarLista(Nodo *&, int);
void mostarLista(Nodo *);

Nodo *lista = NULL;

int main (){

	menu();

	cout << endl;
	system("pause");
	return 0;
}

void menu() {
	int opc = 0, dato = 0,i = 1;
	do {
		cout << "\t.:Menu:.\n";
		cout << "1. Insertar elementos a la lista\n";
		cout << "2. Mostar los elementos de la lista\n";
		cout << "3. Salir\n";
		cout << "Opcion: ";
		cin >> opc;
		cout << endl;
		switch(opc) {
			case 1:
				cout << i << ". Digite un numero: "; cin >> dato;
				insertarLista(lista, dato);
				cout << endl;
				system("pause");
				i++;
				break;
			case 2:
				mostarLista(lista);
				cout << endl;
				system("pause");
				break;
		}
		system("cls");
	}while(opc != 3);
}

void insertarLista(Nodo *&lista, int n) {
	Nodo *nuevo_nodo = new Nodo(); //Se crea nuevo nodo y se reservale en memoria de tipo Nodo()
	nuevo_nodo->dato = n; //Se le asigna el valor "n" al campo dato del nuevo_nodo
	
	Nodo *aux1 = lista;
	Nodo *aux2;
	
	while((aux1 != NULL) && (aux1->dato < n)){
		aux2 = aux1;
		aux1 = aux1->siguiente;
	}
	
	if(lista == aux1){
		lista = nuevo_nodo;
	} else{
		aux2->siguiente = nuevo_nodo;
	}
	
	nuevo_nodo->siguiente = aux1;
	
	cout << "\tElemento " << n << " insertado correctamente\n";
}

void mostarLista(Nodo *lista) {
	Nodo *actual = new Nodo();
	
	actual = lista;
	
	while(actual != NULL) {
		cout << actual->dato << " -> ";
		actual = actual->siguiente;
	}
	//cout << "NULL";
}
