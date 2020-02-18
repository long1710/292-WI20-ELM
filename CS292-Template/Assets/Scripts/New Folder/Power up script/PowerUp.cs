using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour //use this script for both powerUP: TODO: changename later
{
    public GameObject Icon;
    void Start() {
        Icon.SetActive(false);    
    } 
    
    void OnTriggerEnter2D(Collider2D other) {
        BlazeFoxController controller = other.GetComponent<BlazeFoxController >();
        if(controller != null){
            Icon.SetActive(true);
            Debug.Log("set active");
            if(Icon.tag == "coffee"){
                controller.ChangeSpeed(10);
            }
            if(Icon.tag == "monster"){
                controller.ChangeSpeed(1000);
            }
            Destroy(gameObject);
        } 
    }
    
}
