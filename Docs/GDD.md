# [Título provisional] - Documento de diseño (GDD)

> BORRADOR v0.2 (hito 1). Lo marcado como **(propuesta)** está pendiente de decidir o validar.

## 1. Ficha del juego

| | |
|---|---|
| Título | (por decidir) |
| Autor/a | (tu nombre) |
| Género | Tower defense con héroe controlable |
| 2D / 3D | 3D |
| Plataformas | Windows (opcional: Web) |
| Versión de Unity y pipeline | Unity 6 - URP (plantilla Universal 3D) |
| Público objetivo y PEGI | Todos los públicos, PEGI 3-7 (violencia fantástica muy leve) |
| Duración de una partida | 15-20 min (3 niveles de 5-7 min) |
| Repositorio | (enlace) |
| Página de itch.io | (enlace) |

## 2. Concepto

### Resumen
Un tower defense minimalista en 3D en el que un pequeño héroe recorre el campo de batalla recogiendo las monedas que sueltan los enemigos para construir y mejorar torres que protejan el castillo, mientras usa su propia habilidad para cubrir los huecos de la defensa.

### Pilares de diseño (propuesta)
1. **Decisiones claras y rápidas:** poca información en pantalla, cada moneda cuenta.
2. **El jugador no es un espectador:** el héroe se mueve, recoge, repara y ataca, no solo hace clic.
3. **Cada nivel enseña algo nuevo:** una torre, un enemigo o una regla por nivel.
4. **Estilo visual unificado:** una única paleta y piezas sencillas y legibles.

### Referencias
- *Kingdom Rush*: oleadas, tipos de torre y mejoras.
- *Dungeon Defenders*: héroe que juega junto a las defensas.
- *Bloons TD*: lectura inmediata del mapa y de las torres.

### Qué lo hace diferente
El jugador tiene presencia física en el mapa: las monedas no se cobran solas, hay que ir a recogerlas, y eso obliga a decidir entre defender, recolectar o construir.

## 3. Historia y ambientación
Un reino pequeño de estética medieval y colores vivos. El héroe es el último guardián de un castillo asediado por criaturas que avanzan por los caminos. La historia se cuenta con textos breves entre niveles. **(propuesta)**

## 4. Jugabilidad

### Objetivo
Sobrevivir a todas las oleadas de cada nivel sin que los enemigos destruyan el castillo.

### Bucle de juego
Recoger monedas → construir o mejorar torres → sobrevivir a la oleada → recoger más monedas → oleada más difícil.

### Condiciones de victoria y derrota
- **Victoria:** completar la última oleada del nivel 3 con el castillo en pie.
- **Derrota:** la vida del castillo llega a 0.

### Progresión
Cada nivel añade un tipo de torre o de enemigo y las oleadas aumentan de tamaño y variedad. Los niveles superados se desbloquean y guardan.

## 5. Mecánicas **(propuesta, objetivo: 5 o más combinadas)**

| Mecánica | Descripción | Control | Nivel en el que aparece |
|---|---|---|---|
| Construir torres | Se colocan en parcelas libres gastando monedas | `E` / botón `A` | 1 |
| Mejorar o vender torres | Sube el nivel de una torre o la devuelve parcialmente | `Q` / botón `X` | 1 |
| Recoger monedas | Los enemigos las sueltan y el héroe debe ir a por ellas | Automático al acercarse | 1 |
| Habilidad del héroe | Golpe en área con tiempo de recarga | `Espacio` / botón `B` | 2 |
| Torre de ralentización | Reduce la velocidad de los enemigos y se combina con el resto | (torre) | 2 |
| Enemigo que ataca torres | Se detiene a destruir torres, hay que protegerlas o repararlas | (enemigo) | 3 |
| Reparar torres | El héroe restaura las torres dañadas | Mantener `E` / botón `A` | 3 |

**Combinaciones:** la ralentización multiplica el daño de las torres de arco, y la habilidad del héroe sirve para proteger torres bajo ataque. **Sistema complejo previsto:** IA de enemigos con estados (avanzar, atacar torre, huir) y guardado de progreso.

## 6. Controles

| Acción | Teclado | Mando |
|---|---|---|
| Moverse | `WASD` o flechas | Joystick izquierdo |
| Construir / reparar | `E` | Botón `A` |
| Mejorar / vender | `Q` | Botón `X` |
| Habilidad | `Espacio` | Botón `B` |
| Pausa | `Esc` | `Start` |

Los controles se enseñarán con indicaciones en pantalla durante el nivel 1.

## 7. Niveles **(propuesta)**

### Nivel 1: El prado
- **Objetivo:** aguantar 8 oleadas.
- **Novedad:** construcción básica, torre de arco y un enemigo común.
- **Escena:** (por decidir) · **Dificultad:** baja.

### Nivel 2: El bosque
- **Objetivo:** aguantar 10 oleadas con un camino que se bifurca.
- **Novedad:** torre de ralentización, habilidad del héroe y un enemigo rápido.
- **Escena:** (por decidir) · **Dificultad:** media.

### Nivel 3: La fortaleza
- **Objetivo:** aguantar 12 oleadas y derrotar al jefe final, con dos entradas al mapa.
- **Novedad:** enemigo que ataca torres, reparación y jefe.
- **Escena:** (por decidir) · **Dificultad:** alta.

## 8. Personajes y enemigos **(propuesta)**
- **Héroe:** velocidad media, recoge monedas, repara torres y tiene una habilidad en área.
- **Enemigos:** común (camina por el camino), rápido (poca vida), blindado (ataca torres) y jefe (varias fases).

## 9. Interfaz y flujo de pantallas
(por completar en el hito 3: diagrama de escenas, HUD y menús)

## 10. Dirección de arte **(propuesta, por decidir)**
- **Mundo y torres:** Tower Defense Kit de Kenney.
- **Enemigos, monedas, proyectiles e iconos:** modelos propios hechos con Kenney Shape, usando una paleta de 16 colores tomada del kit para que encajen.
- **Héroe:** modelo propio hecho con Kenney Shape, con la misma paleta de 16 colores que el resto de piezas propias. Se anima por código (balanceo al caminar, *squash and stretch* al atacar).
- **Justificación de la coherencia:** el entorno usa el estilo del Tower Defense Kit y todo lo que se mueve o se recoge (héroe, enemigos, monedas, proyectiles, iconos) comparte una paleta y un estilo extruido propios.

## 11. Sonido y música
(por completar)

## 12. Efectos visuales y game feel
(por completar)

## 13. Recursos de terceros

| Recurso | Tipo | Autor | Licencia | Enlace | Dónde se usa |
|---|---|---|---|---|---|
| Tower Defense Kit | Modelos 3D | Kenney | CC0 | https://kenney.nl/assets/tower-defense-kit | Escenarios y torres |

Modelos propios creados con Kenney Shape (herramienta de Kenney): héroe, enemigos, monedas, proyectiles e iconos.

## 14. Declaración de uso de IA
- **Herramientas:** Claude (Claude Code con MCP de Unity). (actualizar con las que se usen realmente)
- **Para qué:** desarrollo del código del juego, explicado en directo en clase como material didáctico. Se irá listando aquí qué scripts se han hecho con ayuda de la IA y cómo (generación, corrección, revisión, explicación).
- **Qué se ha cambiado y qué problemas ha dado:** (por completar)
- **Confirmación:** no se ha usado IA generativa para ningún recurso gráfico, música, efecto de sonido ni efecto visual. No se usan las funciones de generación de assets de Unity AI.

## 15. Aspectos técnicos
(por completar)

## 16. Diario de desarrollo

### 2026-10-16
Elección de género (tower defense) y primer borrador del GDD. Decisiones de arte: Tower Defense Kit para el entorno y Kenney Shape para el héroe y el resto de piezas propias. Ambientación medieval. Versión casi final prevista para enero y entrega en febrero.

## 17. Pruebas con jugadores
(por completar)

## 18. Postmortem
(por completar)
