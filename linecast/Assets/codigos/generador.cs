using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generador : MonoBehaviour {

	public GameObject prefa;
	public Transform salida;
	float time = 0.0f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		time += Time.deltaTime;

		float a = Random.Range (-4f, 8f);
		float b = Random.Range (-4f, 8f);
		//new Vector3 (a, b);
		if (time >= 2.0f)
		{
			
			Instantiate (prefa,new Vector3(a,10,b),salida.rotation);
			time = 0;
		}
	}
}
