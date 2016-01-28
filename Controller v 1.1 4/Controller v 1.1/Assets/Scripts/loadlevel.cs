using UnityEngine;
using System.Collections;

public class loadlevel : MonoBehaviour {
	
	void OnCollisionEnter(Collision coll){


	if(coll.gameObject.name=="Cube_mountain1"){
			Application.LoadLevel ("scene1");
	}

		if(coll.gameObject.name=="Cube_mountain2"){
			Application.LoadLevel ("scene2");
	}
		if(coll.gameObject.name=="Cube_mountain3"){
		 Application.LoadLevel ("scene3");
	}
   }
}
