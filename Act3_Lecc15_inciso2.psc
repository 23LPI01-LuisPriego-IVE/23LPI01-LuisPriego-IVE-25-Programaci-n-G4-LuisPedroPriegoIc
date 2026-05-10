Algoritmo Act3_Lecc15_inciso2
	Definir i, j, divisores, cont_primos, suma_pares Como Entero
	cont_primos = 0
	suma_pares = 0
	
	Para i = 300 Hasta 1 Con Paso -1 Hacer
		
		Si i MOD 2 == 0 Entonces
			suma_pares = suma_pares + i
		Fin Si
		
		divisores = 0
		Para j = 1 Hasta i Hacer
			Si i MOD j == 0 Entonces
				divisores = divisores + 1
			Fin Si
		Fin Para
		
		Si divisores == 2 Entonces
			cont_primos = cont_primos + 1
		Fin Si
		
	Fin Para
	
	Escribir "Suma de los numeros pares: ", suma_pares
	Escribir "Cantidad de numeros primos encontrados: ", cont_primos
FinAlgoritmo
