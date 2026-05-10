Algoritmo Act3_Lecc24_inciso1
    Definir i, j, divisores, suma_primos Como Entero
    suma_primos <- 0 
    
    Para i = 1 Hasta 50 Hacer
        divisores = 0
        Para j = 1 Hasta i Hacer
            Si i MOD j == 0 Entonces
                divisores <- divisores + 1
            Fin Si
        Fin Para
        
        Si divisores == 2 Entonces
            suma_primos = suma_primos + i 
        Fin Si
    Fin Para
    
    Escribir "La suma de los numeros primos entre 1 y 50 es: ", suma_primos
FinAlgoritmo