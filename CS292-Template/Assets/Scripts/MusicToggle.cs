using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicToggle : MonoBehaviour
{

    private bool muted;
    // Start is called before the first frame update
    public void Start()
    {
        Debug.Log(AudioListener.volume);
    }
   public void SetAudio()
    {
        Debug.Log(AudioListener.volume);
        if (muted == false)
        {
            AudioListener.volume = 0;
            muted = true;
        }

        else
        {
            AudioListener.volume = 1;
            muted = false;
        }
    }
}
