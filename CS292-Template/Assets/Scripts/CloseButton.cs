﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
	public GameObject Panel;

	public void ClosePanel()
	{
		if (Panel != null)
		{
			//AudioSource audio = GetComponent<AudioSource>();
			//audio = this.GetComponent<AudioSource>();
			//audio.Play();
			Panel.SetActive(false);
			Time.timeScale = 1;
		}
	}
}
