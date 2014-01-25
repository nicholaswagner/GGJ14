using UnityEngine;
using System.Collections;

public class PlayerCollisions : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider) {
		/*
		 * Finds the point of the collision event and makes an explosion!
		ContactPoint contact = collision.contacts[0];
		Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
		Vector3 pos = contact.point;
		//Instantiate(explosionPrefab, pos, rot) as Transform;
		//Destroy(gameObject);
		*/

		Portal portal = collider.gameObject.GetComponent<Portal>();
		PlayerEntity player = this.gameObject.GetComponent<PlayerEntity>();
		Color playerColor = player.playerColor;
		Color portalColor = portal.secretColor;

		if (playerColor == portalColor){
			Debug.Log ("SUCCESS!!!!");
		}
		else {
			Debug.Log("FAIL!!!!");
		}




	}
}
