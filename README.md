# Plataformas-Zorrito
## Detección de colisiones
Podemos detectar el contacto entre dos o más objetos en el juego en dos situaciones: 
1. Cuando dos objetos impenetrables (sólidos) se tocan
2. Cuando un objeto ingresa en un área (un objeto atravesable)
 
Para el primer caso usaremos la función OnCollisionEnter2D(), para el segundo emplearemos la función OnTriggerEnter2D().
##### OnCollisionEnter2D()
```C#
  private void OnCollisionEnter2D(Collision2D collision)
    {
        //instrucciones a realizarse cuando se detecte la colisión
    }
```
##### OnTriggerEnter2D()
```C#
  private void OnTriggerEnter2D(Collider2D other)
    {
        //instrucciones a realizarse cuando se detecte ingreso a la zona trigger
    }
```
