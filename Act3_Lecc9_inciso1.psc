Algoritmo Act3_Lecc9_inciso1
	Definir numero_final, numero_inicial Como Entero
	Definir inicio_original Como Entero
	numero_final = 20
	
	Escribir "Dame un inicial para mostrar sus numero impares hasta el 20:"
	Leer numero_inicial
	
	inicio_original = numero_inicial
	

	Mientras numero_inicial <= numero_final Hacer
		Si numero_inicial MOD 2 <> 0 Entonces
			Escribir numero_inicial
		Fin Si
		numero_inicial = numero_inicial + 1
	Fin Mientras
	
	Escribir "Esos son los numeros impares entre: ", inicio_original, " y ", numero_final
FinAlgoritmo