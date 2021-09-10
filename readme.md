# SMELLS CODE
## A continuación se indicarán todos los smells code que se hallan encontrado más una descripción y ejemplo de 
## refactorización que se hizo.

### numero 1 
Partes de código que no se usan. - Librerías que no se usan El código colocaba librerías que si bien son estándar en la creación de una nueva aplicación de consola en C# 
no se las usa y hacen que el código sea innecesariamente más largo. se borró using System.Collections.Generic, System.Linq, Text, System.Threading.Tasks;

El programa puede recibir argumentos (*args) en la llamada del main pero como no se lo usaban se lo quito.

### numero 2
Main contiene todo el código - Método Grande .- Al contener todo el código en el main afecta a al uso y crea un método que realiza muchas cosas, la solución es 
dividir las tareas en funciones que sean invocadas.

### numero 3
Variables con nombres abstraídos a letras - identificadores excesivamente cortos. - Una mala práctica es abstraer variables en solo letras, 
esto si bien empequeñece el código dificulta la lectura de este y por lo tanto es más difícil entenderlo, se puso nombres más descriptivos.

### numero 4
doble invocación a condiciones - Código duplicado. - En el código se pudo ver una doble llamada a la misma condición solo variando la marca del jugador,
se solucionó implementando una función que recibe.

mismas condiciones diferentes entradas - Código duplicado. - Al implementar una condición para ver si existe 3 marcas en línea, se implementó todas las combinaciones
de líneas para el 3 en raya con la misma condición solo variando casillas, para evitar esto se implementó una función.

### numero 5
Refactorización del turno - Complejidad Artificiosa. - En vez de invocar el turno 2 veces en la condición se la puede refactorizar para que
cambie de estado una vez fuera de la función.

Condición innecesariamente dentro de un loop - Complejidad Artificiosa. - Se implemento una función que comparaba la posición de la marca innecesariamente con
todas las posiciones de la tabla, se lo saco del loop y se marcó directamente con las posiciones de la marca.






