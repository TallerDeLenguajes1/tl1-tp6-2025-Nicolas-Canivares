[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)

# Respuestas Ejercicio 4

## ¿String es un tipo por valor o un tipo por referencia?
En C#, `string` es un tipo por **referencia**, pero se comporta como si fuera por valor en muchos aspectos porque es **inmutable**.

---

## ¿Qué secuencias de escape tiene el tipo string?

| Secuencia | Significado                     |
|-----------|----------------------------------|
| `\n`      | Nueva línea (line feed)         |
| `\r`      | Retorno de carro (carriage return) |
| `\t`      | Tabulación horizontal           |
| `\\`      | Barra invertida (`\`)           |
| `\"`      | Comillas dobles (`"`)           |
| `\'`      | Comillas simples (`'`)          |
| `\b`      | Retroceso (backspace)           |
| `\f`      | Avance de página (form feed)    |
| `\a`      | Sonido de alerta (beep)         |
| `\v`      | Tabulación vertical             |
| `\0`      | Carácter nulo (NULL)            |
| `\uXXXX`  | Unicode (hexadecimal de 4 dígitos) |
| `\xXX`    | Unicode (hexadecimal de 1 a 4 dígitos) |

---

## ¿Qué sucede cuando se utiliza `@` y `$` antes de una cadena de texto?

### `@` (Verbatim String)
- Ignora las secuencias de escape.
- Permite escribir cadenas multilínea.
- Las comillas dobles se escapan como `""`.

### `$:` (Interpolación de cadenas)
    
- Permite insertar variables o expresiones directamente dentro del string, usando {}

