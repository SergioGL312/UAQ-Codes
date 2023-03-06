class GeneradorPalabras:
    def __init__(self, m, sigma, n):
        self.m = m
        self.sigma = sigma
        self.n = n
    
    def generar_palabras(self):
        words = ['']
        for i in range(self.n):
            new_words = []
            for word in words:
                for symbol in self.sigma:
                    new_words.append(word + symbol)
            words += new_words 
        words = list(set(words))
        words = sorted(words, key=len)
        return words


def main():
    m = int(input("Introduce el valor de m: "))
    sigma = []
    for i in range(m):
        sigma.append(input("Introduce el símbolo número {}: ".format(i+1)))
    n = int(input("Introduce el valor de n: "))

    generador = GeneradorPalabras(m, sigma, n)
    palabras = generador.generar_palabras()

    print(palabras)

if __name__ == '__main__':
    main()
