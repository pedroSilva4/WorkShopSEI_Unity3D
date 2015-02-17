using UnityEngine;
using System.Collections;

public class KeepInBounds : MonoBehaviour {

	// Use this for initialization
	public float Top = 5f;
	public float Bottom = -5f;
	public float Right =7.5f;
	public float Left =-7.5f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 newPos = transform.position;
		if (transform.position.x > Right) {
			newPos.x = Left;
		}
		if (transform.position.x < Left) {
			newPos.x = Right;
		}
		if (transform.position.y > Top) {
			newPos.y = Bottom;
		}
		if (transform.position.y < Bottom) {
			newPos.y = Top;
		}
		if(newPos != Vector2.zero)
			transform.position = newPos;
	}
}
