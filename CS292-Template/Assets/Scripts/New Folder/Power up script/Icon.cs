using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon : MonoBehaviour
{
    public GameObject IconSprite;
    private float countdown;
    // Start is called before the first frame update
    void Start()
    {
        if(IconSprite.activeSelf){
            countdown = 5;
        }
    }

    // Update is called once per frame
    void Update()
    {   
        if(IconSprite.activeSelf){
            if(countdown > 0){
                countdown -= Time.deltaTime;
            }
            else{
                IconSprite.SetActive(false);
                countdown = 5;
            }
        }
        //TODO: Re-check when drink monster again
    }
}
