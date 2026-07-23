Algoritmo Lecc33_Act2_Inc1 
	Definir fra,f1 Como Cadena
	Definir lf,i Como Entero
	Escribir 'Nombre: Juan Pablo Escobar de Paz'
	Escribir 'IV Bachillerato D, clave 8'
	Escribir "Ingrese una frase para invertirla"
	Leer fra
	f1=""
	lf=Longitud(fra)
	Para i =lf Hasta 1 Con Paso -1 Hacer
		f1=f1+Subcadena(fra,i,i)
	FinPara
	Escribir f1
FinAlgoritmo