using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
	public GameObject titleScreen;
	public GameObject gameScreen;

	public void Retry()
	{
		StartCoroutine(playSound()); //call helper
		
	}

	IEnumerator playSound()
	{
		AudioSource source = GetComponent<AudioSource>(); //get sound
		source.Play();
		yield return new WaitWhile(() => source.isPlaying); //wait until sound has played
															//do something
		//PanelToOpen.SetActive(true);
		//CurrentPanel.SetActive(false);
        SceneManager.LoadScene("Gameplay"); //reload game
		titleScreen.SetActive(false); //but hide title screen //DOESNT WORK
		gameScreen.SetActive(true); //and jump to game screen
	}
}
