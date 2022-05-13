Proceso trabajo1
	

	definir promedio Como Numero 
	definir n1 Como Numero
	definir g Como Numero
FinProceso
Funcion promedio  <- radicar (n1 , g)
	Si ABS = ((g* g)/ n1) Entonces
		acciones_por_verdadero
	SiNo
		acciones_por_falso
	Fin Si
	promedio <- (radicando/g+g)/2 
Fin Funcion

Funcion Numero <- raizcuadrada ( radicando  )
	Si expresion_logica Entonces
		acciones_por_verdadero
	SiNo
		acciones_por_falso
	Fin Si
Fin Funcion

