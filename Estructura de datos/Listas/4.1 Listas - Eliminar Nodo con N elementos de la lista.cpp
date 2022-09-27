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
void buscarLista(Nodo *, int);
void eliminarNodo(Nodo *&, int);

Nodo *lista = NULL;

int main (){

	menu();

	cout << endl;
	system("pause");
	return 0;
}

void menu() {
	int opc = 0, dato = 0, cant = 0;
	do {
		cout << "\t.:Menu:.\n";
		cout << "1. Insertar elementos a la lista\n";
		cout << "2. Mostar los elementos de la lista\n";
		cout << "3. Buscar elemento en la lista\n";
		cout << "4. Eliminar un elemento de la lista\n";
		cout << "5. Salir\n";
		cout << "Opcion: ";
		cin >> opc;
		cout << endl;
		switch(opc) {
			case 1:
				cout << "Digite la cantidad de numeros: "; cin >> cant;
				for(int i = 0; i < cant; i++) {
					cout << i << ". Digite un numero: "; cin >> dato;
					insertarLista(lista, dato);
					cout << endl;
				}
				system("pause");
				break;
			case 2:
				mostarLista(lista);
				cout << endl << endl;
				system("pause");
				break;
			case 3:
				cout << "\nDigite un numero a buscar: ";
				cin >> dato;
				buscarLista(lista, dato);
				cout << endl;
				system("pause");
				break;
			case 4:
				cout << "\nDigite el numero a borrar: ";
				cin >> dato;
				eliminarNodo(lista, dato);
				cout << endl;
				system("pause");
				break;
		}
		system("cls");
	}while(opc != 5);
}

void insertarLista(Nodo *&lista, int n) {
	Nodo *nuevo_nodo = new Nodo(); 
	nuevo_nodo->dato = n; 
	
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

void buscarLista(Nodo *lista, int n){
	bool band = false;
	
	
	Nodo *actual = new Nodo();
	actual = lista;
	
	while((actual != NULL) && actual->dato <= n){
		if(actual->dato == n){
			band = true;
		}
		actual = actual->siguiente;
		
	}
	
	if(band == true){
		cout << "\nElemento " << n << " SI ha sido encontrado en la lista\n";
	} else {
		cout << "\nElemento " << n << " NO ha sido encontrado en la lista\n";
	}
}

void eliminarNodo(Nodo *&lista, int n) {
	if(lista != NULL){ 
		Nodo *aux_borrar;
		Nodo *anterior = NULL;
		
		aux_borrar = lista;
		
		while((aux_borrar != NULL) && (aux_borrar->dato != n)){
			anterior = aux_borrar;
			aux_borrar = aux_borrar->siguiente;
		}
		
		if(aux_borrar == NULL) { 
			cout << "\nEl num NO ha sido encontrado\n";
		} else if(anterior == NULL) { 
			lista = lista->siguiente;
			delete aux_borrar;
			cout << n << " ha sido borrado exitosamente\n";
		} else {
			anterior->siguiente = aux_borrar->siguiente;
			delete aux_borrar;
			cout << n << " ha sido borrado exitosamente\n";
		}
	}
}
