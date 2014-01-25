using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public float speed = 20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {
		//this.z = this.transform.position.x;
		this.transform.Translate( new Vector3(0,0,-speed * Time.deltaTime) ); // move!
	}
}
