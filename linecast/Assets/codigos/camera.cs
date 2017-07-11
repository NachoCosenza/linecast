using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {


	public Transform pj;

	void Start () 
	{
		
	}



	void Update () 
	{		

		RaycastHit[] objetodelrayo = Physics.RaycastAll(transform.position,pj.position-transform.position,
			Vector3.Distance(pj.transform.position,transform.position), 1 << 8);

		foreach (RaycastHit item in objetodelrayo) 
		{
			Renderer render = item.collider.transform.GetComponent<Renderer> ();
			Color colorNuevos;
			colorNuevos.r = render.material.color.r;
			colorNuevos.g = render.material.color.g;
			colorNuevos.b = render.material.color.b;

			colorNuevos.a = 0.3f;

			render.material.color = colorNuevos;
		} 


		/*Ray algo2;
		RaycastHit algo;
		algo2 = Camera.main.ScreenPointToRay (pj.transform.up);

		Debug.DrawLine (transform.position, pj.position, Color.cyan);

		if (Physics.Raycast (transform.position,transform.forward, out algo,
			Vector3.Distance(pj.transform.position,transform.position), 1 << 8)) 
		{
			Debug.Log (algo.transform.name);
			Renderer render = algo.collider.transform.GetComponent<Renderer> ();
			Color colorNuevos;
			colorNuevos.r = render.material.color.r;
			colorNuevos.g = render.material.color.g;
			colorNuevos.b = render.material.color.b;

			colorNuevos.a = 0.3f;

			render.material.color = colorNuevos;
			print ("ok");
		}*/
	}
}
