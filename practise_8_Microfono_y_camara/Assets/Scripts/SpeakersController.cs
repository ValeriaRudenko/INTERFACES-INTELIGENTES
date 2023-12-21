using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakersController : MonoBehaviour
{
    private bool isMicrophoneActivated;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            audioSource.clip = Microphone.Start("", true, 10, 44100);
            Debug.Log("Microphone started");
            isMicrophoneActivated = true;
        }

        if (Input.GetKeyUp(KeyCode.R)) {
            Microphone.End("");
            audioSource.Play();
            isMicrophoneActivated = false;
        }
    }
}
