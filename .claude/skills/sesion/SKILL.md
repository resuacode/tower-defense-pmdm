---
name: sesion
description: Empieza una sesión de clase del roadmap (Docs/ROADMAP.md) del tower defense. Usar cuando el alumno diga "/sesion N", "empezamos la sesión N" o "siguiente sesión". Fija el objetivo, explica el concepto relacionándolo con el juego y divide la sesión en pasos pequeños con commit.
argument-hint: "[número de sesión]"
---

# Sesión de clase

Cada sesión tiene **un objetivo del juego, un concepto de programación y un commit al terminar**. Es material didáctico: el alumno tiene que entender lo que se hace.

## 1. Preparar
1. Lee la fila de la sesión `$ARGUMENTS` en `Docs/ROADMAP.md`. Sin número, busca la primera sesión sin hacer comparando con el diario (§16 de `Docs/GDD.md`) y el `git log`, y confirma con el alumno.
2. Lee los apartados del GDD que afectan a la sesión (mecánicas, controles, niveles, personajes) y respeta lo marcado como *(propuesta)*: si la sesión depende de algo sin decidir, pregunta antes.
3. Comprueba el punto de partida:
   - `git status` limpio; si no lo está, avisa antes de empezar;
   - estado del Editor por MCP (`mcpforunity://editor/state`) y `read_console` sin errores;
   - qué scripts, prefabs y escenas de sesiones anteriores existen.

## 2. Presentar (antes de tocar nada)
Escribe un mensaje corto con:
- **Objetivo:** qué se verá funcionando en Unity al terminar.
- **Concepto:** qué problema resuelve y por qué esta solución, en pocas líneas, ligado al juego. Por ejemplo: colas con las oleadas, máquinas de estados con la IA del zombie, `ScriptableObject` con `TowerData`, eventos con el cobro de monedas.
- **Pasos:** de 3 a 6 pasos pequeños, cada uno comprobable en el Editor.
- **Qué no entra:** lo que se deja para otra sesión, para no inflar el alcance.

Espera a que el alumno confirme o ajuste los pasos.

## 3. Ejecutar
- Para cada script, sigue la skill `/script`.
- Para escenas, prefabs, cámaras o UI montados con el MCP, sigue `/escena`.
- Si algo falla, sigue `/depurar`.
- Tras cada paso, enseña el resultado (consola limpia y, si es visual, una captura) antes de seguir.

## 4. Cerrar
1. Repasa con el alumno lo aprendido en dos o tres frases y deja **una pregunta** para que lo explique con sus palabras.
2. Si la sesión cambió el diseño (controles, valores, mecánicas), actualiza el GDD para que describa el juego tal y como es.
3. Ejecuta `/cerrar` para el commit y el diario.
