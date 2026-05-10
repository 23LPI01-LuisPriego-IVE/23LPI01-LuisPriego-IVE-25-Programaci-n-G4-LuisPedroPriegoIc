Algoritmo Act3_Lecc11_inciso1
	Definir n1, n2, menor, mayor, suma, i Como Entero
	suma = 0
	
	Escribir "Ingresa primer numero:"
	Leer n1
	Escribir "Ingresa segundo numero:"
	Leer n2
	
	Si n1 < n2 Entonces
		menor = n1; mayor <- n2
	SiNo
		menor = n2; mayor <- n1
	FinSi
	
	Para i = menor Hasta mayor Hacer
		suma = suma + i 
	Fin Para
	
	Escribir "La suma total de los numeros entre ", menor, " y ", mayor, " es: ", suma
FinAlgoritmo

