using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip Projectile;
    public AudioClip PowerUp;
    AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        source.playOnAwake = false;
     
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "projectile"){
            source.clip = Projectile;
            source.Play();
        }
        if(other.tag == "powerUp"){
            source.clip = PowerUp;
            source.Play();
        }
    }
}
