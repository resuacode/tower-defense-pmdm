---
name: revisar-hito
description: Audita el proyecto del tower defense antes de cerrar un hito del roadmap o antes de la entrega - organización de Assets, nombres, escenas y paquetes sin usar, Build Profiles, coherencia GDD-juego, recursos y uso de IA declarados, y lista de entrega. Usar cuando el alumno diga "/revisar-hito", "cerramos el hito" o "revisión antes de entregar".
argument-hint: "[número de hito]"
---

# Revisión de hito

Es una **auditoría de solo lectura**: primero se informa y luego se decide qué arreglar. No cambies nada sin preguntar.

## 1. Qué debía estar hecho
Lee en `Docs/ROADMAP.md` la fila del hito `$ARGUMENTS` (o el hito en curso según el diario) y compara cada punto con lo que hay en el proyecto y en `git log`.

## 2. Comprobaciones

| Área | Qué revisar |
|---|---|
| **Assets** | Sin archivos sueltos en la raíz. Todo en las carpetas de `CLAUDE.md`. Nombres en inglés y PascalCase, sin `New Material`, `SampleScene` ni `Script2` |
| **Recursos sin uso** | Escenas, prefabs, materiales y modelos que nadie referencia: para cada candidato, busca su GUID en escenas y prefabs. En los packs de Kenney, propón borrar los modelos sin uso (sillas de ruedas, ayudas, variantes de nieve que no se usen…) solo a partir del hito 5 |
| **Paquetes** | `Packages/manifest.json` solo con lo que usa el juego. Candidatos a quitar: Visual Scripting, Multiplayer Center, Collab Proxy, Rider. MCP for Unity es una herramienta de desarrollo; decidir antes de la entrega si se queda |
| **Build Profiles** | Solo escenas del juego y en orden (menú primero, luego los niveles y los créditos) |
| **Consola** | Sin errores ni avisos propios al abrir el proyecto y al jugar |
| **Código** | Las convenciones de `CLAUDE.md`: `[SerializeField] private`, sin `Find`/`GetComponent` en `Update`, `ScriptableObject` para los datos, Input System, `timeScale`, pooling |
| **GDD** | Describe el juego tal y como es. Revisa también lo que sigue como *(propuesta)* y debería estar cerrado |
| **§13 y créditos** | Cada pack de `ThirdParty` aparece en el §13, en el README y en la escena de créditos, con su licencia |
| **§14 (IA)** | Cada script de `Assets/Scripts` tiene su línea y no hay assets generados con IA |
| **§16 (diario)** | Entradas fechadas y repartidas en el tiempo, igual que los commits |
| **Git** | `git status` limpio, todo confirmado y sin `Library`, `Temp` ni capturas en el historial reciente |

En el hito 6 (entrega), revisa además la «Lista de comprobación de la entrega» de `Docs/ROADMAP.md` punto por punto.

## 3. Informe
Una tabla con ✅ / ⚠️ / ❌ por área, con el detalle de cada problema (archivo y motivo) y un orden recomendado para arreglarlos, cada arreglo en su propio commit. Pregunta al alumno cuáles se arreglan ahora.
