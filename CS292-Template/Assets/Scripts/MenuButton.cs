using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
	public GameObject Panel;

    public void OpenPanel()
	{
        if(Panel != null)
		{
			Panel.SetActive(true);
			Time.timeScale = 0;
		}
	}
    
}
