using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class BlazeFoxController : MonoBehaviour
{

    private float dirX;
    public int maxHealth = 5;
    private int curHealth;
    float moveSpeed = 1.0f;
    private float countdown;
    private float anchor;
    Animator anim;

    private Rigidbody2D RigidBody2d;
    // Start is called before the first frame update
    void Start()
    {
        RigidBody2d = GetComponent<Rigidbody2D>();
        curHealth = maxHealth; 
        anchor = moveSpeed;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(dirX == 0){
            anim.SetBool("isRunning", false);
        }
        else{
            anim.SetBool("isRunning", true);
        }
        if(moveSpeed != anchor){
           countdown -= Time.deltaTime;
        }
        if(countdown < 0 ){
           moveSpeed = anchor; 
        }
       dirX = Mathf.Floor(CrossPlatformInputManager.GetAxis("Horizontal") *100f) * moveSpeed ;

        if(dirX > 0)
        {
            transform.eulerAngles = new Vector3(0,0,0);
        }
        else if (dirX < 0)
        {
            transform.eulerAngles = new Vector3(0,180,0);
        }
        RigidBody2d.velocity = new Vector2(dirX, 0f);
       
    }

    public void ChangeSpeed(double amount){
        
        moveSpeed = (float)amount;
        countdown = 5;
    }

    public void changeHealth(int amount){
        curHealth -= amount;
        GUIHealthBar.instance.SetValue(curHealth);
    }

    public int getHealth(){
        return curHealth;
    }
    
}
