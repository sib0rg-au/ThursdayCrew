using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SewerSoundControl : MonoBehaviour
{
    public GameObject ambientAudio;
    public GameObject sewerCollider;
    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Bazinga: Rain audio off");
        ambientAudio.GetComponent<AudioSource>().volume = 0.1f;
        
    }

    private void OnTriggerExit(Collider other)
    {
        ambientAudio.GetComponent<AudioSource>().volume = 0.5f;
    }
}
