Algoritmo Act1_Lecc9_inciso1
	Definir peso_total, peso_manzana Como Real
	Definir i Como Entero 
	
	peso_total = 0
	i = 0 
	
	Escribir "Objetivo: Comprar 1 kilo (1000 gramos) de manzanas"
	
	Mientras peso_total < 1000 Hacer
		Escribir "Coloca una manzana en la bascula y pon su peso en gramos (150 a 200):"
		Leer peso_manzana
		
		Si peso_manzana >= 150 Y peso_manzana <= 200 Entonces
			peso_total = peso_total + peso_manzana
			i = i + 1 
			Escribir "Llevas esta cantidad de manzanas: ", i
			Escribir "Peso actual en la bascula: ", peso_total, " gramos."
		SiNo
			Escribir "¡Error! Pon una manzana del rango (entre 150 y 200 gramos)"
		Fin Si
		
	FinMientras
	
	Escribir "¡Listo! Ya tienes ", peso_total, " gramos (1 kilo o un poco más) en la bascula"
FinAlgoritmo