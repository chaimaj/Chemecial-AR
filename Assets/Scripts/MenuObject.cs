using UnityEngine;
using System.Collections;

public class MenuObject : MonoBehaviour {
	private Color green= new Color(0.0F, 1.0F, 0.8F);
	public bool isQuit = false;
	void OnMouseEnter(){
	renderer.material.color = green;
	
	}
	void OnMouseExit(){
		renderer.material.color =Color.white;
	}
	void OnMouseDown(){
		if (isQuit){
			Application.Quit ();
		}
		else
		{
			Application.LoadLevel ("scene2");
		}
	}
}
