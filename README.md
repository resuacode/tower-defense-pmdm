# [Título provisional] - Tower defense 3D

Proyecto de videojuego para la game jam de clase (módulo PMDM). Un tower defense minimalista en 3D con un héroe que recoge monedas, construye y repara torres. Hecho con **Unity 6 (URP)**.

- Diseño del juego: [`Docs/GDD.md`](Docs/GDD.md)
- Hoja de ruta: [`Docs/ROADMAP.md`](Docs/ROADMAP.md)
- Página de itch.io: (pendiente)

## Cómo crear el proyecto de Unity a partir de este kit

El kit contiene la estructura de carpetas, el `.gitignore` de Unity, el GDD y la documentación, pero **no** el proyecto de Unity, que hay que generar con Unity Hub.

1. En Unity Hub, instala **Unity 6** (cualquier 6000.x estable) y crea un proyecto nuevo con la plantilla **Universal 3D** (URP). Ponle de nombre `tower-defense-unity` o el que prefieras.
2. Cierra Unity y **copia el contenido de este kit dentro de la carpeta del proyecto**: `.gitignore`, `CLAUDE.md`, `README.md`, `Docs/` y las subcarpetas de `Assets/`. Si Windows pregunta, combina las carpetas y no sobrescribas nada que haya creado Unity.
3. Abre una terminal en la carpeta del proyecto y ejecuta:

   ```bash
   git init
   git add .
   git commit -m "Estructura inicial del proyecto y GDD v0.2"
   ```

4. Crea un repositorio vacío en GitHub (sin README ni `.gitignore`, porque ya los tienes) y enlázalo:

   ```bash
   git branch -M main
   git remote add origin https://github.com/TU_USUARIO/TU_REPO.git
   git push -u origin main
   ```

5. Abre el proyecto en Unity y comprueba que no aparecen `Library`, `Temp` ni `Logs` en `git status`.

## Primera limpieza en Unity (requisito de organización)

- Mueve o borra la escena `SampleScene` y guarda las tuyas en `Assets/Scenes/`.
- Revisa los paquetes en **Window > Package Manager**. Instala **Input System** y **Cinemachine**. TextMeshPro viene con la plantilla.
- Si la plantilla trae carpetas o assets de ejemplo en la raíz de `Assets` (por ejemplo `TutorialInfo`), bórralos o muévelos.
- En **File > Build Profiles**, deja solo las escenas del juego.

## Conectar un agente con Unity (MCP)

Unity tiene un servidor MCP oficial dentro del paquete **AI Assistant** (Unity 6 o superior, en beta abierta; requiere una prueba o suscripción de Unity AI). Se activa en *Edit > Project Settings > AI > Unity MCP*. Comprueba los requisitos actuales en la [documentación de Unity](https://docs.unity3d.com/Packages/com.unity.ai.assistant@2.0/manual/unity-mcp-get-started.html).

Recuerda que en este proyecto **la IA solo se usa para el código**: no se usan las funciones de generación de assets de Unity AI. Las reglas completas están en [`CLAUDE.md`](CLAUDE.md).

## Licencias de los recursos

- Tower Defense Kit por Kenney, CC0: <https://kenney.nl/assets/tower-defense-kit>
- Modelos propios hechos con Kenney Shape.

La lista completa y vigente está en el apartado 13 de `Docs/GDD.md` y en la pantalla de créditos del juego.
