using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
	public GameObject Panel;

	public void ClosePanel()
	{
		if (Panel != null)
		{
			
			StartCoroutine(playSound()); //call helper
			
		}
	}

	IEnumerator playSound()
	{
		AudioSource source = GetComponent<AudioSource>(); //get sound
		source.Play();
		yield return new WaitWhile(() => source.isPlaying); //wait until sound has played
		//do something
		Panel.SetActive(false); //then set the panel to false
		Time.timeScale = 1;
	}
}
