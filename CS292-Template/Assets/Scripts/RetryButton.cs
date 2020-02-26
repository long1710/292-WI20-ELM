using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetryButton : MonoBehaviour
{
	public GameObject PanelToOpen;
	public GameObject CurrentPanel;

	public void OpenPanel()
	{
		if (PanelToOpen != null)
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
		PanelToOpen.SetActive(true);
		CurrentPanel.SetActive(false);
	}
}
