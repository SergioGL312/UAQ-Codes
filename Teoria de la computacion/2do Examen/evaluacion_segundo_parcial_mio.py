from io import open

global δ, tablaT, qA

file = open("AFD.txt", "r")
texto = file.readlines()
file.close()

Q = len(texto[0].replace('\n', '').replace(' ', ''))
Σ = texto[1].replace('\n', '').split()
q0 = texto[2].replace('\n', '') 
F = texto[3].replace('\n', '')

qA = q0

def reglasTrancision():
    global δ
    δ = []
    for i in range(4, len(texto)):
        δ.append(texto[i].split())

def tablaTransiciones():
    global tablaT, Σ
    tablaT = []
    for i in range(0, len(δ)):
        for j in range(0, len(Σ)) :
            if j == 0:
                tablaT.append([δ[i][0], Σ[j], δ[i][1]])
            elif j == 1:
                tablaT.append([δ[i][0], Σ[j], δ[i][2]])  


def perteneceAlfabeto():
    global qA

    bandera = True
    tablaC = []

    cadena = input("Cadena a analizar > ")
    
    for caracter in cadena:
        if caracter in Σ:
            for trancisiones in tablaT:
                if caracter in trancisiones and qA == trancisiones[0]:
                    tablaC.append([qA,caracter,trancisiones[2]])
                    qA = trancisiones[2]
                    break
        else:
            print("Cadena no pertenece al alfabeto")
            bandera = False

    if qA in F and (bandera == True):
        print("\n------------------------------------")
        print("[+] Es valida la cadena de entrada")
        print("------------------------------------\n")
        plantillaTabla(tablaC)

    else:
        print("\n-----------------------------------------")
        print("[-] NO es valida la cadena de entrada")
        print("-----------------------------------------\n")
        plantillaTabla(tablaC)
        
def plantillaTabla(tablaC):
    print("______________Tabla de transiciones______________\n")
    print("Estado Actual\tCarácter Leido\tEstado Siguiente")
    for t in range(0, len(tablaC)):
        print (f"\t{tablaC[t][0]}\t\t{tablaC[t][1]}\t\t{tablaC[t][2]}")
    print("\n")

def main():
    reglasTrancision()
    tablaTransiciones()
    perteneceAlfabeto()

if __name__ == '__main__':
    main()