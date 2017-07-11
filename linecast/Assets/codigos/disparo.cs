using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour {

	public GameObject mira;


	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			RaycastHit algo;
			
			if (Physics.Raycast(transform.position,transform.up, out algo))
			{
				algo.rigidbody.AddForceAtPosition(transform.up *50f , algo.point, ForceMode.Impulse);



			}

		}
	}
}
