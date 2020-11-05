using UnityEngine;
using System.Collections;

public class BackButton : TouchButtonLogic {
	
		void OnTouchBegan(){
		Application.LoadLevel("3DMenu");
}
	
		void OnTouchEnd(){
		
}

}
