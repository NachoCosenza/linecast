using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour {

	public float fuerza;

	// Use this for initialization
	void Start () 
	{
		Rigidbody rb = GetComponent<Rigidbody> ();
		rb.AddRelativeForce (Vector3.forward * fuerza, ForceMode.Impulse);

		Destroy (gameObject, 5.0f);
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "tanque")
		{
			print ("puto");
		}
	}
	void Update () 
	{
		
	}
}
