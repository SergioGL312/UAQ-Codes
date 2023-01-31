def generar_palabras(alfabeto, n, longitud_actual):
  # Si la longitud actual de la palabra es mayor o igual a la longitud máxima, terminamos la recursión
  if longitud_actual >= n:
    return

  # Generamos todas las palabras de longitud "longitud_actual"
  for i in range(len(alfabeto)):
    palabra = alfabeto[i] * longitud_actual
    print(palabra)

    # Llamamos recursivamente a la función para generar las palabras de longitud "longitud_actual+1"
    generar_palabras(alfabeto, n, longitud_actual+1)

# Para probar la función, podemos llamarla con un alfabeto de dos símbolos y una longitud máxima de 3
generar_palabras(['0', '1'], 3, 0)
