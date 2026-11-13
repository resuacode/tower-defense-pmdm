using System.Collections.Generic;
using UnityEngine;

// Ruta que siguen los enemigos: una lista ordenada de puntos (waypoints).
// Solo guarda la ruta; quien se mueve por ella es EnemyPathFollower.
public class EnemyPath : MonoBehaviour
{
    // El orden de la lista es el orden en que se recorren: del spawn al castillo.
    [SerializeField] private List<Transform> waypoints = new List<Transform>();

    // Lectura sin permitir que otros scripts cambien la lista.
    public int Count => waypoints.Count;

    public Vector3 GetWaypointPosition(int index)
    {
        return waypoints[index].position;
    }

    // Dibuja la ruta en la vista Scene para poder editarla. No aparece en el juego.
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;

        for (int i = 0; i < waypoints.Count; i++)
        {
            if (waypoints[i] == null) continue;

            Gizmos.DrawSphere(waypoints[i].position, 0.12f);

            // Línea hasta el siguiente punto, si existe.
            if (i + 1 < waypoints.Count && waypoints[i + 1] != null)
            {
                Gizmos.DrawLine(waypoints[i].position, waypoints[i + 1].position);
            }
        }
    }
}
