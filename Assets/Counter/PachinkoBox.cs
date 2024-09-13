using UnityEngine;

public class PachinkoBox : MonoBehaviour
{
    public int points;  // Puntos que esta caja otorga

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            // Llamar al manejador del puntaje y sumarle los puntos correspondientes
            ScoreManager.Instance.AddPoints(points);
        }
    }
}

