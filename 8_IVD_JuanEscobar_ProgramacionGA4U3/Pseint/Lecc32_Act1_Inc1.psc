Algoritmo Lecc32_Act1_Inc1 
	Escribir "Nombre: Juan Pablo Escobar de Paz"
	Escribir "IV Bachillerato D, clave 8"
	Definir me,op,res Como Real
	Escribir "====Conversor===="
	Escribir "Ingrese una cantidad de metros"
	Leer me
	Escribir "Seleccione una opcion"
	Escribir "1- milimetros"
	Escribir "2- centimetros"
	Escribir "3- decimetros"
	Escribir "4- hectometros"
	Escribir "5- kilometros"
	Leer op
	Segun op Hacer
		1: res=me*1000
			Escribir me," metros equivalen a ",res, " milimetros"
		2: res=me*100
			Escribir me," metros equivalen a ",res, " centimetros"
		3: res=me*10
			Escribir me," metros equivalen a ",res, " decimetros"
		4: res=me/100
			Escribir me," metros equivalen a ",res, " hectometros"
		5: res=me/1000
			Escribir me," metros equivalen a ",res, " kilometros"
		De Otro Modo:
			Escribir "Opcion invalida..."
	FinSegun
FinAlgoritmo