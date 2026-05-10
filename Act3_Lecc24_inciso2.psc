Algoritmo Act3_Lecc24_inciso1
    Definir n, i, suma_total Como Entero
    suma_total <- 0
    
    Escribir "Ingresa un numero para iniciar la cuenta regresiva:"
    Leer n
    
    Para i <- n Hasta 1 Con Paso -1 Hacer
        Escribir i
        suma_total <- suma_total + i 
    Fin Para
    
    Escribir "La suma es ", suma_total
FinAlgoritmo