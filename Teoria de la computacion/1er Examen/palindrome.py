import os

word = []
sigma = []

def palindrome():
    sizeAlphabet = int(input("\nsizeAlphabet > "))
    while True:
        content = input("\ncontentAlpha > ")
        if len(content) == sizeAlphabet:
            sigma = list(content)
            break
        if len(content) != sizeAlphabet:
            print("    [-] Invalid input")
    
    
    word = list(input("\nword > "))
    calculate(sigma, word)

def calculate(sigma, word):
    k = 0
    for i in range(0, len(word)):
        if word[i] in sigma:
            k = k + 1
    
    invertedWord = word[::-1]
    os.system("cls")
    print(f"[?] Size Alphabet {len(sigma)}")
    if k == len(word) and word == invertedWord:
        print("\n[+] La palabra si tiene los simbolos del alfabeto y es un palindromo")
    elif k == len(word):
        print("\n[+] La palabra si tiene los simbolos del alfabeto pero no es un palindromo")
    elif word == invertedWord:
        print("\n[+] La palabra si es un palindromo pero algun simbolo no esta en el alfabeto")


def main():
    palindrome()

if __name__ == '__main__':
    main()