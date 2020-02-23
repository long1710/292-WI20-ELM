using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class MusicToggle : MonoBehaviour

{
    public void changeMusic()
	{
        if (AudioListener.volume == 0) //if sound is off
		{
			AudioListener.volume = 100; //turn sound on
		}

        else //if sound is on
		{
			AudioListener.volume = 0; //turn sound off
		}
	}
}
