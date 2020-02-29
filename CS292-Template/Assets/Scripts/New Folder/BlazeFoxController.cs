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
    public int moveSpeed = 100;
    private float countdown;
    private int anchor;
    Animator anim;

	public GameObject gameOverPanel; //game over screen
	public GameObject particleprefab;

    private Rigidbody2D RigidBody2d;
    // Start is called before the first frame update
    void Start()
    {
        
        anim = GetComponent<Animator>();
        PlayerPrefs.SetInt("score", 0);
        RigidBody2d = GetComponent<Rigidbody2D>();
        curHealth = maxHealth; 
        anchor = moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
       if(moveSpeed != anchor){
           countdown -= Time.deltaTime;
       }
       if(countdown < 0 ){
           moveSpeed = anchor; 
       }
       dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
       if(dirX > 0.2)
       {
           anim.SetBool("isRunning", true);
           transform.eulerAngles = new Vector3(0,0,0);
       }
       else if (dirX < -0.2)
       {
           anim.SetBool("isRunning", true);
           transform.eulerAngles = new Vector3(0,180,0);
       }
       else{
           anim.SetBool("isRunning", false);
       }
       
       
       RigidBody2d.velocity = new Vector2(dirX, 0f);

       

    }

    public void ChangeSpeed(int amount){
        
        moveSpeed = amount;
        countdown = 5;
    }

    public void changeHealth(int amount){
		PlayParticle();
        AudioSource source = GetComponent<AudioSource>(); //get sound
		source.volume = 5;
        source.Play();
		curHealth -= amount;
        GUIHealthBar.instance.SetValue(curHealth);
        if (curHealth <= 0)
		{
            anim.SetBool("Death", true); //play death animation
			StartCoroutine(ExecuteAfterTime(1)); //calling the enumerator with 1 to wait until after the animation is over
		}
		

	}

    public int getHealth(){
        return curHealth;
    }

    public void PlayParticle()
	{
		Debug.Log("Should Play Particle");
        GameObject psystem = Instantiate(particleprefab, RigidBody2d.position, Quaternion.identity);
		psystem.GetComponent<ParticleSystem>().Play();
	}

	IEnumerator ExecuteAfterTime(float time)
	{
		yield return new WaitForSeconds(time); //this makes it wait to show the gameover panel

		gameOverPanel.SetActive(true);
		Time.timeScale = 0;
	}


}
