using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    public Slider sVolumeMusic;
    public AudioSource asMusic;

    private static bool _isMusicInitialized = false; // Flag to track music initialization

    void Start()
    {
        if (!_isMusicInitialized) // Check if music is already initialized
        {
            DontDestroyOnLoad(gameObject); // Make this object persistent across scenes
            _isMusicInitialized = true;
        }

        sVolumeMusic.onValueChanged.AddListener(delegate { VolumeMusic(); }); // Add listener for volume changes
    }

public void VolumeMusic()
{
    float newVolume = sVolumeMusic.value;
    newVolume -= 0.1f;
    newVolume = Mathf.Clamp(newVolume, 0f, 1f);

    asMusic.volume = newVolume;
}

}
