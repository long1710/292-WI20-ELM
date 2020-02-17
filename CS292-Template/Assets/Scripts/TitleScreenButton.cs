using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreenButton : MonoBehaviour
{
	public GameObject PanelToOpen;
	public GameObject CurrentPanel;
	public GameObject GamePanel;

	public void OpenPanel()
	{
		if (PanelToOpen != null)
		{
			PanelToOpen.SetActive(true);
			CurrentPanel.SetActive(false);
			//This is to ensure that the Title Screen is visible and not obstructed by the Game Screen
			GamePanel.SetActive(false);
		}
		
	}
}
