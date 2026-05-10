Algoritmo Act3_Lecc9_inciso2
    Definir numero_inicial, divisor, contador_divisores Como Entero
    
    Escribir "Dame un numero para ver si es numero primo:"
    Leer numero_inicial
    
    divisor = 1
    contador_divisores = 0
    
    Mientras divisor <= numero_inicial Hacer
        Si numero_inicial MOD divisor = 0 Entonces
            contador_divisores = contador_divisores + 1
        Fin Si
        
        divisor = divisor + 1
    Fin Mientras
    
    Si contador_divisores = 2 Entonces
        Escribir "El numero ", numero_inicial, " es un numero primo"
    SiNo
        Escribir "El numero ", numero_inicial, " no es un numero primo"
    Fin Si
    
FinAlgoritmo
