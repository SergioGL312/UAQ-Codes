class AFD:
    def __init__(self, Q, alfa, q0, F, transiciones):
        self.__Q = Q
        self.__alfa = alfa
        self.__q0 = q0
        self.__F = F
        self.__transiciones = transiciones
        self.__qA = None
        self.__tabla = []
        self.__tablaC = []

    def __funcionesTransicion(self):
        for estado, valores in self.__transiciones.items():
            for i, symbol in enumerate(self.__alfa):
                self.__tabla.append([estado, symbol, valores[i]])

    def aceptada(self, cadena):
        self.__qA = self.__q0
        bandera = True
        for caracter in cadena:
            if caracter in self.__alfa:
                for trancisiones in self.__tabla:
                    if caracter in trancisiones and self.__qA == trancisiones[0]:
                        self.__tablaC.append([self.__qA,caracter,trancisiones[2]])
                        self.__qA = trancisiones[2]
                        break
            else:
                bandera = False

        if self.__qA in self.__F and (bandera == True):
            self.__plantillaTabla(self.__tablaC)
            print(f"\n\t\tPalabra w = {cadena} ACEPTADA\n")
        else:
            self.__plantillaTabla(self.__tablaC)
            print(f"\n\t\tPalabra w = {cadena} NO ACEPTADA\n")

        
    def __plantillaTabla(self, tabla):
        print("\nEstado Actual\tCarácter Leido\tEstado Siguiente")
        for t in range(0, len(tabla)):
            print (f"\t{tabla[t][0]}\t\t{tabla[t][1]}\t\t{tabla[t][2]}")


    def afd(self, cadena):
        self.__funcionesTransicion()
        self.aceptada(cadena)

def main():
    Q = {1, 2, 3, 4}
    alfabeto = {'a', 'b'}
    q0 = 1
    F = {1}
    transiciones = {
        1: [3, 2],
        2: [4, 1],
        3: [1, 4],
        4: [2, 3]
    }

    afd = AFD(Q, alfabeto, q0, F, transiciones)

    afd.afd("aabb")
    afd.afd("a")
    afd.afd("aabbabab")

if __name__ == '__main__':
    main()