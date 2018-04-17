using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (speed * Time.deltaTime, 0, 0);
		Destroy (gameObject, 3);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Enemy"))
		{
			Destroy (gameObject);
			Destroy (other.gameObject);
		}
	}
}
