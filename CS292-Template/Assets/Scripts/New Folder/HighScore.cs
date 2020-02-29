using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text txt;
    public int score;
    public static HighScore instance {get; private set;}
    // Start is called before the first frame update
    void Awake(){
        instance = this;
    }
    void Start()
    {   
        score = 0;
        txt = txt.GetComponent<Text >();
        txt.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {   
    
        if(score > PlayerPrefs.GetInt("highscore")){
            PlayerPrefs.SetInt("highscore",  score);
        }
    }
    public void changeScore(int amount){
        score += amount;
        txt.text = "score: " + score.ToString();
    }
}
