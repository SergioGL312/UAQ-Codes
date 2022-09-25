#include <stdio.h>
#include <Math.h>

int ejercicioA();
int ejercicioAUno();
int ejercicioB();
bool comparacionA(int, int);
bool comparacionB(int);

int main() {
	/*ejercicioA();
	ejercicioAUno();*/
	//comparacionA(ejercicioA(), ejercicioAUno());
	comparacionB(ejercicioB());
	
}

int ejercicioA() {
	int e = 0;
	int tot = 0;
	printf("\tEJERCICIO A\n");
	for(int i = 0; i <= 100; i++){
		e = pow(i, 4);
		tot += e;
		printf("%d.- N: %d\n", i, e);
	}
	printf("\nTotal: %d\n", tot);
	return tot;
}

int ejercicioAUno() {
	int e = 0;
	int totU = 0;
	printf("\tEJERCICIO A-1\n");
	for(int i = 1; i <= 100; i++){
		e = pow(i, 4);
		totU += e;
		printf("%d.- N: %d\n", i, e);
	}
	printf("\nTotal: %d\n", totU);
	return totU;
}

int ejercicioB() {
	int e = 0;
	int tot = 0;
	printf("\tEJERCICIO B\n");
	for(int i = 0; i <= 100; i++){
		e += 2;
		tot += e;
		printf("%d.- N: %d\n", i, e);
	}
	printf("\nTotal: %d\n", tot);
	return tot;
}

/*
int ejercicioAUno() {
	int e = 0;
	int totU = 0;
	printf("\tEJERCICIO B-1\n");
	for(int i = 1; i <= 100; i++){
		e = pow(i, 4);
		totU += e;
		printf("%d.- N: %d\n", i, e);
	}
	printf("\nTotal: %d\n", totU);
	return totU;
}*/

bool comparacionA(int tot, int totU){
	if(tot == totU){
		printf("TRUE");
		return true;
	} else{
		printf("FALSE");
		return false;
	}
}

bool comparacionB(int tot){
	printf("\tEJRECICIO B\n");
	if(tot == 200){
		printf("TRUE");
		return true;
	} else{
		printf("FALSE");
		return false;
	}
}
