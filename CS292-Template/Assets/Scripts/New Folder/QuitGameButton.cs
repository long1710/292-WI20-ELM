using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class QuitGameButton : MonoBehaviour
{
	//public GameObject PanelToOpen;
	//public GameObject CurrentPanel;
	//public GameObject GameScreen;

    public void QuitGame()
	{
		StartCoroutine(playSound());
	}

	IEnumerator playSound()
	{
		AudioSource source = GetComponent<AudioSource>(); //get sound
		source.Play();
		yield return new WaitWhile(() => source.isPlaying); //wait until sound has played
															//do something
		//SceneManager.LoadScene("Gameplay"); // loads current scene
        Application.Quit();
		Debug.Log("Game is exiting");
	}
}
