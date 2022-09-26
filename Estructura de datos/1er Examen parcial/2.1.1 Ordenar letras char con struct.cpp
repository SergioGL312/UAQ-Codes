#include <iostream>
#include <cstring>
#include <windows.h>
 
using namespace std;
 
int main(){
    int i, j, n;
    const int NUM = 4;
 
    //una estructura que almacenar� los datos de un usuario. En ese caso solo un nombre para el ejemplo.
    typedef struct Contacto{
        //Datos
        char nombre[55];
    };
 
    Contacto agenda[NUM];  // Esto sera nuestra agenda de contactos para NUM contactos. =)
    Contacto temp;         // Lo usamos para guardar temporalmente los datos al organizar la agenda.     
 
    //Toma de datos
    for ( i = 0; i < NUM; i++ ) {
        cout << "\nEntre con el nombre para la posicion " << i << ": ";
        cin >> agenda[i].nombre;
    }
 
    system("cls");
    cout << "\n\n Mostrando nombres desordenados \n\n";
    for ( i = 0; i < NUM; i++ ){
        cout << "agenda.nombre[" << i << "]=\"" << agenda[i].nombre << "\";" << endl;
    }
 
    //Ordenando nombres
    for ( i = 0; i < NUM; i++ ){
        for ( int j = i + 1; j < NUM; j++ ){
 
            // strcoll() devuelve -1 si el 1� parametro es mayor que el 2�, 0 si el 1� es igual al 2�, o 
            //1 si el 1� mayor que el 2�. Lo hace caracter a caracter hasta encontrar una diferencia o un nulo que es cuando retorna uno de los valores mensionados.    
            if ( ( strcoll(/*1�*/ agenda[i].nombre, /*2�*/agenda[j].nombre) ) > 0 ) {
 
                //esto va subiendo los nombres a la cabeza de la lista
                strcpy ( temp.nombre, agenda[i].nombre );
                strcpy ( agenda[i].nombre, agenda[j].nombre );
                strcpy ( agenda[j].nombre, temp.nombre );
            }
        }
    }
 
    cout << "\n\n Mostrando nombres ordenados \n\n";
    for ( i = 0; i < NUM; i++ ){
        cout << "agenda.nombre[" << i << "]=\"" << agenda[i].nombre << "\";" << endl;
    }
 
    getchar();
 
}
