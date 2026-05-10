Algoritmo Act3_Lecc15_inciso1
		Definir i, multiplo, suma, cont_pares Como Entero
		suma = 0
		cont_pares = 0
		
		Para i = 1 Hasta 20 Hacer
			multiplo = i * 7
			suma = suma + multiplo 
			
			Si multiplo MOD 2 == 0 Entonces
				cont_pares = cont_pares + 1 
			Fin Si
			
			Escribir "Multiplo ", i, ": ", multiplo
		Fin Para
		
		Escribir "La sumatoria total es: ", suma
		Escribir "Cantidad de multiplos pares: ", cont_pares
FinAlgoritmo
