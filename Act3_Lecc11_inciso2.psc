Algoritmo Act3_Lecc11_inciso2
	Definir num, suma Como Entero
	suma = 0
	num = 0 
	Mientras num <> 9 Hacer
		Escribir "Ingresa un numero (o presiona 9 para terminar):"
		Leer num
		
		Si num <> 9 Entonces
			suma = suma + num
		Fin Si
	Fin Mientras
	
	Escribir "La suma total de los números ingresados es: ", suma
FinAlgoritmo

