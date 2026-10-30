# Hoja de ruta

Fechas orientativas. Versión casi final en **enero** y entrega en **febrero** (confirmar la fecha exacta en clase y dejar dos semanas de margen).

## Calendario

| Cuándo | Hito | Qué debe estar hecho |
|---|---|---|
| Finales de octubre | 1. Concepto | Repositorio con `.gitignore` y estructura, GDD v0.2, proyecto Unity 6 URP vacío y paquetes instalados |
| Noviembre | 2. Prototipo | Camino con waypoints, un enemigo, una torre, parcelas de construcción, monedas y héroe moviéndose, todo con cubos |
| Mediados de noviembre a diciembre | 3. Estructura | Menú principal, pausa, opciones con Audio Mixer, victoria y derrota, créditos, flujo de escenas y guardado |
| Diciembre | 4. Contenido | Los 3 niveles, modelos de Shape, audio definitivo y las 7 mecánicas |
| Enero | 5. Pulido | Iluminación, partículas, game feel, mando y pruebas con 3 jugadores. **Versión casi final** |
| Febrero | 6. Entrega | Build de Windows, publicación en itch.io, GDD en PDF y postmortem |

## Sesiones de clase sugeridas

Cada sesión tiene un objetivo, un concepto de programación que se explica antes de escribir código y un commit al terminar. Orden recomendado:

| # | Objetivo del juego | Concepto que se explica | Hito |
|---|---|---|---|
| 1 | Crear repo, estructura y primer commit | Git, `.gitignore` y por qué no se sube `Library` | 1 |
| 2 | Escena de prueba con camino y cámara fija | Transform, escenas y Cinemachine | 2 |
| 3 | El enemigo recorre waypoints | Listas, índices y `Vector3.MoveTowards` | 2 |
| 4 | Datos de enemigos en `ScriptableObject` | Separar datos y lógica | 2 |
| 5 | Oleadas con `WaveSpawner` | Corrutinas y colas | 2 |
| 6 | Movimiento del héroe con Input System | Acciones de entrada, teclado y mando | 2 |
| 7 | Torre que apunta y dispara | Detección con colliders, vectores y rotación | 2 |
| 8 | Proyectiles y *object pooling* | Instanciar frente a reutilizar | 2 |
| 9 | Monedas, economía y HUD | Eventos y desacoplar sistemas | 2-3 |
| 10 | Parcelas de construcción y menú de torre | Interacción y estados | 3 |
| 11 | `GameManager`, victoria y derrota | Singleton y máquina de estados de partida | 3 |
| 12 | Menú principal, pausa y `Time.timeScale` | Escenas, carga y tiempo escalado | 3 |
| 13 | Opciones y Audio Mixer | Parámetros expuestos y `PlayerPrefs` | 3 |
| 14 | Créditos y flujo completo de escenas | Cargar escenas y persistir datos | 3 |
| 15 | IA del enemigo con estados | Patrón de máquina de estados | 4 |
| 16 | Torre de ralentización y combinaciones | Efectos temporales y modificadores | 4 |
| 17 | Reparar torres y habilidad del héroe | Tiempo de recarga y áreas de efecto | 4 |
| 18 | Jefe con fases | Estados y eventos de fase | 4 |
| 19 | Modelos de Shape y paleta común | Importación, materiales y coherencia visual | 4 |
| 20 | Nivel 2 y 3 con progresión | Diseño de niveles y curva de dificultad | 4 |
| 21 | Guardado de progreso | JSON y `PlayerPrefs` | 4 |
| 22 | Iluminación y postprocesado | Luces, volúmenes URP | 5 |
| 23 | Partículas y game feel | Screen shake, hit stop, *squash and stretch* | 5 |
| 24 | Música, SFX y variaciones | Mixer, pitch aleatorio y transiciones | 5 |
| 25 | Pruebas con jugadores y ajuste | Observar sin explicar y registrar cambios | 5 |
| 26 | Build, itch.io, GDD en PDF y postmortem | Build Profiles y publicación | 6 |

## Lista de comprobación de la entrega

- [ ] Menú principal con Jugar, Opciones, Créditos y Salir
- [ ] Pausa con Continuar, Opciones y Volver al menú, deteniendo el juego de verdad
- [ ] Victoria y derrota con reintentar y volver al menú
- [ ] Opciones: volumen de música y de efectos por separado, aplicado al momento y guardado
- [ ] Créditos con todos los recursos de terceros
- [ ] 3 niveles diferenciados y al menos 2 escenas de juego
- [ ] Al menos 3 mecánicas (objetivo: 5 o más combinadas)
- [ ] Música y efectos de sonido
- [ ] Build de Windows jugable de principio a fin y publicada en itch.io con descripción, capturas y controles
- [ ] GDD completo, con diario, pruebas con jugadores y postmortem, exportado a PDF
- [ ] Proyecto ordenado: sin escenas ni assets sin usar, solo paquetes necesarios y Build Profiles correctos
- [ ] Sin IA generativa en gráficos, música, sonidos ni efectos, y uso de IA para código declarado en el GDD
- [ ] Historial de commits repartido a lo largo del curso
