using UnityEngine;
using System.Collections;

public class Cameracontroller : MonoBehaviour {

	public GameObject ThirdPersonController;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = ThirdPersonController.transform.position + offset;
	}
}
