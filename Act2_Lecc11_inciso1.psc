Algoritmo Act2_Lecc11_inciso1
	Definir n, i, factorial Como Entero
	
	Escribir "Digite un numero para ver su factorial:"
	Leer n
	
	i = n       
	factorial = 1 
	
	Repetir
		factorial = factorial * i
		i = i - 1
		
	Hasta Que i == 0
	
	Escribir "El factorial de ", n, " es: ", factorial
FinAlgoritmo