#include <iostream>
#include <stdlib.h>
#include <conio.h>

using namespace std;

int main() {
	
	int cifra;
	char alfabet[11] = {' ', 'a', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'};
	
	cout << "Cifras: ";
	cin >> cifra;
	
	while(cifra > 0) {
		cout << alfabet[ (int) cifra % 10 ] << " ";
		cifra = (int) cifra / 10;
	}
}
