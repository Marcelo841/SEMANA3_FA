def ejr1():
    nombre = input(("Ingrese su nombre: "))
    carrera = input(("Ingrese su carrera: "))
    print(f"\n{nombre}, Bienvenido al curso de Fundamentos de Algoritmos de la carrera {carrera}")
  

def ejr2():
    print("\"Marcelo\"")

def ejr3():
        num1 = int(input("Ingrese numero 1 "))
        num2 = int(input("Ingrese numero 2 "))

        print("Suma: " ,(num1+num2))
        print("Resta: " ,(num1-num2))
        print("Multiplicacion: " ,(num1*num2))
        print("Division: " ,(num1/num2))   

import math #importando libreria math

def ejr4():
    num = float(input("Ingrese numero decimal: "))

    raiz = math.sqrt(num)
    redo = round(num,2)
    cubo = math.pow(num,3)
    cubica = num ** (1/3)

    print("Raiz cuadrada: " ,raiz)
    print("Redondeado: " ,redo)
    print("Elevado al cubo: " ,cubo)
    print("Raiz cubica: " ,cubica)

def ejr5():
    num = input("Ingrese un numero: ")
    entero = int(num);
    decim = float(num);

    print("Resto: ", (entero*2))
    print("Decimal: ", (decim/3)
