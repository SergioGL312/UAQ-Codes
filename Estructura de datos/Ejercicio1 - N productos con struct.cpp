/*Hacer un programa que permita ingresar n cantidad de producto:

El programa debe mostrar los productos ingresados de manera ordenada por
su precio de menor a mayor.*/
#include <iostream>
#include <conio.h>

using namespace std;

int n = 0, MAX = 999999;

struct articulo{
	char codigo[9];
	char producto[999999];
	float precio;
};

articulo *art;

void pedirCantidad();
void pedirDatos(articulo art[]);
void mostrarProductos();
void mostrar(articulo art[]);

int main(){
	pedirCantidad();
	pedirDatos(art);
	mostrar(art);
}

void pedirCantidad() {
	cout << "Digite la cantidad de productos que va a ingresar: ";
	cin >> n;
	art = new articulo[n];
	cout << endl;
}

void pedirDatos(articulo art[]) {
	for(int i = 0; i < n; i++) {
		cout << "\t\tProducto " << (i + 1) << endl;
		fflush(stdin);
		cout << "Digite el codigo: "; cin.getline(art[i].codigo, 9, '\n');
		cout << "\nDigite el nombre del producto: "; cin.getline(art[i].producto, MAX, '\n');
		cout << "\nDigite el precio: "; cin >> art[i].precio;
	}
}

void mostrarProductos() {
	for(int i = 0; i < n; i++){
		//cout <<
	}
}

void mostrar(articulo art[]){
	cout << "\n";
	for(int i = 0; i < n; i++){
		cout << "\t\tProducto " << (i + 1) << endl;
		cout << "Codigo: " << art[i].codigo;
		cout << "\nNombre del producto: " << art[i].producto;
		cout << "\nPrecio: " << art[i].precio;
		cout << "\n";
	}
}
