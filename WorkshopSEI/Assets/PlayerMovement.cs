using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public int movementSpeed = 5;
	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	public float  RotateSpeed  = 50f;
	void Update () {
		var xInput = Input.GetAxis("Horizontal");
		var yInput = Input.GetAxis("Vertical");

		Debug.Log ("x :" + xInput);
		Debug.Log ("y : 0" + yInput);
		//tranlation with * delta time to set the same speed for diferent framerates
		transform.Translate (0,
		                     movementSpeed * yInput * Time.deltaTime, 
		                     0,Space.Self);
		transform.Rotate (new Vector3 (0, 0, -xInput * Time.deltaTime * RotateSpeed));
	}
}
