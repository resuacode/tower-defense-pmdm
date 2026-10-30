# CLAUDE.md - Instrucciones del proyecto

Proyecto de clase (game jam, módulo PMDM): un **tower defense 3D con héroe controlable**, ambientación medieval, hecho en **Unity 6 con URP**. El diseño completo está en `Docs/GDD.md`: es la fuente de verdad, léelo antes de proponer cambios.

## Reglas que no se pueden saltar

1. **IA solo para código.** Nunca generes ni sugieras generar con IA gráficos, modelos, texturas, música, sonidos ni efectos visuales. Tampoco uses las funciones de generación de assets de Unity AI, ni siquiera para placeholders: los placeholders son cubos, cápsulas y materiales de color de Unity.
2. **El alumno debe entender el código.** Antes de escribir un script, explica en pocas líneas el concepto (qué problema resuelve y por qué esta solución). Después del script, resume qué hace cada parte importante y propón una pregunta para que el alumno lo explique con sus palabras.
3. **Registra el uso de IA.** Cada vez que se cree o modifique un script con ayuda de IA, añade una línea en el apartado 14 de `Docs/GDD.md` (script, qué se hizo, qué se cambió a mano).
4. **Recursos de terceros.** Todo asset externo debe ser CC0 o CC BY, ir en `Assets/ThirdParty/NombreDelPack/` y quedar anotado en el apartado 13 del GDD y en la escena de créditos. Si un pack indica que se ha creado con IA, no se usa.
5. **Un cambio, un commit.** Trabaja en tareas pequeñas con un solo objetivo. Termina cada una con un commit de mensaje claro, y añade una entrada fechada en el apartado 16 (diario) del GDD cuando haya un avance relevante.

## Organización de `Assets`

No dejes archivos sueltos en la raíz de `Assets`. Usa las carpetas que ya existen:
`Scenes/Menus`, `Scenes/Levels`, `Scripts/{Core,Player,Enemies,Towers,UI,Audio,Data}`, `Prefabs/{Player,Enemies,Towers,Effects,UI}`, `Models/{Player,Enemies,Towers,Props}`, `Materials`, `Animations`, `Audio/{Music,SFX,Mixer}`, `UI/Sprites`, `Fonts`, `Data` (ScriptableObjects), `Settings`, `ThirdParty`.

- Nombres descriptivos en inglés para código y assets, en PascalCase (`EnemyPathFollower`, `Tower_Arrow_Lv1`). Nada de `New Material`, `Script2` o `SampleScene`.
- Borra escenas de ejemplo y recursos que no se usen. Solo deben estar instalados los paquetes que usa el juego.
- Los **Build Profiles** solo incluyen las escenas del juego, en orden.

## Convenciones de código (C#)

- Un script, una responsabilidad. Nombre de archivo igual al de la clase.
- Campos configurables en el Inspector con `[SerializeField] private`. Evita `public` salvo que sea necesario.
- Los datos de torres, enemigos y oleadas van en `ScriptableObject` (carpeta `Data`), no en el código.
- Nada de `Find` ni `GetComponent` en `Update`; cachea las referencias en `Awake` o `Start`.
- Todo lo que se pueda pausar debe respetar `Time.timeScale = 0` (cuidado con animaciones de UI: usa tiempo no escalado donde corresponda).
- Entrada con el **Input System** (teclado y mando desde el principio).
- Proyectiles y monedas con **object pooling** cuando haya muchos.
- Comentarios breves en español que expliquen el porqué, no lo obvio.

## Arquitectura prevista

`GameManager` (estado de la partida, vidas del castillo, monedas) · `WaveSpawner` (oleadas) · `EnemyPathFollower` + máquina de estados del enemigo · `Tower` (apuntado y disparo) con datos en `TowerData` · `BuildSpot` (parcelas) · `PlayerController` (héroe) · `AudioManager` (mixer, música y SFX) · `SaveSystem` (`PlayerPrefs` o JSON) · `SceneLoader` (transiciones).

## Arte y coherencia (criterio B8)

- Entorno y torres: Tower Defense Kit de Kenney.
- Héroe, enemigos, monedas, proyectiles e iconos: modelos propios hechos con Kenney Shape, siempre con la **misma paleta de 16 colores** (guardada en `Docs/img/paleta.png`). Los archivos de origen de Shape van en `Docs/ShapeSource`.
- No mezcles estilos: si un asset no encaja, se modifica o se sustituye.

## Qué ya existe y qué no

Si algo del GDD está marcado como *(propuesta)*, es una idea sujeta a cambios: pregunta antes de darla por cerrada. Mantén el GDD actualizado cuando el juego cambie: en la entrega debe describir el juego tal y como es.

## Uso en clase

Al explicar conceptos, relaciónalos con lo que se está construyendo (por ejemplo, listas y colas con las oleadas, máquinas de estados con la IA enemiga, `ScriptableObject` con los datos de torres, eventos con el cobro de monedas). Para depurar, lee primero la consola de Unity y explica el error antes de corregirlo.
