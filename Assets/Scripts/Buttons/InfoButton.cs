using UnityEngine;
using System.Collections;

public class InfoButton : TouchButtonLogic {
	public GameObject info;
		void OnTouchBegan(){
		Instantiate(info);
}
	
		void OnTouchEnd(){
		
}

}


