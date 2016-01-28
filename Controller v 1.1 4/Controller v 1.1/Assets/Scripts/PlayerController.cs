using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	public float acceleration;
	public float a;
	public float ternSpeed;
	void Start(){
		moveSpeed = 30f;
		acceleration = 30f;
		ternSpeed = 20f;
	}

	// Update is called once per frame
	void Update () {

		transform.Translate((moveSpeed + acceleration*Input.GetAxis("accelerate"))*Input.GetAxis("Horizontal")*Time.deltaTime, (moveSpeed + acceleration*Input.GetAxis("accelerate"))*Input.GetAxis("UpDown")*Time.deltaTime,(moveSpeed + acceleration*Input.GetAxis("accelerate"))*Input.GetAxis("Vertical")*Time.deltaTime);
		//transform.Translate(moveSpeed *Input.GetAxis("accelerate")*Time.deltaTime, a*acceleration*Time.deltaTime*Time.deltaTime*Input.GetAxis("accelerate")+moveSpeed*Input.GetAxis("UpDown")*Time.deltaTime,a*acceleration*Time.deltaTime*Time.deltaTime*Input.GetAxis("accelerate")+moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);
		if (Input.GetKey(KeyCode.M)) {
			transform.Rotate(Vector3.up, ternSpeed * Time.deltaTime );
		}
		if (Input.GetKey(KeyCode.N)) {
			transform.Rotate(Vector3.up, -1*ternSpeed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.T)) {
			transform.Rotate(Vector3.forward, ternSpeed * Time.deltaTime );
		}
		if (Input.GetKey(KeyCode.Z)) {
			transform.Rotate(Vector3.forward, -1*ternSpeed * Time.deltaTime);
		}
	}
}
