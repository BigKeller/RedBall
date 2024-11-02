using UnityEngine;
using UnityEngine.SceneManagement; 

public class FinishLevelTrigger2D : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level2"); 
        }
    }
}
