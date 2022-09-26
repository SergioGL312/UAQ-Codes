#include <iostream>
#include <stdlib.h>

using namespace std;

int n = 0;

struct alumnos{
    char nombre[100];
    float promedio;
};

alumnos *a;

void cantidad();
void pedirDatos(alumnos a[]);
void ordenacionSeleccion(alumnos a[]);
void descendentSort(alumnos a[]);

int main() {

    cantidad();
    pedirDatos(a);
    ordenacionSeleccion(a);
    descendentSort(a);

    system("pause");
    return 0;
}

void cantidad() {
    cout << "Digite la cantidad de alumnos: ";
    cin >> n;
    a = new alumnos[n];
    cout << "\n";
}

void pedirDatos(alumnos a[]) {
    for (int i = 0; i < n; i++) {
        fflush(stdin);
        cout << (i + 1) <<  ".- Digite su nombre" << endl;
        cin.getline(a[i].nombre, 100, '\n');
        cout << "Digite su promedio: " << endl;
        cin >> a[i].promedio;
        cout << "\n";
    }
}

void ordenacionSeleccion(alumnos a[]) {
	//Algoritmo del Ordenamiento por Selecci?n
	int aux = 0, min = 0;
	for(int i = 0; i < n; i++){
		min = i;
		for(int j = i + 1; j < n; j++){
			if(a[j].promedio < a[min].promedio){
				min = j;
			}
		}
		aux = a[i].promedio;
		a[i].promedio = a[min].promedio;
		a[min].promedio = aux;
	}
}

void descendentSort(alumnos a[]) {
	cout<<"\nOrdenados Descendentemente: " << endl;
    int tercio = n / 3;
	for(int i = tercio - 1; i >= 0; i--){
        cout<< "Nombre: " << a[i].nombre << " ";
		cout<< "Promedio: " << a[i].promedio << endl;
        cout << "\n";
	}
}