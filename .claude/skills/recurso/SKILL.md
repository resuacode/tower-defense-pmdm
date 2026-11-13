---
name: recurso
description: Añade un recurso de terceros (pack de modelos, sonidos, música, fuentes o texturas) al tower defense comprobando licencia y origen, colocándolo en Assets/ThirdParty y anotándolo en el GDD, el README y los créditos. Usar cuando el alumno añada o quiera añadir un pack externo.
argument-hint: "[ruta o nombre del pack]"
---

# Añadir un recurso de terceros

## 1. Comprobar que se puede usar
1. Lee la licencia del pack (`License.txt` o la página de origen). Solo se acepta **CC0 o CC BY**. Con CC BY, anota el autor exacto y el enlace, porque la atribución es obligatoria.
2. Busca cualquier indicación de que esté **creado con IA** (licencia, descripción o página del autor). Si la hay, **no se usa**: es la regla 4 de `CLAUDE.md`.
3. Comprueba que encaja con la dirección de arte (§10 del GDD). Base medieval con toques de ciencia ficción, en el estilo de bloques de Kenney; si no encaja, se avisa antes de importar.

Si algo de esto falla, para y explica el motivo al alumno.

## 2. Colocarlo
1. Carpeta `Assets/ThirdParty/NombreDelPack/` en PascalCase (por ejemplo `KenneyTowerDefenseKit`). Si se renombra una carpeta ya importada, hazlo desde Unity (`manage_asset move`) para conservar los GUID, y comprueba en disco: el MCP puede dar un falso error.
2. Deja solo lo que Unity usa y el proyecto necesita:
   - **Modelos 3D:** solo **FBX**. Fuera GLB (Unity no lo importa sin un paquete extra) y OBJ (duplica los modelos y no trae animaciones).
   - **Audio:** WAV u OGG.
   - Fuera los accesos directos (`.url`) y las páginas HTML.
   - Se conservan `License.txt` y las previsualizaciones si son pequeñas.
3. Revisa la consola tras la importación, y comprueba con una captura que los materiales se ven bien en URP (no en rosa) y que la escala encaja con una casilla del kit (1×1).

## 3. Anotarlo
- **§13 de `Docs/GDD.md`:** nueva fila con recurso (y versión), tipo, autor, licencia, enlace y dónde se usa.
- **`README.md`:** sección «Licencias de los recursos».
- **Escena de créditos**, cuando exista: añadir el recurso. Si aún no existe, recuérdalo como tarea pendiente en la respuesta.
- **§16 (diario)** si el pack cambia algo del diseño.

## 4. Cerrar
Commit propio solo con el pack y su documentación (`/cerrar`), separado de cualquier otro trabajo.
