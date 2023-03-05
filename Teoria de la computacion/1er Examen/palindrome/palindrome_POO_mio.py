class Palindrome():
    # el alfabeto, palabra
    def __init__(self, sigma, word):
        self.__sigma = sigma
        self.__word = word

    def __isWordInSigma(self):
        k = 0
        for caracter in self.__word:
            if caracter in self.__sigma:
                k = k + 1
        return k

    def isPalindrome(self):
        contador = self.__isWordInSigma()
        invertedWord = self.__word[::-1]
        if contador == len(self.__word) and self.__word == invertedWord:
            print("[+] La palabra si tiene los simbolos del alfabeto y es un palindromo")
        elif contador == len(self.__word):
            print("[+] La palabra si tiene los simbolos del alfabeto pero no es un palindromo")
        elif self.__word == invertedWord:
            print("[+] La palabra si es un palindromo pero algun simbolo no esta en el alfabeto")


    def getSigma(self):
        print(self.__sigma)

    def getWord(self):
        print(self.__word)

def main():
    palabra1 = Palindrome('aeiou', "aia")
    palabra1.isPalindrome()

if __name__ == '__main__':
    main()