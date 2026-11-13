using UnityEngine;

// Mueve al enemigo por los waypoints de un EnemyPath, uno detrás de otro.
public class EnemyPathFollower : MonoBehaviour
{
    [SerializeField] private EnemyPath path;
    // Unidades (casillas) por segundo. En la sesión 4 pasará a un ScriptableObject.
    [SerializeField] private float speed = 1.5f;
    // Rapidez con la que gira hacia su dirección; más alto = giro más brusco.
    [SerializeField] private float turnSpeed = 10f;

    // Índice del waypoint al que se dirige ahora.
    private int targetIndex;

    private void Start()
    {
        if (path == null || path.Count == 0)
        {
            Debug.LogError($"{name}: falta asignar un EnemyPath con waypoints.", this);
            enabled = false;
            return;
        }

        // Empieza en el primer punto (el spawn) y se dirige al segundo.
        transform.position = path.GetWaypointPosition(0);
        targetIndex = 1;
    }

    private void Update()
    {
        Vector3 target = path.GetWaypointPosition(targetIndex);

        // Avanza como máximo speed * deltaTime: nunca se pasa del punto y se para con Time.timeScale = 0.
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        Vector3 direction = target - transform.position;
        if (direction.sqrMagnitude > 0.0001f)
        {
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, turnSpeed * Time.deltaTime);
        }

        if (transform.position == target)
        {
            targetIndex++;

            if (targetIndex >= path.Count)
            {
                ReachEnd();
            }
        }
    }

    private void ReachEnd()
    {
        // De momento solo desaparece; en la sesión 11 quitará vida al castillo.
        Destroy(gameObject);
    }
}
