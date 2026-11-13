---
name: escena
description: Monta o modifica escenas, prefabs, cámaras, luces o UI en Unity a través del MCP siguiendo la organización del proyecto. Usar cuando haya que colocar casillas del Tower Defense Kit, crear prefabs (castillo, torres, enemigos), configurar Cinemachine o tocar la jerarquía de un nivel.
argument-hint: "[qué montar]"
---

# Escenas y prefabs con el MCP

Usa la skill `unity-mcp-skill` para la sintaxis de las herramientas. Aquí van las reglas de este proyecto.

## Antes
1. Lee `mcpforunity://editor/state` y la escena activa (`manage_scene get_active`). Anota si ya tenía cambios sin guardar (`isDirty`), para no mezclarlos con los tuyos.
2. Mira la jerarquía (`get_hierarchy`) y los prefabs existentes en `Assets/Prefabs` antes de crear algo nuevo.

## Dónde y cómo se llama cada cosa
- **Escenas:** `Assets/Scenes/Levels/Level01_Meadow.unity`, `Assets/Scenes/Menus/MainMenu.unity`… Nada de `SampleScene` ni de escenas sueltas.
- **Prefabs:** `Prefabs/{Player,Enemies,Towers,Effects,UI}` y `Prefabs/Props` (castillo, decorado compuesto). En PascalCase: `Castle`, `Tower_Arrow_Lv1`, `Enemy_Zombie`.
- **Modelos:** los FBX se usan desde `Assets/ThirdParty/Kenney*/Models/FBX format/` sin copiarlos. El prefab propio envuelve al FBX, y los scripts y colliders van en el prefab, no en el FBX.
- **Materiales propios:** `Assets/Materials`. Los FBX ya traen su material `colormap` y se ven bien en URP; no los dupliques sin motivo.
- **Jerarquía del nivel:** objetos raíz vacíos que agrupan (`--- Environment`, `Path`, `BuildSpots`, `Castle`, `Cameras`, `Lighting`, `Managers`). Las casillas de suelo se marcan como `Static`.

## Medidas de los packs
- Las casillas del Tower Defense Kit miden **1×1 unidad**: coloca en coordenadas enteras y gira en múltiplos de 90°.
- `character-knight` mide algo más de media casilla. Mantén la misma escala en todos los personajes; si se cambia, se cambia en el importador, no en cada instancia.
- Las torres se montan apilando piezas (`*-bottom`, `*-middle`, `*-top`, `*-roof`) y un arma (`weapon-ballista`…) como hijos de un prefab.

## Cámara (Cinemachine 3)
- La `Main Camera` lleva `CinemachineBrain`; las vistas son `CinemachineCamera` (`manage_camera create_camera`). En los niveles, la cámara es fija con vista isométrica.

## Problemas ya vistos con el MCP
- `manage_asset move` puede responder `MoveAsset call failed` **aunque el movimiento se haya hecho**. Comprueba en disco y con `manage_asset get_info` antes de reintentar.
- Borra los objetos de prueba por su `instanceID` (`search_method: by_id`), no por nombre.
- Las capturas van a `Temp/McpScreenshots` (`output_folder`) para no llenar `Assets/` de imágenes.

## Después
1. Comprueba el resultado con una captura (`manage_camera screenshot`, `include_image: true`, `max_resolution` de 512) y enséñasela al alumno.
2. `read_console` sin errores.
3. Guarda la escena (`manage_scene save`) solo cuando el alumno esté de acuerdo con el resultado.
4. Si hay escenas nuevas en el juego, actualiza Build Profiles (`manage_build`), solo con escenas del juego y en orden.
