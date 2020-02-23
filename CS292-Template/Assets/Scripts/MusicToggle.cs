using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicToggle : MonoBehaviour
{
    //true if music is off, false if music is on
	private bool muted;
	

	public void SetAudio()
	{
        if (muted == false) //if music is playing
		{
			//an array of all audio sources
			/*AudioSource[] sources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int index = 0; index < sources.Length; ++index)
			{
				sources[index].mute = true; //silences all audio sources
			}*/
			AudioListener.volume = 0;
			muted = true; //sound is now muted
		}

        else
		{
			/*AudioSource[] sources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			for (int index = 0; index < sources.Length; ++index)
			{
				sources[index].mute = false; //turns on audio sources
			}*/
			AudioListener.volume = 100;
			muted = false; //sound is now on
		}

	}
}
