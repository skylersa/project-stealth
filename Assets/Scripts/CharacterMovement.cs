using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
	public float speed = 0.00001f; 

	Vector3 movement;  

	void Update () {
//		if (Input.GetKey (KeyCode.W))
//			GetComponent<Rigidbody>().MovePosition (
		transform.position += Input.GetAxis("Vertical") * speed * Time.deltaTime * transform.forward;
		transform.position += Input.GetAxis("Horizontal") * speed * Time.deltaTime * transform.right;
		transform.position += Input.GetAxis("Jump") * speed * Time.deltaTime * transform.up;
	}
}