using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

	// Use this for initialization
	public void BackToMainScene(string sceneName){
		Application.LoadLevel(sceneName); 
	}
}
