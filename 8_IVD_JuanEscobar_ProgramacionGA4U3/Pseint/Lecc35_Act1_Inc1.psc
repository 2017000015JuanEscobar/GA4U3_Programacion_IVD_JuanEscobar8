Algoritmo Lecc35_Act1_Inc1
	Definir Q,do,eu,yen,pChi,pCom Como Real
	Definir r Como Caracter
	cdo = 0.13
	ceu = 0.11
	cyen = 21.16
	cpChi= 121.80
	cpCom = 426.03
	Repetir
		Limpiar Pantalla
		Escribir 'Nombre: Juan Pablo Escobar de Paz'
		Escribir 'IV Bachillerato D, clave 8'
		Escribir "===CONVERTIDOR DE MONEDAS==="
		Escribir "Ingrese la cantidad de su moneda"
		Leer Q
		
		do=Q*cdo
		eu=Q*ceu
		yen=Q*cyen
		pChi=Q*cpChi
		pCom=Q*cpCom
		
		Escribir "======================================="
		Escribir "El equivalente en dolares es de: ",do
		Escribir "El equivalente en Euros es de: ",eu
		Escribir "El equivalente en Yenes es de: ",yen
		Escribir "El equivalente en Pesos Chilenos es de: ",pChi
		Escribir "El equivalente en Pesos Colombanos: ",pCom
		Escribir "======================================="
		Escribir "Desea hacer otra convercion"
		leer r
	Hasta Que r="No" o r="no'
FinAlgoritmo