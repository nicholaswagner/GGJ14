using UnityEngine;
using System.Collections;

public class PlayerCollisions : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit(Collider collider) {
		/*
		 * Finds the point of the collision event and makes an explosion!
		ContactPoint contact = collision.contacts[0];
		Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
		Vector3 pos = contact.point;
		//Instantiate(explosionPrefab, pos, rot) as Transform;
		//Destroy(gameObject);
		*/

		/*
		Debug.Log("2");
		Portal portal = collider.gameObject.GetComponent<Portal>();
		Debug.Log("3");
		PlayerEntity player = this.gameObject.GetComponent<PlayerEntity>();
		Debug.Log("4");
		*/
		//Color playerColor = player.playerColor;

		//Color portalColor = portal.secretColor;
		
		/*Debug.Log("5");
		if (playerColor == portalColor){
			//Destroy(collider.gameObject);
		}
		else {
			//Debug.Log("FAIL!!!!");
		}*/



			
		




	}
}
