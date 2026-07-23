Algoritmo Lecc32_Act3_Inc1
	Escribir "Nombre: Juan Pablo Escobar de Paz"
	Escribir "IV Bachillerato D, clave 8"
	Definir l1, l2, l3 Como Real
    Escribir "Ingrese la medida del lado 1:"
    Leer l1
    Escribir "Ingrese la medida del lado 2:"
    Leer l2
    Escribir "Ingrese la medida del lado 3:"
    Leer l3
    Si (l1 + l2 > l3) Y (l1 + l3 > l2) Y (l2 + l3 > l1) Entonces
        Si lado1 = lado2 Y lado2 = lado3 Entonces
            Escribir "El triangulo es EQUILATERO"
        Sino
            Si lado1 = lado2 O lado1 = lado3 O lado2 = lado3 Entonces
                Escribir "El triangulo es ISOSCELES"
            Sino
                Escribir "El triangulo es ESCALENO"
            FinSi
        FinSi
    Sino
        Escribir "Las medidas ingresadas no forman un tri?ngulo."
    FinSi
FinAlgoritmo
