using UnityEngine;
using System.Collections;

public class PauseButton : TouchButtonLogic {
	public GameObject Menu;
	void OnTouchBegan(){
		Time.timeScale=0;
		Instantiate(Menu);
}
	
		void OnTouchEnd(){
		
}
}