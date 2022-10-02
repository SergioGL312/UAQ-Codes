#include <iostream>
#include <stdlib.h>
#include <conio.h>
#include <string>
#include <windows.h>

using namespace std;

struct Paciente{
	int id;
	string nombre;
	string apellido;
	int edad;
	string enfermedad;
	Paciente *siguiente;
};

Paciente *lista = NULL;
HANDLE h = GetStdHandle(STD_OUTPUT_HANDLE);


void menu();
void registrarPaciente(Paciente *&, int, string, string, int, string);
void mostarPacientes(Paciente *);
void eliminarPaciente(Paciente *&, int);
void actualizarPaciente(Paciente *&, int);
void buscarPaciente(Paciente *&, int);

int main (){

	menu();
	cout << "\nPresione otra vez una tecla para salir . . .\n";
	getch();
	return 0;
}

void menu() {
	int opc = 0, i = 1, edad = 0, id = 0;
	string nombre;
	string apellido;
	string enfermedad;
	
	do {
		cout << "\n\t\t.:Menu:.\n\n";
		cout << "\t1. Registrar paciente\n";
		cout << "\t2. Eliminar un paciente\n";
		cout << "\t3. Actualizar datos de un paciente\n";
		cout << "\t4. Mostar los pacientes\n";
		cout << "\t5. Buscar paciente por ID\n";
		cout << "\t6. Salir\n\n";
		cout << "Opcion: ";
		cin >> opc;
		cout << endl;
		switch(opc) {
			case 1:
				cout << i << ". Digite su nombre: "; cin >> nombre;
				cout << i << ". Digite su apellido: "; cin >> apellido;
				cout << i << ". Digite su edad: "; cin >> edad;
				cout << i << ". Digite su enfermedad: "; cin >> enfermedad;
				registrarPaciente(lista, i, nombre, apellido, edad, enfermedad);
				cout << endl;
				system("pause");
				i++;
				break;
			case 2:
				mostarPacientes(lista);
				cout << "Digite el ID del paciente a borrar: "; cin >> id;
				cout << endl;
				eliminarPaciente(lista, id);
				cout << endl;
				system("pause");
				break;
			case 3:
				mostarPacientes(lista);
				cout << "Digite el ID del paciente a actualizar: "; cin >> id;
				actualizarPaciente(lista, id);
				cout << endl;
				system("pause");
				break;
			case 4:
				mostarPacientes(lista);
				cout << endl;
				system("pause");
				break;
			case 5:
				cout << "Digite el ID del paciente a buscar: "; cin >> id;
				cout << endl;
				buscarPaciente(lista, id);
				cout << endl;
				system("pause");
				break;
		}
		system("cls");
	}while(opc != 6);
}

void registrarPaciente(Paciente *&lista, int id, string nomb, string apell, int eda, string enfer) {
	Paciente *nuevo_Paciente = new Paciente();
	Paciente *aux;
	
	nuevo_Paciente->id = id;
	nuevo_Paciente->nombre = nomb;
	nuevo_Paciente->apellido = apell;
	nuevo_Paciente->edad = eda;
	nuevo_Paciente->enfermedad = enfer;
	nuevo_Paciente->siguiente = NULL;
	
	if(lista == NULL){//Si la lista esta vacia
		lista = nuevo_Paciente;//agregamos el primer Paciente
	}
	else{
		aux = lista;
		while(aux->siguiente != NULL){//recorremos la lista hasta llegar al final
			aux = aux->siguiente;
		}
		aux->siguiente = nuevo_Paciente;//agregamos el nuevo Paciente al final de la lista
	}
	SetConsoleTextAttribute(h, 10);
	cout<<"\n\tPaciente agregado a lista correctamente\n";
	SetConsoleTextAttribute(h, 7);
}

void eliminarPaciente(Paciente *&lista, int id) {
	if(lista != NULL){ 
		Paciente *aux_borrar;
		Paciente *anterior = NULL;
		
		aux_borrar = lista;
		
		while((aux_borrar != NULL) && (aux_borrar->id != id)){
			anterior = aux_borrar;
			aux_borrar = aux_borrar->siguiente;
		}
		
		if(aux_borrar == NULL) {
			SetConsoleTextAttribute(h, 4);
			cout << "\tEl paciente NO ha sido encontrado\n";
			SetConsoleTextAttribute(h, 7);
		} else if(anterior == NULL) { 
			lista = lista->siguiente;
			delete aux_borrar;
			SetConsoleTextAttribute(h, 10);
			cout << "\tBorrado exitosamente\n";
			SetConsoleTextAttribute(h, 7);
		} else {
			anterior->siguiente = aux_borrar->siguiente;
			delete aux_borrar;
			SetConsoleTextAttribute(h, 10);
			cout << "\tBorrado exitosamente\n";
			SetConsoleTextAttribute(h, 7);		
		}
	}
}

void actualizarPaciente(Paciente *&lista, int id) {
	int edad = 0;
	string nombre;
	string apellido;
	string enfermedad;
	
	if(lista != NULL) {
		Paciente *aux_actualizar = new Paciente();
		Paciente *anterior = NULL;
		aux_actualizar = lista;
		while(aux_actualizar != NULL) {
			if(aux_actualizar->id == id) {
				cout << "\nDigite su nombre: "; cin >> aux_actualizar->nombre;//aux_actualizar->nombre = nombre;
				cout << "Digite su apellido: "; cin >> aux_actualizar->apellido;//aux_actualizar->apellido = apellido;
				cout << "Digite su edad: "; cin >> aux_actualizar->edad;//aux_actualizar->edad = edad;
				cout << "Digite su enfermedad: "; cin >> aux_actualizar->enfermedad;//aux_actualizar->enfermedad = enfermedad;
				cout << endl;
				SetConsoleTextAttribute(h, 10);
				cout << "\tPaciente actualizado exitosamente!!\n\n";
				SetConsoleTextAttribute(h, 7);
				mostarPacientes(lista);
				break;
			}
			anterior = aux_actualizar;
			aux_actualizar = aux_actualizar->siguiente;
		}
		if(aux_actualizar == NULL) { 
			SetConsoleTextAttribute(h, 4);
			cout << "\n\tEl paciente NO ha sido encontrado\n";
			SetConsoleTextAttribute(h, 7);
		} 
	}
	
}

void buscarPaciente(Paciente *&lista, int id) {
	Paciente *actual = new Paciente();
	Paciente *anterior = NULL;
	actual = lista;
	while(actual != NULL) {
		if(actual->id == id) {
			cout << "ID: " << actual->id << "\n";
			cout << "Nombre: " << actual->nombre << "\n";
			cout << "Apellido: " << actual->apellido << "\n";
			cout << "Edad: " << actual->edad << "\n";
			cout << "Enfermedad: " << actual->enfermedad << "\n";
			cout << endl;
			break;
		}
		anterior = actual;
		actual = actual->siguiente;
	}
	if(actual == NULL) {
		SetConsoleTextAttribute(h, 4);
		cout << "\tEl paciente NO ha sido encontrado\n";
		SetConsoleTextAttribute(h, 7);
	} 
}

void mostarPacientes(Paciente *lista) {
	Paciente *actual = new Paciente();
	
	actual = lista;
	
	while(actual != NULL) {
		cout << "ID: " << actual->id << "\n";
		cout << "Nombre: " << actual->nombre << "\n";
		cout << "Apellido: " << actual->apellido << "\n";
		cout << "Edad: " << actual->edad << "\n";
		cout << "Enfermedad: " << actual->enfermedad << "\n";
		cout << endl;
		actual = actual->siguiente;
	}
}


