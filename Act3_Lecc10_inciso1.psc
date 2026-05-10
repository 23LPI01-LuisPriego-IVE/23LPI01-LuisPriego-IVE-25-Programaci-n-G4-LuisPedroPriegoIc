Algoritmo Act3_Lecc10_inciso1
	Definir i, divisor, cont_divisores, suma Como Entero
	suma = 0
	
	Escribir "Números primos entre 1 y 22:"
	
	Para i = 1 Hasta 22 Hacer
		cont_divisores = 0

		Para divisor = 1 Hasta i Hacer
			Si i MOD divisor == 0 Entonces
				cont_divisores = cont_divisores + 1
			Fin Si
		Fin Para
		
		Si cont_divisores == 2 Entonces
			Escribir i
			suma = suma + i
		Fin Si
	Fin Para
	
	Escribir "La suma total de los números primos es: ", suma
FinAlgoritmo

