using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class QuitGameButton : MonoBehaviour
{
	public GameObject PanelToOpen;
	public GameObject CurrentPanel;
	public GameObject GameScreen;

	/*public void OpenPanel()
	{
		if (PanelToOpen != null)
		{
			PanelToOpen.SetActive(true);
			CurrentPanel.SetActive(false);
			GameScreen.SetActive(false);
		}
	}*/

	public void RestartGame()
	{
		StartCoroutine(playSound()); //call helper

	}

	IEnumerator playSound()
	{
		AudioSource source = GetComponent<AudioSource>(); //get sound
		source.Play();
		yield return new WaitWhile(() => source.isPlaying); //wait until sound has played
															//do something
		SceneManager.LoadScene("Gameplay"); // loads current scene
	}
}
