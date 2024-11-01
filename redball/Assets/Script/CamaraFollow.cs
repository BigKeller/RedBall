using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El objeto que la cámara va a seguir (tu personaje)
    public Vector3 offset;   // La diferencia en posición entre la cámara y el personaje

    void Update()
    {
        if (target != null)
        {
            // Actualiza la posición de la cámara para que siga al personaje con el offset
            transform.position = target.position + offset;
        }
    }
}
