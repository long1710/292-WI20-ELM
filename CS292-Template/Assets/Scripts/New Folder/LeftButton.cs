using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class LeftButton : MonoBehaviour {
	public Button yourButton;
    public GameObject Blaze;
	private float dirX;
	public int moveSpeed = 100;
    private Rigidbody2D Rb;
	

	void Start () {
		Rb = Blaze.GetComponent<Rigidbody2D>();	
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(OnMouseDown);
	}	
		

	void OnMouseDown() {
		dirX = -1 * moveSpeed;
		Debug.Log (dirX);
        Rb.velocity = new Vector2(dirX, 0f);
	}
}