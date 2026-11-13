---
name: script
description: Crea o modifica un script C# del juego siguiendo las reglas del proyecto (explicar el concepto, convenciones de CLAUDE.md, compilar y leer la consola por MCP, resumen, pregunta para el alumno y registro de IA en el GDD). Usar siempre que se vaya a escribir o cambiar código C# en Assets/Scripts.
argument-hint: "[NombreClase] [qué debe hacer]"
---

# Script del juego

## 1. Antes de escribir
1. Busca si ya existe algo parecido en `Assets/Scripts` (`Grep` o `find_in_file`) para reutilizarlo en vez de duplicarlo.
2. Decide la carpeta según la responsabilidad: `Scripts/{Core,Player,Enemies,Towers,UI,Audio,Data}`. Nombre en inglés y PascalCase, y el archivo igual que la clase.
3. **Explica el concepto en pocas líneas**: qué problema resuelve y por qué esta solución frente a la alternativa obvia. Relaciónalo con el juego.
4. Si la API de Unity no es trivial (Input System, Cinemachine 3, URP, Animator), compruébala con `unity_reflect` o `unity_docs` cuando el grupo `docs` del MCP esté activo. No confíes solo en la memoria: Cinemachine 3 cambió muchos nombres respecto a la versión 2.

## 2. Escribir (convenciones de CLAUDE.md)
- Un script, una responsabilidad.
- Campos del Inspector con `[SerializeField] private`; nada de `public` salvo que haga falta.
- Datos de torres, enemigos y oleadas en `ScriptableObject` (assets en `Assets/Data`), no en el código.
- Sin `Find` ni `GetComponent` en `Update`: cachea en `Awake` o `Start`.
- Respeta `Time.timeScale = 0`; en la UI animada usa tiempo no escalado.
- Entrada siempre con el **Input System** (`Assets/Settings/InputSystem_Actions.inputactions`), para teclado y mando.
- Object pooling para proyectiles y monedas.
- Comentarios breves en español que expliquen el porqué.
- Mejor un script corto y claro que uno "completo": el alumno lo tiene que poder explicar.

Escribe el archivo con `Write` o `Edit`, o con `create_script` o `script_apply_edits` del MCP.

## 3. Comprobar en Unity
1. Espera a que termine la compilación: lee `mcpforunity://editor/state` hasta `is_compiling: false`. Si el estado sale `stale`, haz una lectura real (por ejemplo `read_console`) antes de concluir nada.
2. `read_console(types=["error","warning"])`. Si hay errores, aplica `/depurar` antes de seguir.
3. Si el script va en un objeto, añádelo con `manage_components`, configura los campos y prueba en Play cuando tenga sentido.

## 4. Después de escribir
1. **Resumen por partes:** qué hace cada bloque importante, en lista corta.
2. **Pregunta para el alumno:** una pregunta concreta para que explique con sus palabras una parte clave. Por ejemplo: «¿qué pasaría si moviéramos el `GetComponent` a `Update`?».
3. **Registro de IA (regla 3):** añade una línea en el §14 de `Docs/GDD.md`:
   `- \`NombreScript.cs\` (AAAA-MM-DD): qué se hizo con IA (generado / corregido / revisado). Cambios a mano: … (o «pendiente de revisar por el alumno»).`
4. No hagas commit aquí: se hace con `/cerrar` al terminar la tarea.
