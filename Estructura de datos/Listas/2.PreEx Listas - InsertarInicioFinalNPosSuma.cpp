// Hacer un programa que permita ingresar al inicio, al final, y en posición y
//permita calcular la suma de la lista.
#include <iostream>
#include <stdlib.h>

using namespace std;

struct Nodo{
	int dato;
	Nodo *siguiente;
};

void menu();
int pedirValor(int);
void insertarInicio(Nodo *&, int);
void insertarFinal(Nodo *&, int);
void insertarNPos(Nodo *&, Nodo *, int);
void mostrarLista(Nodo *);
Nodo *buscarLista(Nodo *lista, int valor);
int sumaElemento(Nodo *&);

int main() {
	
	menu();

	system("pause");
	return 0;
}

void menu() {
	int opc = 0;
	int valor = 0;
	int i = 0;
	int buscar = 0;
	int pos = 0;
	int suma = 0;
	Nodo *lista = NULL;
	
	do {
		cout << "1. Inicio\n";
		cout << "2. Final\n";
		cout << "3. N Posicion\n";
		cout << "4. Mostrar Lista y suma\n";
		cout << "0. Salir\n";
		cout << "\nElija una opc > ";
		cin >> opc;
		cout << endl;
		switch (opc) {
			case 0:
				break;
			case 1:
				valor = pedirValor(i);
				insertarInicio(lista, valor);	
				i++;
				system("pause");
				system("cls");
				break;
			case 2:
				valor = pedirValor(i);
				insertarFinal(lista, valor);
				i++;
				system("pause");
				system("cls");
				break;
			case 3:
				mostrarLista(lista);
				cout << "\nDigite el num a buscar > ";
				cin >> buscar;
				Nodo *anterior;
				anterior = buscarLista(lista, buscar);
				cout << "\nDigite el num a guardar > ";
				cin >> valor;
				insertarNPos(lista, anterior, valor);
				system("pause");
				system("cls");
				break;
			case 4:
				mostrarLista(lista);
				suma = sumaElemento(lista);
				cout << "\n\n[+]Resultado de la suma de los numeros: " << suma << "\n";
				cout << endl;
				system("pause");
				system("cls");
				break;
			default:
				cout << "Digito una opc incorrecta\n\n";
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

void insertarInicio(Nodo *&lista, int valor) {
	Nodo *nuevo_nodo = new Nodo();
	nuevo_nodo->dato = valor;
	Nodo *aux1 = lista;
	
	lista = nuevo_nodo;
	nuevo_nodo->siguiente = aux1;
	
	cout << "\t[+]Elemento " << valor << " insertado correctamente\n";
}

void insertarFinal(Nodo *&lista, int valor) {	
	Nodo *nuevo_nodo = new Nodo();
	Nodo *aux;
	
	nuevo_nodo->dato = valor;
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
	cout<<"\t[+]Elemento "<< valor <<" agregado a lista correctamente\n";
}

void insertarNPos(Nodo *&lista, Nodo *anterior, int valor) {
	Nodo *actual = new Nodo();
	actual = lista;
	
	while((actual != NULL)){
		if(anterior == actual){
			Nodo *nuevo_nodo = new Nodo();
			nuevo_nodo->dato = valor;
			nuevo_nodo->siguiente = anterior->siguiente;
			anterior->siguiente = nuevo_nodo;
			cout<<"\t[+]Elemento "<< valor <<" agregado a lista correctamente\n";
			break;
		}
		actual = actual->siguiente;
	}
}

void mostrarLista(Nodo *lista) {
	Nodo *actual = new Nodo();
	
	actual = lista;
	
	cout << "\t[+]Elementos de la lista\n";
	cout << "\t";
	while(actual != NULL) {
		cout << actual->dato << " -> ";
		actual = actual->siguiente;
	}
	cout << endl;
}

Nodo *buscarLista(Nodo *lista, int valor){
	bool band = false;
	int pos = 0;
	
	Nodo *actual = new Nodo();
	actual = lista;
	
	while((actual != NULL)){
		pos++;
		if(actual->dato == valor){
			band = true;
			break;
		}
		actual = actual->siguiente;
	}
	
	if(band == true){
		cout << "\nElemento " << valor << " SI ha sido encontrado en la lista en la pos " << pos << "\n";
		return actual;
	} else {
		cout << "\nElemento " << valor << " NO ha sido encontrado en la lista en la pos " << pos << "\n";
		return actual;
	}
}

int sumaElemento(Nodo *&lista) {
	Nodo *actual = new Nodo();
	int sum = 0;
	actual = lista;
	
	while(actual != NULL) {
		sum += actual->dato;
		actual = actual->siguiente;
	}
	return sum;
}
