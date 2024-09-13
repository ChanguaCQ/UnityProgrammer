using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public Text scoreText;  // Referencia al texto del Canvas para mostrar el puntaje
    private int totalScore;

    private void Awake()
    {
        // Configurar esta clase como singleton para acceso fácil desde otras clases
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Método para añadir puntos al puntaje total
    public void AddPoints(int points)
    {
        totalScore += points;
        UpdateScoreUI();
    }

    // Método para actualizar el texto del canvas
    private void UpdateScoreUI()
    {
        scoreText.text = "Score: " + totalScore;
    }
}