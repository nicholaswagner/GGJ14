using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {

	public Color secretColor = Color.black;


	void Awake() {

	}
	// Use this for initialization
	void Start () {
		this.renderer.material.color = secretColor;
	}
	
	// Update is called once per frame
	void Update () {
	
	}



}
