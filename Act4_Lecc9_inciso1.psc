Algoritmo Act4_Lecc9_inciso1
	Definir numero_inicial, contador, resultado Como Entero
	
	Escribir "Dame un numero para mostrar su tabla de multiplicar (1 al 10):"
	Leer numero_inicial
	
	contador = 1
	
	Escribir "Tabla del:", numero_inicial
	

	Mientras contador <= 10 Hacer
		resultado = numero_inicial * contador
		Escribir numero_inicial, " x ", contador, " = ", resultado
		contador = contador + 1
	Fin Mientras
	
FinAlgoritmo