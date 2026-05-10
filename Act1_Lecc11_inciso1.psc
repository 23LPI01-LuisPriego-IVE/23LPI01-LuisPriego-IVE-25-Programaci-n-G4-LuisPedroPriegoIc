Algoritmo Act1_Lecc11_inciso1
	Definir autos_estacionados Como Entero
	autos_estacionados <- 0
	
	Repetir
		autos_estacionados = autos_estacionados + 1
		Escribir "Ha entrado un auto. Lugares disponibles: ", 200 - autos_estacionados
		
	Hasta Que autos_estacionados == 200
	
	Escribir "Ya no hay cajones libres. Estacionamiento lleno."
FinAlgoritmo