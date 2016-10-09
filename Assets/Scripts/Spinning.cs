using UnityEngine;
using System.Collections;

public class Spinning : MonoBehaviour {
	public Transform player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// w=forward / s=back
		transform.localRotation = 
			Quaternion.LerpUnclamped (Quaternion.identity,
			Quaternion.FromToRotation (player.forward, player.up),
			Time.deltaTime * Input.GetAxis ("Vertical"))
		*
			transform.localRotation;

		// a=left / d=right
		transform.localRotation = 
		Quaternion.LerpUnclamped (Quaternion.identity,
			Quaternion.FromToRotation (player.right, player.up),
			Time.deltaTime * Input.GetAxis ("Horizontal"))
		*
		transform.localRotation;
	}
}
