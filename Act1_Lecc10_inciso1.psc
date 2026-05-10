Algoritmo Act1_Lecc10_inciso1
	Definir corte Como Entero
	
	Escribir "Bienvenido a la barberia"
	Escribir "Presiona una tecla para obtener cada sello hasta llenar tu cuponera"
	
	Para corte = 1 Hasta 8 Con Paso 1 Hacer
		Escribir "Presiona una tecla para marcar el sello #", corte, "..."
		Esperar Tecla 
		
		Escribir "¡Sello #", corte, " marcado con exito!"
	Fin Para
	
	Escribir "¡Felicidades! Has completado tus 8 sellos"
	Escribir "Tu proximo corte de cabello es gratis"
FinAlgoritmo