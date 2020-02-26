using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class QuitGameButton : MonoBehaviour
{
	public GameObject PanelToOpen;
	public GameObject CurrentPanel;
	public GameObject GameScreen;

	public void OpenPanel()
	{
		if (PanelToOpen != null)
		{
			PanelToOpen.SetActive(true);
			CurrentPanel.SetActive(false);
			GameScreen.SetActive(false);
		}
	}

	public void RestartGame()
	{
		//Debug.Log("this work");
		//SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
		SceneManager.LoadScene("Gameplay"); // loads current scene
	}
}
