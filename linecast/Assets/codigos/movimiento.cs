using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour {

	private Rigidbody rb;
	public float speed;
	public int angle;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.W))
		{
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
		}
		if(Input.GetKey(KeyCode.S))
		{
			transform.Translate (Vector3.back * Time.deltaTime * speed);
		}
		if(Input.GetKey(KeyCode.D))
		{
			transform.Rotate (Vector3.up * Time.deltaTime * angle);
		}

		if(Input.GetKey(KeyCode.A))
		{
			transform.Rotate (Vector3.up * Time.deltaTime * -angle);
		}


	}
}
	