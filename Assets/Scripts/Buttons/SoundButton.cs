using UnityEngine;
using System.Collections;

public class SoundButton :  TouchButtonLogic {
	public GameObject Sound;
		void OnTouchBegan(){
		/*if (GameObject.FindGameObjectsWithTag(Sound.tag) != null){
			Destroy (Sound);
		}
		else{*/
		Instantiate(Sound);
		//}
}
	
		void OnTouchEnd(){
		
}

}
