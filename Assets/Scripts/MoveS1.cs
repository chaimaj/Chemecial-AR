using UnityEngine;
using System.Collections;

public class MoveS1 : MonoBehaviour {
	public string path;

	// Use this for initialization
	void Start () {
	iTween.MoveTo(gameObject, iTween.Hash("delay",1,"path", iTweenPath.GetPath(path), "time", 7));
	}

	
}
