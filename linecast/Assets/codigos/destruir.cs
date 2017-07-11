using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruir : MonoBehaviour {

	public GameObject caja;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		DestroyObject (caja , 5.5f);
	}
}
