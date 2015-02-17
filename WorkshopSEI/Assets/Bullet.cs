using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float Speed = 10f;
	public float duration = 2f;
	public float _startTime;
	LayerMask CollisionMask;
	void Start(){
		_startTime = Time.time;
		}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Speed * Vector2.up * Time.deltaTime);
		if (Time.time - _startTime > duration)
						Destroy (gameObject);
	}
}
