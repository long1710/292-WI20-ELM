using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
