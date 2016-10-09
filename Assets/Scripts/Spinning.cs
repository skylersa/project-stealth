using UnityEngine;
using System.Collections;

public class Spinning : MonoBehaviour {
	public Transform player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localRotation *= 
			Quaternion.LerpUnclamped (Quaternion.identity,
			Quaternion.FromToRotation (player.forward, player.up),
				Time.deltaTime * Input.GetAxis("Vertical"));
	}
}
