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
			PanelToOpen.SetActive(true);
			CurrentPanel.SetActive(false);
		}
	}
}
