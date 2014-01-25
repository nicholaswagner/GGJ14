using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	public GameObject cleanerObject;
	public GameObject gateSpawner;
	public float gateSpawnInterval = 3;

	public List<GameObject> gatePrefabs = new List<GameObject>(); 

	private GameObject currentGate;
	private Transform gateOrigin;

	public static Color[] gameColors = new Color[3];


	// prototype time functions
	float timer;


	void Awake() {
		gameColors[0] = Color.red;
		gameColors[1] = Color.green;
		gameColors[2] = Color.blue;
		gateOrigin = gateSpawner.transform;
	}
	// Use this for initialization
	void Start () {
		timer = Time.time + gateSpawnInterval;
		SpawnGate();
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time >= timer)
		{
			timer += gateSpawnInterval; //set the timer again
			SpawnGate();
		}
	}
	
	void SpawnGate() {
		//currentGate = (GameObject)Instantiate(gatePrefabs[Random.Range(0,3)]);  // cut scope and ship it!!!!
		currentGate = (GameObject)Instantiate(gatePrefabs[0]);
		currentGate.transform.position = gateOrigin.position;
		//var gateController = (Portal)currentGate.GetComponent("Portal");
		//currentGate.GetComponent.<PortalManager>().variable = 
	}
}
