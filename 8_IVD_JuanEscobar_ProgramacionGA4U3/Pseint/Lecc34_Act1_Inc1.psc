Algoritmo Lecc34_Act1_Inc1 
	Definir numd, r Como Entero
	Definir bin Como Cadena
	Escribir 'Nombre: Juan Pablo Escobar de Paz'
	Escribir 'IV Bachillerato D, clave 8'
	Escribir "Escriba un numero decimal"
	Leer numd
	Si numd=0 Entonces
		bin="0'
	SiNo
		Mientras numd > 0 Hacer
			r= numd Mod 2
			bin=ConvertirATexto(r)+bin
			numd=Trunc(numd/2)
		FinMientras
	FinSi
	Escribir "El numero convertido a binario es: ",bin
FinAlgoritmo