using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public AudioSource audioSource;

    public void Back()
    {
        PlayerPrefs.SetFloat("volume", audioSource.volume);
    }
}
