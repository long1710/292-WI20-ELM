using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIHealthBar : MonoBehaviour
{
    public GameObject OneHit;
    public GameObject TwoHit;
    public GameObject ThreeHit;
    public GameObject FourHit;
    public GameObject FiveHit;

    public static GUIHealthBar instance {get; private set;}
    // Start is called before the first frame update

    GameObject[] HealthBar;
    void Awake(){
        instance = this;
    }

    void Start()
    {
        HealthBar = new GameObject[] {OneHit, TwoHit, ThreeHit, FourHit, FiveHit};

    }

    public void SetValue(int value){
        int health = 4 - value;
        if(health == 4)
        {
            RestartGame();
        }

        HealthBar[health].SetActive(false);

        
    }
    public void Update()
    {
       
    }
    public void RestartGame()
    {
        Debug.Log("this work");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }
}
