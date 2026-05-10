Algoritmo Act2_Lecc15_inciso2
	Definir i, billete, cont_100, suma_100 Como Entero
	cont_100 <- 0
	suma_100 <- 0
	i <- 1 
	
	Escribir " Contador de Billetes de $100 "
	Escribir "Ingrese 0 en cualquier momento para finalizar"
	
	Mientras i <= 1000 Hacer
		Escribir "Billete ", i, ": Ingrese valor (20, 50, 100 o 0 para salir):"
		Leer billete
		
		Si billete == 0 Entonces
			Escribir "Proceso finalizado por el usuario"
			i <- 1001 
		SiNo
			Si billete == 100 Entonces
				cont_100 <- cont_100 + 1   
				suma_100 <- suma_100 + 100  
				Escribir "Billete de $100 registrado"
			SiNo
				Escribir "Billete distinto a 100 registrado"
			FinSi
			
			i <- i + 1
		FinSi
	FinMientras
	
	Escribir " Reporte Final "
	Escribir "Total de billetes de $100: ", cont_100
	Escribir "Dinero total en billetes de $100: $", suma_100
FinAlgoritmo