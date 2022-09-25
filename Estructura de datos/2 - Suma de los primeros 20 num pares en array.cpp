/* Escribir un programa que llene un arreglo con los veinte primeros números
pares y calcule su suma. */
#include <iostream>
#include <stdlib.h>

using namespace std;

int *a, tam = 20;

void sumaNumPares();

int main() {
	
	sumaNumPares();
	
	
	cout << "\n\n";
	system("pause");
	return 0;
}

void sumaNumPares() {
	a = new int[tam];
	int i = 0, c = 0, sum = 0;
	while(c < tam) {	
		i++;
		if(i % 2 == 0) {
			*(a + i) = i;
			cout << *(a + i) << "\n";
			sum += *(a + i);
			c++;
		}
	}
	cout << "\nSuma: " << sum;
}
