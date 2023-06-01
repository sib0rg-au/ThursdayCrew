using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatSoundTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource m_AudioSource;
    Collider m_Collider;
    public GameObject player;
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        m_Collider = GetComponent<Collider>();
    }

  
    private void OnTriggerEnter(Collider col)
    {
       if (col.tag == "Player")
        {
            
            m_AudioSource.Play();
            Debug.Log("Squeak");
            m_Collider.enabled = false;
        }
        
    }
}
