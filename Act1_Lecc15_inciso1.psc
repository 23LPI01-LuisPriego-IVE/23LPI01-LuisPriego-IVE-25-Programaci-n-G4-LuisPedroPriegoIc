Algoritmo Act1_Lecc15_inciso1
	Definir total_boletos, total_dinero, tipo_boleto Como Entero
	
	total_boletos = 0
	total_dinero = 0
	tipo_boleto = 1 
	Escribir "Sistema de Cobro"
	Escribir "1. Adulto ($15) | 2. Niño ($10) | 0. Cerrar Turno"
	
	Mientras tipo_boleto <> 0 Hacer
		Escribir "Ingrese tipo de boleto:"
		Leer tipo_boleto
		
		Si tipo_boleto == 1 Entonces
			total_dinero = total_dinero + 15
			total_boletos = total_boletos + 1
		SiNo
			Si tipo_boleto == 2 Entonces
				total_dinero = total_dinero + 10
				total_boletos = total_boletos + 1
			FinSi
		FinSi
		
		Escribir "Ventas actuales: ", total_boletos, " boletos. Total: $", total_dinero
	FinMientras
	
	Escribir "Corte Final"
	Escribir "Boletos vendidos: ", total_boletos
	Escribir "Total de dinero cobrado: $", total_dinero
FinAlgoritmo
