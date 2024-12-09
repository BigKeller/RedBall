using UnityEngine;

public class MusicController : MonoBehaviour
{
    private AudioSource audioSource;

    void Awake()
    {
        // Asegúrate de que este objeto persista entre escenas
        DontDestroyOnLoad(gameObject);

        // Obtén el componente AudioSource
        audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        // Inicia la música si no está ya reproduciéndose
        if (!audioSource.isPlaying)
        {
            audioSource.loop = true; // Configura el loop
            audioSource.Play();
        }
    }
}
