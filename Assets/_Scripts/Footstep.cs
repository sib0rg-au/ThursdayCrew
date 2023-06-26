using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footstep : MonoBehaviour
{
    public AudioSource footstepsSound;
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            footstepsSound.enabled = true;
            audio.pitch = Random.Range();
        }
        else
        {
            footstepsSound.enabled = false;
        }
    }
}