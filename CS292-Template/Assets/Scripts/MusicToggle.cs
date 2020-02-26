using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicToggle : MonoBehaviour
{

    private bool muted;
    // Start is called before the first frame update
   public void SetAudio()
    {
        if (muted == false)
        {
            AudioListener.volume = 0;
            muted = true;
        }

        else
        {
            AudioListener.volume = 100;
            muted = false;
        }
    }
}
