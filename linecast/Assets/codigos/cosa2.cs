using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cosa2 : MonoBehaviour {
	private Rigidbody rb;
	public float angle;
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Rotate (Vector3.forward * Time.deltaTime * angle);
		}

		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Rotate (Vector3.forward * Time.deltaTime * -angle);
		}
		
	}
}
