#include <iostream>
#include <stdlib.h>

using namespace std;

int num = 0;

void pedirDatos();
int par(int num);
int impar(int num);

int main(){
	int opc = 0;
	
	do{
		pedirDatos();
		cout << par(num);
		cout << endl<<endl;
		cout << "Desea repetir el programa:\nDigite \n1.- Si\n2.-No\n";
		cin >> opc;
	}while(opc != 2);
	
	system("pause");
	return 0;
}

void pedirDatos(){
	cout << "Digite el numero: ";
	cin >> num;
}

int impar (int num){
    if (num == 0) {
    	return 0;
	}
    else{
    	return par(num-1);
	}
}

int par (int num) {
    if (num == 0) {
    	return 1;
	} else{
		return impar(num-1);
	}
        
}
