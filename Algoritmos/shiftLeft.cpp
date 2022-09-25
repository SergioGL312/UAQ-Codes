#include<stdio.h>



int main(){
	int a[6] = {1,2,3,4,5,6};
	int temp = a[0];
	
	int tam = 0;
	tam = sizeof(a) / sizeof(*a);
	printf("\nTamaño del arreglo: %d\n" ,tam);
	
	for(int i = 0; i < tam; i++){
		a[i] = a[i+1];
	}
	a[tam-1] = temp;
	for(int i = 0; i < tam; i++){
		printf("%d  " , a[i]);
	}
	
}
