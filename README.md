# Problema de las 8 reinas

![8 reinas](https://upload.wikimedia.org/wikipedia/commons/a/ad/Ocho_reinas_reina_atacar_fila.JPG)

Este problema es un famoso acertijo en el que se intenta buscar una forma de colocar 8 fichas reina dentro de un tablero de 8x8 casilleros. Como cada reina puede amenazar en forma vertical, horizontal y diagonal.

Sabemos que cada reina tiene que estar en filas y columnas distintas para no amenazarse entre sí. Pero aún tenemos que solucionar el problema de que no se amenacen en diagonal. Para esto, debemos de sumar y restar el valor de la columna y fila en la que están posicionados dos reinas.

```code
  fila de reina 1 - columna de reina 1 != fila de reina 2 - columna de reina 2
  fila de reina 1 + columna de reina 1 != fila de reina 2 + columna de reina 2
```

Este acertijo se usa para mejorar la algoritmos de búsquedas de alta complejidad con pocos recursos.

Actualmente hay un desafío donde se intenta buscar una solución para colocar mil reinas en un tablero de mil x mil casillas (en este desafío hay un premio de más de un millón de dólares).
