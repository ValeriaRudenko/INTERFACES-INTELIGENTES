using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource zombieAudio;
    void OnTriggerEnter(Collider trigger) {
        if (trigger.gameObject.tag == "Spider") {
            zombieAudio.Play();
            Destroy(trigger.gameObject);
        }
    }
}
