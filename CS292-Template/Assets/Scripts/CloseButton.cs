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
			//AudioSource audio = GetComponent<AudioSource>();
			//GetComponent<AudioSource>().PlayClipAtPoint();
			//audio.Play();
			StartCoroutine(example());
			//Panel.SetActive(false);
			//Time.timeScale = 1;
		}
	}

	IEnumerator example()
	{
		AudioSource source = GetComponent<AudioSource>();
		source.Play();
		yield return new WaitWhile(() => source.isPlaying);
		//do something
		Panel.SetActive(false);
		Time.timeScale = 1;
	}
}
