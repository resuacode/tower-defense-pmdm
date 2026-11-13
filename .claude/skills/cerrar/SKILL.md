---
name: cerrar
description: Cierra una tarea del tower defense con un commit limpio (un cambio, un commit). Revisa git status, .meta, escenas sin guardar, registro de IA (§14) y diario (§16) del GDD antes de hacer el commit. Usar al terminar cada tarea o cuando el alumno diga "/cerrar", "haz el commit" o "cerramos".
argument-hint: "[resumen de la tarea]"
---

# Cerrar una tarea

## 1. Revisar el estado
1. Unity: si la escena activa tiene cambios sin guardar (`manage_scene get_active` → `isDirty`), pregunta si se guardan antes del commit. `read_console` sin errores.
2. `git status --short` y `git diff --stat`:
   - Cada asset nuevo tiene su `.meta`, y cada `.meta` tiene su asset. Si falta un `.meta`, los GUID cambian en otro clon.
   - No se cuela nada de `Library/`, `Temp/`, `Logs/`, `UserSettings/`, `*.csproj` ni capturas.
   - No hay archivos sueltos en la raíz de `Assets` ni nombres por defecto (`New Material`, `GameObject (1)`…).
   - Solo entran archivos de **esta** tarea. Si aparecen cambios ajenos, como una escena tocada por accidente, pregunta antes de incluirlos.

## 2. Documentación
- **§14 del GDD:** cada script creado o modificado con IA en esta tarea tiene su línea (ver `/script`).
- **§16 del GDD (diario):** si es un avance relevante (algo nuevo que funciona, una decisión de diseño, un cambio de plan), añade o completa la entrada con la fecha de hoy (`### AAAA-MM-DD`), en dos o tres frases.
- Si la tarea cambió el diseño, comprueba que el GDD lo describe tal y como es ahora.

## 3. Commit
- Añade los archivos por ruta (`git add <rutas>`), no con `git add -A` a ciegas.
- Mensaje en español, en presente, con una primera línea corta y clara («Añade el movimiento del héroe con el Input System»), una línea en blanco y, si hace falta, el porqué en una o dos líneas.
- Termina el mensaje con la línea de atribución que indique la sesión de Claude Code.
- No hagas `push` salvo que el alumno lo pida.

## 4. Informar
Di el hash y el título del commit y qué queda pendiente, si hay algo.
