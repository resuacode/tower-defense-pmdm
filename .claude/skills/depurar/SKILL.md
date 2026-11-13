---
name: depurar
description: Diagnostica un error o comportamiento inesperado en Unity leyendo primero la consola, explica la causa al alumno y solo después propone el arreglo. Usar cuando haya errores de compilación, excepciones en Play, algo que no se ve o no se mueve, o el alumno diga "no funciona".
argument-hint: "[síntoma]"
---

# Depurar en Unity

Regla del proyecto: **primero se lee la consola y se explica el error; luego se corrige**.

## 1. Recoger datos
1. `read_console(types=["error","warning"], include_stacktrace=true, format="detailed")`.
2. `mcpforunity://editor/state`: ¿está compilando, en Play o con una recarga pendiente? Si el estado sale `stale`, haz una lectura real antes de sacar conclusiones.
3. Si el fallo es visual o de comportamiento y no hay errores, inspecciona el objeto (`find_gameobjects` y luego `mcpforunity://scene/gameobject/{id}/components`) y haz una captura.
4. Reproduce el fallo con los mínimos pasos posibles.

## 2. Explicar (antes de tocar código)
Escribe para el alumno:
- **Qué dice el error**, traducido a palabras sencillas (por ejemplo, `NullReferenceException`: «intentamos usar una referencia que está vacía»).
- **Dónde ocurre:** archivo y línea con enlace, y qué estaba haciendo esa línea.
- **Por qué ocurre:** la causa raíz, no solo el síntoma. Por ejemplo: «el campo no está asignado en el Inspector» o «se busca en `Awake` antes de que exista».
- Si hay varias causas posibles, ordénalas por probabilidad y di cómo comprobar cada una.

## 3. Corregir
1. Propón el arreglo más pequeño que resuelva la causa raíz y aplícalo. Si es un script, sigue `/script`: el registro del §14 incluye las correcciones.
2. Vuelve a compilar y lee la consola: el error tiene que haber desaparecido sin que salgan otros nuevos.
3. Comprueba en Play o con una captura que el comportamiento es el esperado.
4. Si el fallo enseña algo útil, propón una pregunta al alumno para que lo explique con sus palabras.

No ocultes errores con `try/catch` vacíos ni comprobaciones de `null` que tapen un campo sin asignar: corrige la causa.
