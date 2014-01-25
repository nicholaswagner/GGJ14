using UnityEngine;
using System.Collections;

public class PlayerEntity : MonoBehaviour {

	public Color playerColor = Color.black;

	void Awake(){
		renderer.material.color = playerColor;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
