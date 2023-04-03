using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    void Start()
    {
        Debug.Log(PlayerPrefs.GetFloat("volume"));
        GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("volume");
    }
}