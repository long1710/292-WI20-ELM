using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour //use this script for both powerUP: TODO: changename later
{
    public GameObject Icon;
    public GameObject otherIcon;
    void Start() {
        Icon.SetActive(false);
        
    } 
    
    void OnTriggerEnter2D(Collider2D other) { //TODO
        BlazeFoxController controller = other.GetComponent<BlazeFoxController >();
        
        if (controller != null){
            if(Icon.tag == "coffee"){
                if (otherIcon.activeSelf) { otherIcon.SetActive(false); }
                Icon.SetActive(true);
                controller.ChangeSpeed(10);
            }

            if(Icon.tag == "monster" && !otherIcon.activeSelf){
                if (otherIcon.activeSelf) { otherIcon.SetActive(false); }
                Icon.SetActive(true);
                controller.ChangeSpeed(100);
            }
            Destroy(gameObject);
        } 
    }
    
}
