using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameObject GameScreen;
    public GameObject TitleScreen;
    public void OpenPanel()
    {
        GameScreen.SetActive(true);
        TitleScreen.SetActive(false);
    }
}
