# Definicion del alfabeto 
Σ = ['x']

# Declaracion de la tabla de transicionesEstados/
#        δ(q0,x)=q1, δ(q1,'')=q1
#        Estados     x
#        ->q0        qf
#          qf *     NULL
#############################
#Tabla logica
#   -espacio de memoria- se conecte a otro espacio de memoria
#   -enviar un caracter entre espacios de memoria
#   Lista
#   '0' = Posicion actual del nodo
#   'x' = El dato de esa posicion
#   '1' = El siguiente nodo
#   Esta esla reperesentacion en python = [0,'x',1] 
#   Estados                     
#   q0 Posicionde me moria 0
#   qf Posicion de memoria 1 
#   'x' Caracter enviar de q0 a qf
##################################################
# Tabla es:
# 0     x       1
# 1     NA      NULL
#Transicion vacia tabla logica
# [0,'',1]
###################################################
#Tabla de transiciones
# TablaT=[[0,'x',1],[1, '', -1]]
TablaT=[[0,'x',0]]
#Utilizar una bandera para revisar que (x ϵ Σ)
bandera = True
#Tabla para almacenar los estado que se mueven
TablaC = []
#estado inicial q0 = posicion 0 de la tabla
EI = 0
#Estafo final qf = posicion 1 de la tabla 
EF=[0]
#Estado actual
EA = EI
#cadena de caracteres del alfabeto
print ("Inserta la cadena a evaluar")
cadena = input()

for caracter in cadena:
    print (caracter)
    #verificar que el caracter pertenezca a el Σ = ['x']
    if caracter in Σ:
        print ("El carcacter (x ϵ Σ) ")
        #Buscar en la tabla el caracter TablaT
        for f in TablaT:
            #Recorrer las transiciones de la tabla
            #Indicar el estado actual y el estado final
            if caracter in f and EA in f:
                #Agregar elementos a la tabla comparativa TablaC
                TablaC.append([EA,caracter,f[2]])  
                #actualizar el estado
                EA=f[2]
                print ("Estado actual es : " + str(EA))
    else:
        print("Cadena no pertenece al alfabeto")
        bandera = False

#Comparar si el estado actual es igual al estafo final

if EA in EF and (bandera == True):
    print("------------------------------")
    print("Es valida la cadena de entrada")
    print("____Tabla de transiciones_____")
    for t in TablaC:
        print (t)
else:
    print("---------------------------------")
    print("NO es valida la cadena de entrada")
    print("______Tabla de transiciones______")
    for t in TablaC:
        print (t)