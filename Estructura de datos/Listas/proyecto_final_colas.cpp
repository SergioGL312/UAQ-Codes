// Elaborar un programa que permita ingresar un conjunto de clientes de un supermercado,
// para generar una lista de espera para realizar el pago de sus compras.
// El programa debe evaluar si el primer cliente posee dinero suficiente
// para abonar los productos que desea comprar. En caso de ser así debe
// removerse el cliente de la fila.
// En caso de presentarse un cliente que no posee dinero suficiente,
// se remueve de la fila. Al  final el  programa retornará un array
// con los nombres de los clientes que fueron correctamente retirados.
// El programa solicitará el nombre, dinero disponible y precio total a pagar.

//Si les alcanzo 
#include <iostream>
#include <conio.h>
#include <stdlib.h>
#include <windows.h>

using namespace std;

struct Cliente{
	char nombre[30];
	double dinero;
	int pagar;
};

struct Nodo{
	Cliente c;
	Nodo *siguiente;	
};

void menu();
void pedirDatos(Cliente &);
void insertarCola(Nodo *&frente, Nodo *&fin, Cliente c);
bool cola_vacia(Nodo *frente);
void suprimirCola(Nodo *&frente, Nodo *&fin, Cliente &c);

HANDLE h = GetStdHandle(STD_OUTPUT_HANDLE);

int main() {
	
	menu();
}

void menu() {
	Nodo *frente = NULL;
	Nodo *fin = NULL;
	Cliente c;
	int opc = 0;
	
	do{
		cout << "\n\t\t.:Menu:.\n\n";
		cout << "\t1. Registrar Cliente\n";
		cout << "\t2. Borrar cola\n";
		cout << "\t3. Mostrar\n";
		cout << "\t4. Salir\n";
		cout << "\t > ";
		cin >> opc;
		
		switch(opc) {
			case 1:
				pedirDatos(c);
				insertarCola(frente, fin, c);
				system("pause");
				break;
			case 2:
				while(frente != NULL){
					suprimirCola(frente, fin, c);
				}
				break;
			case 3:
				while(frente != NULL){
					suprimirCola(frente, fin, c);
					SetConsoleTextAttribute(h, 14);
					cout << "\nNombre: " << c.nombre << endl;
					cout << "Dinero: " << c.dinero << endl;
					cout << "Pagar: " << c.pagar << endl;
					SetConsoleTextAttribute(h, 7);
					cout << endl;
				}
				system("pause");
				break;
		}
		system("cls");
	} while(opc != 4);
}

void pedirDatos(Cliente &c){
	fflush(stdin);
	cout << "\nDigite su nombre > ";
	cin.getline(c.nombre, 30, '\n');
	cout << "Digite la cantidad de dinero > ";
	cin >> c.dinero;
	cout << "Digite la cantidad a pagar > ";
	cin >> c.pagar;
	cout << "\n";
}

void insertarCola(Nodo *&frente, Nodo *&fin, Cliente c) {
	Nodo *nuevo_nodo = new Nodo();
	
	
	
	if (c.dinero >= c.pagar) {
		SetConsoleTextAttribute(h, 10);
		cout << "Suficiente dinero\n" << endl;
		SetConsoleTextAttribute(h, 7);
	} else {
		SetConsoleTextAttribute(h, 4);
		cout << "No tiene suficiente dinero\n" << endl;
		SetConsoleTextAttribute(h, 7);
		nuevo_nodo->c = c;
		nuevo_nodo->siguiente = NULL;
		if(cola_vacia(frente)){
			frente = nuevo_nodo;
		}
		else{
			fin->siguiente = nuevo_nodo;
		}
	}
	
	fin = nuevo_nodo;
}

bool cola_vacia(Nodo *frente){
	return (frente == NULL) ? true : false; 
}

void suprimirCola(Nodo *&frente, Nodo *&fin, Cliente &c){
	c = frente->c;
	Nodo *aux = frente;
	
	if(frente == fin){
		frente = NULL;
		fin = NULL;
	}
	else{
		frente = frente->siguiente;
	}
	delete aux;
}
