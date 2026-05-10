Algoritmo Act2_Lecc11_inciso3
	Definir n1, n2, menor, mayor, i Como Entero
	
	Escribir "Ingresa el primer numero:"
	Leer n1
	Escribir "Ingresa el segundo numero:"
	Leer n2
	
	Si n1 < n2 Entonces
		menor = n1
		mayor = n2
	SiNo
		menor = n2
		mayor = n1
	FinSi
	
	Escribir "Multiplos de 4 entre ", menor, " y ", mayor, ":"
	

	Para i <- menor Hasta mayor Hacer
		Si i MOD 4 == 0 Entonces
			Escribir i
		FinSi
	Fin Para
FinAlgoritmo
