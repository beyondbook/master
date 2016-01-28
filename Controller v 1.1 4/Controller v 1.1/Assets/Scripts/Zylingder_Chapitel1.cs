using UnityEngine;
using System.Collections;

public class Zylingder_Chapitel1 : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Player") {
			Application.LoadLevel("Chapitel1");
		}
	}
}
