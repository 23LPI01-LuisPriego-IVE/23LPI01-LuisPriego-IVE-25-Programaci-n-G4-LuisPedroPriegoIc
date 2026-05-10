Algoritmo Act2_Lecc15_inciso1
	Definir i, j, divisores, cont_primos, suma_primos Como Entero
	cont_primos = 0
	suma_primos = 0
	
	Para i = 1 Hasta 100 Hacer
		divisores = 0
		
		Para j = 1 Hasta i Hacer
			Si i MOD j == 0 Entonces
				divisores = divisores + 1
			Fin Si
		Fin Para
		
		Si divisores == 2 Entonces
			cont_primos = cont_primos + 1     
			suma_primos = suma_primos + i   
		Fin Si
	Fin Para
	
	Escribir "Cantidad de numeros primos encontrados: ", cont_primos
	Escribir "La suma de todos ellos es: ", suma_primos
FinAlgoritmo
