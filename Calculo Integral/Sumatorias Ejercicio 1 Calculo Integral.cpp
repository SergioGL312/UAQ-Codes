#include<stdio.h>
#include<math.h>

//Prototio de Función
void ejercicioB();
void ejercicioC();
void ejercicioD();
void ejercicioE();
void ejercicioF();

int main(){
	ejercicioB();
	printf("\n\n");
	ejercicioC();
	printf("\n\n");
	ejercicioD();
	printf("\n\n");
	ejercicioE();
	printf("\n\n");
	ejercicioF();
}

//Funciónes
void ejercicioB(){
	float totB = 0;
	int total = 0;
	printf("\tEJERCICIO B\n\n");
	for(int i = 2; i <= 5; i++){
		totB = pow(2, (i - 2));
		total += totB;
		printf("SIGMA: %.2f\n", totB);
	}
	printf("Sumatoria Total: %d\n", total);	
}

void ejercicioC(){
	float totc = 0;
	int total = 0;
	printf("\tEJERCICIO C\n\n");
	for(int i = 0; i <= 3; i++){
		totc = (2 * i) + 1;
		totc = pow(2, totc) ;
		total += totc;
		printf("SIGMA: %.2f\n", totc);
	}
	printf("Sumatoria Total: %d\n", total);
}

void ejercicioD(){
	float totD = 0;
	int total = 0;
	printf("\tEJERCICIO D\n\n");
	for(int i = 1; i <= 4; i++){
		totD = pow(i, i) ;
		total += totD;
		printf("SIGMA: %.2f\n", totD);
	}
	printf("Sumatoria Total: %d\n", total);
}

void ejercicioE(){
	float totE = 0;
	int total = 0;
	printf("\tEJERCICIO E\n\n");
	for(int i = 0; i <= 5; i++){
		totE = 2 * i + 1;
		total += totE;
		printf("SIGMA: %.2f\n", totE);
	}
	printf("Sumatoria Total: %d\n", total);
}

void ejercicioF(){
	float totF = 0;
	float total = 0;
	printf("\tEJERCICIO F\n\n");
	for(int i = 1;  i <= 5; i++){
		totF = i * ( i + 1 );
		totF = 1 / totF;
		total += totF;
		printf("SIGMA: %.2f\n", totF);
	}
	printf("Sumatoria Total: %.2f\n", total);
}
