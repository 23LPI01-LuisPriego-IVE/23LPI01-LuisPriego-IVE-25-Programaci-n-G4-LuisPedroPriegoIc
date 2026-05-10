Algoritmo Act2_Lecc9_inciso1
	Definir monedas_totales, monedas_ingresadas Como Real
	
	monedas_totales = 0
	
	Mientras monedas_totales < 350 Hacer
		Escribir "Nivel 5 bloqueado llevas: ", monedas_totales, " monedas"
		Escribir "Ingresa las monedas ganadas en esta partida:"
		Leer monedas_ingresadas
		
		monedas_totales = monedas_totales + monedas_ingresadas
	FinMientras
	
	Escribir "¡Felicidades! Tienes ", monedas_totales, " monedas"
	Escribir "El Nivel 5 ha sido desbloqueado, puedes ingresar ahora"
FinAlgoritmo
