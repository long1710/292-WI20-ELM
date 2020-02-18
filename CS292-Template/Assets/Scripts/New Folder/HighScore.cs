using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text txt;
    private int score;
    private int highscore = 0;
    public static HighScore instance {get; private set;}
    // Start is called before the first frame update
    void Awake(){
        instance = this;
    }
    void Start()
    {   

        score = highscore;
        txt = txt.GetComponent<Text >();
        txt.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(score > highscore){
            highscore = score;
            txt.text = "score: " + score.ToString();
        }
    }
    public void changeScore(int amount){
        score += amount;
    }
}
