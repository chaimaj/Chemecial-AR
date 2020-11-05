using UnityEngine;
using System.Collections;

public class ResumeButton : TouchButtonLogic {
	public GameObject Menu;
		void OnTouchBegan(){
		Time.timeScale=1;
		Destroy(Menu);
}
	
		void OnTouchEnd(){
		
}


}
