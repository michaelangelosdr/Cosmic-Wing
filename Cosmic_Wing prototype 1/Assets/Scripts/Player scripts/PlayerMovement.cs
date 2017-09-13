using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	//For Keyboard / Keypad 
	[SerializeField] private float MovementSpeed;
	private Vector2 PlayerVector;

	 private float PlayerX;
	 private float PlayerY;
	[SerializeField] private float PlayerXSpeed;
	[SerializeField] private float PlayerYSpeed;

	// Use this for initialization
	void Start () {
		PlayerX = transform.position.x;
		PlayerY = transform.position.y;
		PlayerVector = new Vector2 (transform.position.x, transform.position.y);
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log (Input.GetTouch (0));	
		if (Input.GetMouseButton (0)) {



			Debug.Log(Screen.height);

			PlayerX += PlayerXSpeed * Input.GetAxis ("Mouse X");
			PlayerY += PlayerYSpeed * Input.GetAxis ("Mouse Y");
			//-10 is camera distance
			PlayerVector = new Vector2(PlayerX,PlayerY);
		}


		transform.position = Vector2.Lerp(transform.position,PlayerVector, Time.deltaTime * MovementSpeed);



	}


}
