//1-	Haciendo uso de listas enlazadas, crearemos un programa que permita insertar 
//elementos al inicio, eliminar elemento inicial, eliminar elemento final y por 
//último eliminar todos los elementos de una lista. El programa también nos 
//mostrará los elementos pares e impares de una lista.
#include <iostream>
#include <stdlib.h>

using namespace std;

struct Nodo{
	int valor;
	Nodo *siguiente;
};

void menu();
int pedirValor(int i);
void insertarElemento(Nodo *&, int);
void eliminarInicial(Nodo *&);
void eliminarFinal(Nodo*&);
void eliminarTodos(Nodo *&);
void mostrarLista(Nodo *);
void paresLista(Nodo *);

int i = 0;
Nodo *lista = NULL;

int main() {
	
	menu();
		
	return 0;
}

void menu() {
	int opc = 0;
	int valor = 0;
	do {
		cout << "\t.:Menu:.\n";
		cout << "1. Insertar elemento\n";
		cout << "2. Eliminar el primero\n";
		cout << "3. Eliminar el ultimo\n";
		cout << "4. Eliminar todos los elementos\n";
		cout << "5. Mostrar lista y pares\n";
		cout << "0. Salir del programa\n> ";
		cin >> opc;
		cout << endl;
		switch (opc) {
			case 0:
				break;
			case 1:
				valor = pedirValor(i);
				insertarElemento(lista, valor);
				i++;
				mostrarLista(lista);
				cout << endl;
				system("pause");
				system("cls");
				break;
			case 2:
				cout << "\tAntes:\n";
				mostrarLista(lista);
				eliminarInicial(lista);
				cout << "\t\nDespues:\n\n";
				mostrarLista(lista);
				cout << endl;
				system("pause");
				system("cls");
				break;
			case 3:
				cout << "\tAntes:\n";
				mostrarLista(lista);
				eliminarFinal(lista);
				cout << "\t\nDespues:\n\n";
				mostrarLista(lista);
				cout << endl;
				system("pause");
				system("cls");
				break;
			case 4:
				cout << "\tAntes:\n";
				mostrarLista(lista);
				while (lista != NULL) {
					eliminarTodos(lista);	
				}
				cout << "\t\nDespues:\n\n";
				mostrarLista(lista);
				cout << endl;
				system("pause");
				system("cls");
				break;
			case 5:
				mostrarLista(lista);
				paresLista(lista);
				cout << endl;
				system("pause");
				system("cls");
				break;
		}
	} while(opc != 0);
}

int pedirValor(int i) {
	int valor = 0;
	cout << (i + 1) <<". Digite el valor > ";
	cin >> valor;
	return valor;
}

void insertarElemento(Nodo *&lista, int n) {
	Nodo *nuevo_nodo = new Nodo();
	nuevo_nodo->valor = n;
	Nodo *aux1 = lista;
	
	lista = nuevo_nodo;
	nuevo_nodo->siguiente = aux1;
	
	cout << "\t[+]Elemento " << n << " insertado correctamente\n";
}

void eliminarInicial(Nodo *&lista) {
    Nodo* aux = lista;
    lista = lista->siguiente;
    delete aux;
}

void eliminarFinal(Nodo *&lista) {
	Nodo* aux = lista;
    Nodo* anterior = lista;
    while (aux->siguiente)
    {
        anterior = aux;
        aux = aux->siguiente;
    }
    anterior->siguiente = NULL;
    delete aux;
}


void eliminarTodos(Nodo *&lista) {
	Nodo *aux = lista;
	lista = aux->siguiente;
	delete aux;
}

void mostrarLista(Nodo *lista) {
	Nodo *actual = new Nodo();
	actual = lista;
	
	while(actual != NULL) {
		cout << actual->valor << " -> ";
		actual = actual->siguiente;
	}
}

void paresLista(Nodo *) {
	Nodo *actual = new Nodo();
	actual = lista;
	
	cout << "\t\n\nElementos pares de la lista: \n";
	while(actual != NULL) {
		if (actual->valor % 2 == 0) {
			cout << actual->valor << " -> ";
		}	
		actual = actual->siguiente;
	}
}
