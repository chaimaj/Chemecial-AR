using UnityEngine;
using System.Collections;

public class ReloadButton : TouchButtonLogic {
	
		void OnTouchBegan(){
		Application.LoadLevel("scene2");
}
	
		void OnTouchEnd(){
		
}
}
