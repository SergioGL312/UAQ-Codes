/*Ingresa tus calificaciones del semestre pasado, ordenalas de orden
ascendente y orden descendente.*/
#include <iostream>
#include <stdlib.h>
#include <string>

using namespace std;

int pos = 0, aux = 0;

struct calificaciones{
	string nombre;
	int calif;
};

//c1 = {"BASE DE DATOS I	", 10};
//calificaciones c2 = {"REDES I	", 9},
//calificaciones c3 = {"DEPORTES III	", 10},
//calificaciones c4 = {"INGENIERIA DE REQUERIMIENTOS	", 10},
//calificaciones c5 = {"CALCULO DIFERENCIAL E INTEGRAL	", 9},
//calificaciones c6 = {"DESARROLLO HUMANO III	", 10},
//calificaciones c7 = {"INGLES II	", 9},
//calificaciones c8 = {"ALGORITMOS	", 10};

void ordenacionInsercion(calificaciones c[]);
void ascendente(calificaciones c[]);
void descendente(calificaciones c[]);

int main(){
	
	calificaciones c[10];
	c[0].nombre = "BASE DE DATOS I	";
	c[0].calif = 10;
	c[1].nombre = "REDES I	";
	c[1].calif = 9;
	c[2].nombre = "DEPORTES III	";
	c[2].calif = 10;
	c[3].nombre = "INGENIERIA DE REQUERIMIENTOS	";
	c[3].calif = 10;
	c[4].nombre = "CALCULO DIFERENCIAL E INTEGRAL	";
	c[4].calif = 9;
	c[5].nombre = "DESARROLLO HUMANO III	";
	c[5].calif = 10;
	c[6].nombre = "INGLES II	";
	c[6].calif = 9;
	c[7].nombre = "ALGORITMOS	";
	c[7].calif = 10;
	
	ordenacionInsercion(c);
	ascendente(c);
	descendente(c);
	
	system("pause");
	return 0;
}
void inicializar() {

}

void ordenacionInsercion(calificaciones c[]) {
	//Algoritmo del Ordenamiento por Inserción
	
	for(int i = 0; i < 10; i++){
		pos = i; 
		aux = c[i].calif;
		
		while((pos>0) && (c[pos-1].calif > aux)){
			c[pos].calif = c[pos-1].calif;
			pos--;
		}
		c[pos].calif = aux;
	}
}

void ascendente(calificaciones c[]){
	cout << "\n\nAscendente\n";
	for(int i = 0; i < 7; i++){
		cout << c[i].nombre << endl;
		cout << c[i].calif << endl;
	}
}

void descendente(calificaciones c[]){
	cout << "\n\nDescendente\n";
	for(int i = 7; i >= 0; i--){
		cout << c[i].nombre << endl;
		cout << c[i].calif << endl;
	}
}


