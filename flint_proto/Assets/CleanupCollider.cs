using UnityEngine;
using System.Collections;

public class CleanupCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {

	}

	void OnTriggerStay(Collider other){


	}

	void OnTriggerExit(Collider collider){
		Destroy(collider.transform.parent.gameObject);
	}
}
