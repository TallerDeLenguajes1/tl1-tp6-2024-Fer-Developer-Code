#####Preguntas y Respuestas
¿String es un tipo por valor o un tipo por referencia?
En C#, string es un tipo por referencia. Sin embargo, debido a su inmutabilidad (es decir, no puedes cambiar el valor de una cadena una vez creada), a menudo se comporta como un tipo por valor. Cuando modificas una cadena, en realidad estás creando una nueva cadena y cambiando la referencia.

####¿Qué secuencias de escape tiene el tipo string?
Las secuencias de escape en C# son combinaciones de caracteres que comienzan con una barra invertida (\) seguida de una letra o una combinación de dígitos. Aquí están algunas de las secuencias de escape más comunes:

\\n: Nueva línea
\\t: Tabulación horizontal
\\': Comilla simple
\\": Comillas dobles
\\\\: Barra invertida
\\a: Campana (alerta)
\\b: Retroceso
\\f: Avance de página
\\r: Retorno de carro
\\v: Tabulación vertical
\\?: Signo de interrogación literal
\\ooo: Carácter ASCII en notación octal
\\xhh: Carácter ASCII en notación hexadecimal
\\xhhhh: Carácter Unicode en notación hexadecimal
¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
El carácter @ antes de una cadena de texto en C# se utiliza para crear cadenas literales. Esto significa que las secuencias de escape no se procesan y se tratan como texto normal. Por ejemplo, @"\\n" se interpretará como la cadena de dos caracteres \ y n, en lugar de una nueva línea.

El carácter $ antes de una cadena de texto en C# se utiliza para crear cadenas interpoladas. Esto permite insertar expresiones dentro de las cadenas que se evaluarán y se convertirán en texto. Por ejemplo, $"Hola, {nombre}" reemplazará {nombre} con el valor de la variable nombre.
