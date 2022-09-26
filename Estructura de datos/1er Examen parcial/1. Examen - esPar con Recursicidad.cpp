#include <iostream>
#include <conio.h>

using namespace std;

int esPar(int);

int main() {
	int opc = 0;
	do{
		int num;
	    cout << "Digite un numeor para saber si es par o impar" << endl;
	    cin>>num;  
	    if(esPar(num)) {
			cout<<"Es un numero par";
		} else{
			cout<<"Es un numero impar";
		}
		cout << "\nDigite\n1.- Repetir 2.- Salir\n"; cin >> opc;
	}while(opc != 2);

	cout<<endl;
	getch();
    return 0;
}


int esPar(int num) {

	if(num==0){
        return 1;
	} else if(num==1){
	    return 0;
	}else if(num<0){
	    return esPar(-num);
	}else{
		return esPar(num-2);	
	}
}
