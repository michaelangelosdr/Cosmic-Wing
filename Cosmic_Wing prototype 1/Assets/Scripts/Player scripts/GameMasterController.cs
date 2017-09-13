using UnityEngine;
using System.Collections;

public class GameMasterController : MonoBehaviour {

	private static GameMasterController Gameinstance;




	public static GameMasterController GameInstance {

		get {
			return Gameinstance;
		}
	}


	// Use this for initialization
	void Start () {
	
		Gameinstance = this;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
