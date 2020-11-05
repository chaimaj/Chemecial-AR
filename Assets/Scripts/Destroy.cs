using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	
	
public float speed = 3.0f;
 

public GameObject Comp3;
public GameObject Comp4;
private bool Ok=false;


//	private AudioSource _audioSource;
	
	/*void Awake(){
		CoinValue = 1;
		_audioSource = gameObject.GetComponent<AudioSource>();
	}*/

	// Update is called once per frame
	
	
	void Update () {
		StartCoroutine(waitSeconds(3.5f));
		if (Ok)

			Destroy(gameObject);}
 

    IEnumerator waitSeconds(float seconds)

    {

        yield return new WaitForSeconds(seconds);
	gameObject.GetComponent<MeshRenderer>().enabled = false;

	Instantiate(Comp3);
	Instantiate(Comp4);
	Ok=true;
	
    }
	
//	_audioSource.enabled=true;


 
}
