using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIHealthBar : MonoBehaviour
{
    public GameObject FullHealth;
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
        HealthBar = new GameObject[] {FullHealth, OneHit, TwoHit, ThreeHit, FourHit, FiveHit};
        for(int i = 1; i < 6; i++){
            HealthBar[i].SetActive(false);
        }
    }

    public void SetValue(int value){
        int health = 5 - value;
        if(health == 6)
        {
            RestartGame();
        }
        for (int i = 0; i < 6 ;i++){
            if (i == health) {
                HealthBar[i].SetActive(true);
            }
            else {
                HealthBar[i].SetActive(false);
                    /*RestartGame(); */}

        }
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
