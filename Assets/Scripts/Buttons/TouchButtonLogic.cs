using UnityEngine;
using System.Collections;

public class TouchButtonLogic : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		if (Input.touches.Length<=0){
		}
		else{
			for (int i=0; i<Input.touchCount;i++){
				if (this.guiTexture.HitTest(Input.GetTouch(i).position)){
					if (Input.GetTouch(i).phase == TouchPhase.Began){
						SendMessage ("OnTouchBegan");
					// if touch hits the gui texture
					}
					if (Input.GetTouch(i).phase == TouchPhase.Ended){
						SendMessage ("OnTouchEnd");
					}
	
				}
			}
		}
		
	}
}