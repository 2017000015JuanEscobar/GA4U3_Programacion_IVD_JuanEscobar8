Algoritmo Lecc35_Act1_Inc3
	Definir opc, c Como Entero
    Definir jn Como Caracter
    Repetir
        Escribir "Elija una opci?n:"
        Escribir "1- Piedra"
        Escribir "2- Papel"
        Escribir "3- Tijeras"
        Leer opc
        c = Aleatorio(1, 3) 
        Si c = 1 Entonces
            Escribir "La computadora eligi?: Piedra"
        Sino
            Si c = 2 Entonces
                Escribir "La computadora eligi?: Papel"
            Sino
                Escribir "La computadora eligi?: Tijeras"
            FinSi
        FinSi
        Si opc = c Entonces
            Escribir "?Es un empate!"
        Sino
            Si (opc = 1 Y c = 3) O (opc= 2 Y c = 1) O (opc	 = 3 Y c = 2) Entonces
                Escribir "?Usted Gano!"
            Sino
                Escribir "?Gan? la computadora! Que mal :("
            FinSi
        FinSi
        Escribir "?Quieres jugar de nuevo? (S/N):"
        Leer jn
    Hasta Que jn = "N" O jn = "n"
    Escribir "?Gracias por jugar!"
FinAlgoritmo
