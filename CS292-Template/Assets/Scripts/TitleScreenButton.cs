using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenButton : MonoBehaviour
{

	public void OpenPanel()
	{

		StartCoroutine(playSound()); //call helper
		//}
		
	}

	IEnumerator playSound()
	{
		AudioSource source = GetComponent<AudioSource>(); //get sound
		source.Play();
		yield return new WaitWhile(() => source.isPlaying); //wait until sound has played
															//do something
		//PanelToOpen.SetActive(true);
		//CurrentPanel.SetActive(false);
		//This is to ensure that the Title Screen is visible and not obstructed by the Game Screen
		//GamePanel.SetActive(false);
		SceneManager.LoadScene("Gameplay"); // loads current scene (reset gameplay)
	}
}
