// Hacer un programa que permita multiplicar los elementos de una lista.
#include <iostream>
#include <stdlib.h>

using namespace std;

struct Lista{
	int valor;
	Lista *siguiente;
};

void insertarElemento(Lista *&, int);
void mostarLista(Lista *&);
void multiplicacionElementos(Lista *&);

int main() {
	Lista *lista = NULL;
	int valor = 0;
	int tamLista = 0;
	int i = 0;
	int opc = 0;
	
	cout << "Digite el tamaño de la lista > ";
	cin >> tamLista;
	cout << endl;
	
	do {
		cout << (i + 1) <<". Digite el valor > ";
		cin >> valor;
		insertarElemento(lista, valor);
		i++;
	} while(i != tamLista);
	cout << "\n[+] Elementos insertado correctamente\n";

	multiplicacionElementos(lista);
	
	system("pause");
	return 0;
}

void insertarElemento(Lista *&lista, int valor) {
	Lista *nuevoNodo = new Lista();
	nuevoNodo->valor = valor;
	
	Lista *aux1 = lista;
	Lista *aux2;
	
	while((aux1 != NULL) && (aux1->valor < valor)) {
		aux2 = aux1;
		aux1 = aux1->siguiente;
	}
	
	if(lista == aux1) {
		lista = nuevoNodo;
	} else {
		aux2->siguiente = nuevoNodo;
	}
	
	nuevoNodo->siguiente = aux1;
}

void multiplicacionElementos(Lista *&lista) {
	Lista *actual = new Lista();
	int tot = 1;
	
	
	actual = lista;
	
	while(actual != NULL) {
		tot *= actual->valor;		
		actual = actual->siguiente;
	}
	cout << "\n\n[+]Resultado de la mutiplicacion de los numeros: " << tot << "\n";
	cout << endl;
}
