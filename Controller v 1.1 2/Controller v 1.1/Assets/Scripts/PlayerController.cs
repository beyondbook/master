using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;

	void Start(){
		moveSpeed = 30f;
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,moveSpeed*Input.GetAxis("UpDown")*Time.deltaTime,moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime );
	}
}
