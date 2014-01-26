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
	public static Vector3[] lanePositions = new Vector3[3];

	public GameObject Position1;
	public GameObject Position2;
	public GameObject Position3;
	public GameObject Player1;
	public GameObject Player2;
	public GameObject Player3;

	float timer;


	void Awake() {
		gameColors[0] = Color.red;
		gameColors[1] = Color.green;
		gameColors[2] = Color.blue;
		gateOrigin = gateSpawner.transform;

		lanePositions[0] = Position1.transform.position;
		lanePositions[1] = Position2.transform.position;
		lanePositions[2] = Position3.transform.position;

		Player1.transform.position = Position1.transform.position;
		Player2.transform.position = Position2.transform.position;
		Player3.transform.position = Position3.transform.position;
	}
	// Use this for initialization
	void Start () {
		timer = Time.time + gateSpawnInterval;
		SpawnGate();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= timer)
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
