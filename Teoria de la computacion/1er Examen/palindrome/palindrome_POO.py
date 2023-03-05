import os

class Palindrome:
    def __init__(self):
        self.word = []
        self.sigma = []
    
    def get_size_alphabet(self):
        size_alphabet = int(input("\nsizeAlphabet > "))
        return size_alphabet
    
    def get_content_alpha(self):
        while True:
            content = input("\ncontentAlpha > ")
            if len(content) == self.size_alphabet:
                self.sigma = list(content)
                break
            if len(content) != self.size_alphabet:
                print("    [-] Invalid input")
    
    def get_word(self):
        self.word = list(input("\nword > "))
    
    def calculate(self):
        k = 0
        for i in range(0, len(self.word)):
            if self.word[i] in self.sigma:
                k = k + 1
        
        inverted_word = self.word[::-1]
        os.system("cls")
        print(f"[?] Size Alphabet {len(self.sigma)}")
        if k == len(self.word) and self.word == inverted_word:
            print("\n[+] La palabra si tiene los simbolos del alfabeto y es un palindromo")
        elif k == len(self.word):
            print("\n[+] La palabra si tiene los simbolos del alfabeto pero no es un palindromo")
        elif self.word == inverted_word:
            print("\n[+] La palabra si es un palindromo pero algun simbolo no esta en el alfabeto")
    
    def palindrome(self):
        self.size_alphabet = self.get_size_alphabet()
        self.get_content_alpha()
        self.get_word()
        self.calculate()

def main():
    pal = Palindrome()
    pal.palindrome()

if __name__ == '__main__':
    main()