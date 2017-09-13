using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class Pool_BulletController : MonoBehaviour {


	public List<GameObject> objects;
	void awake()
	{
		objects = new List<GameObject> ();
	
		foreach (Transform t in transform) {
			objects.Add (t.gameObject);
		}
	
	}

	public GameObject GetNextProjectile()
	{
		foreach (GameObject obj in objects) {


			if (!obj.activeInHierarchy) {
				return obj;
			}

		}

		return null;
	}


}
