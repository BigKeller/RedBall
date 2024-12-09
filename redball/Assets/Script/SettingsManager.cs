using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    [SerializeField] private AudioSource musicAudioSource; // Arrastra aquí el AudioSource desde el Inspector
    [SerializeField] private Slider volumeSlider;          // Arrastra aquí el Slider desde el Inspector

    void Start()
    {
        // Establece el volumen inicial desde el valor del Slider
        if (volumeSlider != null && musicAudioSource != null)
        {
            volumeSlider.value = musicAudioSource.volume;
            volumeSlider.onValueChanged.AddListener(SetVolume);
        }
    }

    public void SetVolume(float volume)
    {
        if (musicAudioSource != null)
        {
            musicAudioSource.volume = volume;
        }
    }
}
