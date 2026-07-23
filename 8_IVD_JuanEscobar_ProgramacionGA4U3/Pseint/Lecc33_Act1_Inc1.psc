Algoritmo Lecc33_Act1_Inc1
	Dimensionar num(10,2)
	Definir opcion Como Entero
	Repetir
		Limpiar Pantalla
		Escribir 'Nombre: Juan Pablo Escobar de Paz'
		Escribir 'IV Bachillerato D, clave 8'
		Escribir 'MENU'
		Escribir '1. Registrar Numero'
		Escribir '2. Mostrar Numero'
		Escribir '3. Salir'
		Leer opcion
		Según opcion Hacer
			1:
				Limpiar Pantalla
				Escribir '===REGISTRAR NUMEROS==='
				RegistrarN(num)
				Escribir 'Presione cualquier tecla para continuar...'
				Esperar Tecla
			2:
				Limpiar Pantalla
				Escribir '===MOSTRAR NUMEROS==='
				MostrarN(num)
				Escribir 'Presione cualquier tecla para continuar...'
				Esperar Tecla
		FinSegún
	Hasta Que opcion=3
FinAlgoritmo

// registrar
Función RegistrarN(num)
	Definir i Como Entero
	Para i<-1 Hasta 10 Hacer
		Si num[i,1]='' Entonces
			Escribir 'Nombre:'
			Leer num[i,1]
			Escribir 'Numero:'
			Leer num[i,2]
			Escribir 'Numero registrado.'
		FinSi
	FinPara
	Escribir 'Matriz llena.'
FinFunción

// Mostrar
Función MostrarN(num)
	Definir i Como Entero
	Escribir 'NOMBRE             NUMERO'
	Para i<-1 Hasta 10 Hacer
		Si num[i,1]<>'' Entonces
			Escribir num[i,1], '      ', num[i,2], '   '
		FinSi
	FinPara
FinFunción
