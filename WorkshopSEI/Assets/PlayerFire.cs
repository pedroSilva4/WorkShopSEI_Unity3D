using UnityEngine;
using System.Collections;

public class PlayerFire : MonoBehaviour {
	public GameObject bullet;
	public float fireRate = 0.3f;
	// Use this for initialization
	void Start () {
	
	}
	bool _firing = false;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
						_firing = true;
			StartCoroutine(FireRoutine());
				} 
		if (Input.GetKeyUp (KeyCode.Space)) {
			_firing = false;
				}

	}

	void fire()
	{
			Instantiate(bullet,transform.position,transform.rotation);
	
	}
	IEnumerator FireRoutine()
	{
		while (_firing) {
				fire();
			yield return new WaitForSeconds(fireRate);
			}
	}
}
