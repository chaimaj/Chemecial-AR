using UnityEngine;
using System.Collections;

public class MoveComp2 : MonoBehaviour {

private GameObject target;
public float speed = 10.0f;
public float delay = 5.1f; 

	void Start()
	{
	target = GameObject.FindGameObjectWithTag("Player");
	
	}

	// Update is called once per frame
	void Update () {
	
	transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
	Destroy(gameObject,delay);
	}
	

}
