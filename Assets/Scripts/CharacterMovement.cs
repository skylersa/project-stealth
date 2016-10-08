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

		// deafult local scale = (1,1,1)
		// crouch local scale = (1,.5,1)

		// Input.GetAxis ("Crouch") == 0   <--- default
		// Input.GetAxis ("Crouch") == -1  <--- crouching

		// Input.GetAxis ("Crouch")       -->    y local scale
		//              0                 -->          1.0
		//             -1                 -->          0.5

		float yLocalScale = Input.GetAxis ("Crouch") *.5f + 1f;
		transform.localScale = new Vector3 (1f, yLocalScale, 1f);
	}
}