class Alfabeto:
    def __init__(self, alfabeto):
        self.alfabeto = alfabeto
        
    def contiene_letras(self, palabra):
        letras = set(palabra)
        return letras.issubset(set(self.alfabeto))
        
class Palindromo:
    def __init__(self, alfabeto, palabra):
        self.alfabeto = Alfabeto(alfabeto)
        self.palabra = palabra
    
    def es_palindromo(self):
        return self.palabra == self.palabra[::-1]
    
    def contiene_letras(self):
        return self.alfabeto.contiene_letras(self.palabra)

alfabeto = ['a', 'b', 'c']
palabra = 'abba'

p = Palindromo(alfabeto, palabra)

if p.es_palindromo():
    print("La palabra es un palíndromo.")
else:
    print("La palabra no es un palíndromo.")

if p.contiene_letras():
    print("La palabra contiene sólo letras del alfabeto.")
else:
    print("La palabra contiene letras que no pertenecen al alfabeto.")
