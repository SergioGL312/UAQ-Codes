// Hacer un programa que permita ingresar dos listas, el programa debe
// mostrar las dos listas, intercalar las dos listas en una tercera lista, y debe
// calcular la resta de ambas listas y el resultado mostrarlo en una tercera lista.
#include <iostream>
#include <stdlib.h>

using namespace std;

struct Nodo {
	int dato;
	Nodo *siguiente;
};

void menu();
void InserOpcLista();
int pedirValor(int);
void insertarLista(Nodo *&, int);
void mostarLista(Nodo *);
Nodo *unir(Nodo *&, Nodo *&);
void restaElementos(Nodo *&lista);

int valor = 0;
Nodo *lista1 = NULL;	
Nodo *lista2 = NULL;



int main() {
	
	menu();
	
	system("pause");
	return 0;
}

void menu() {
	int opc = 0;
	
	do {
		cout << "\t.:Menu:.\n";
		cout << "1. Insertar datos\n";
		cout << "2. Mostrar lista\n";
		cout << "3. Unir listas y resta\n> ";
		cin >> opc;
		system("cls");
		switch(opc) {
			case 0:
				break;
			case 1:
				InserOpcLista();
				break;
			case 2:
				cout << "\nLista 1\n\t";
				mostarLista(lista1);
				cout << "\nLista 2\n\t";
				mostarLista(lista2);
				cout << endl;
				break;
			case 3:
				Nodo *lista3;
				lista3 = unir(lista1, lista2);
				mostarLista(lista3);
				cout << endl;
				restaElementos(lista3);
				break;
		}
		system("pause");
		system("cls");
	} while(opc != 0);
}

void InserOpcLista() {
	int opcLista = 0;
	
	int i = 0;
	
	cout << "1. 1er lista\n";
	cout << "2. 2da lista\n> ";
	cin >> opcLista;
	
	switch(opcLista) {
		case 1:
			valor = pedirValor(i);
			insertarLista(lista1, valor);
			i++;
			mostarLista(lista1);
			cout << endl;
			break;
		case 2:
			valor = pedirValor(i);
			insertarLista(lista2, valor);
			i++;
			mostarLista(lista2);
			cout << endl;
			break;
	}
}

int pedirValor(int i) {
	//int valor = 0;
	cout << (i + 1) <<". Digite el valor > ";
	cin >> valor;
	return valor;
}

void insertarLista(Nodo *&lista, int n) {
	Nodo *nuevo_nodo = new Nodo();
	Nodo *aux;
	
	nuevo_nodo->dato = n;
	nuevo_nodo->siguiente = NULL;
	
	if(lista == NULL){
		lista = nuevo_nodo;
	} else{
		aux = lista;
		while(aux->siguiente != NULL){
			aux = aux->siguiente;
		}
		aux->siguiente = nuevo_nodo;
	}
	cout<<"\t[+]Elemento "<< n <<" agregado a lista correctamente\n";
}

void mostarLista(Nodo *lista) {
	Nodo *actual = new Nodo();
	actual = lista;
	
	while(actual != NULL) {
		cout << actual->dato << " -> ";
		actual = actual->siguiente;
	}
}

Nodo *unir(Nodo *&lista1, Nodo *&lista2) {
	Nodo *imaginario = new Nodo();
	Nodo *aux1 = lista1;
	Nodo *aux2 = lista2;
	Nodo *aux3 = imaginario;
	
	while(aux1 != NULL) {
		aux3->siguiente = aux1;
		aux1 = aux1->siguiente;
		aux3 = aux3->siguiente;
	}
	
	while(aux2 != NULL) {
		aux3->siguiente = aux2;
		aux2 = aux2->siguiente;
		aux3 = aux3->siguiente;
	}
	
	return imaginario->siguiente;
}

void restaElementos(Nodo *&lista) {
	Nodo *actual = new Nodo();
	int tot = 0;
	
	actual = lista;
	
	while(actual != NULL) {
		tot = actual->dato - tot;
		actual = actual->siguiente;
	}
	cout << "\n\n[+]Resultado de la resta de los numeros: " << tot << "\n";
	cout << endl;
}
