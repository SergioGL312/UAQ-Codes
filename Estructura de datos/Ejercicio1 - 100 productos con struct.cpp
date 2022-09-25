/*Hacer un programa que permita ingresar n cantidad de producto:

El programa debe mostrar los productos ingresados de manera ordenada por
su precio de menor a mayor.*/
#include <iostream>
#include <conio.h>

using namespace std;

int n = 0, MAX = 999, pos, aux;

struct articulo{
	char codigo[9];
	char producto[999];
	float precio;
}art[100];

void pedirCantidad();
void pedirDatos();
void mostrarProductosOrdena();
void ordenacionInsercion();

int main(){
	pedirCantidad();
	pedirDatos();
	ordenacionInsercion();
	mostrarProductosOrdena();
}

void pedirCantidad() {
	cout << "Digite la cantidad de productos que va a ingresar: ";
	cin >> n;
	cout << endl;
}

void pedirDatos() {
	for(int i = 0; i < n; i++) {
		cout << "\t\tProducto " << (i + 1) << endl;
		fflush(stdin);
		cout << "Digite el codigo: "; cin.getline(art[i].codigo, 9, '\n');
		cout << "Digite el nombre del producto: "; cin.getline(art[i].producto, MAX, '\n');
		cout << "Digite el precio: "; cin >> art[i].precio;
		cout << endl;
	}
}

void ordenacionInsercion() {
	//Algoritmo del Ordenamiento por Inserción
	cout << "\n\nProductos ordenados por precio\n";
	for(int i = 0; i < n; i++){
		pos = i; 
		aux = art[i].precio;
		
		while((pos>0) && (art[pos-1].precio > aux)){
			art[pos].precio = art[pos-1].precio;
			pos--;
		}
		art[pos].precio = aux;
	}
}

void mostrarProductosOrdena(){
	cout << "\n";
	for(int i = 0; i < n; i++){
		cout << "\t\tProducto " << (i + 1) << endl;
		cout << "Codigo: " << art[i].codigo;
		cout << "\nNombre del producto: " << art[i].producto;
		cout << "\nPrecio: " << art[i].precio;
		cout << "\n";
	}
}

