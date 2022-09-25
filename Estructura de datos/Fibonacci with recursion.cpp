#include <iostream>
#include <stdlib.h>

using namespace std;

int num;

void pedirDatos();
int fibonacci(int num);

int main() {
	
	pedirDatos();
	for(int i = 0; i <= num; i++) {
		if(i == num) {
			cout << fibonacci(i) << " ";
		}else {
			cout << fibonacci(i) << ", ";	
		}	
	}
	
	cout << "\n\n";
	
	system("pause");
	return 0;
}

void pedirDatos() {
	cout << "Digite el numero: ";
	cin >> num;
	cout << "\n";
}

int fibonacci(int num) {
	if(num < 2) {
		return num;
	} else{
		return num = fibonacci(num - 1) + fibonacci(num - 2);
	}
}
