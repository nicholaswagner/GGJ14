using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class PortalManager : MonoBehaviour {

	private int numColors = GameController.gameColors.Length;
	public Color[] gateColors;
	public GameObject[] portals;
	private static string[] markerNames = { "portal_marker_1", "portal_marker_2", "portal_marker_3" };

	void Awake() {
		shuffleGateColors();
		createPortals();
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void createPortals() {
		portals = new GameObject[numColors];
		for (int i=0; i< numColors; i++) {
			//GameObject instance = (GameObject) Instantiate(Resources.Load("test", typeof(GameObject)));
			GameObject instance = (GameObject) Instantiate(Resources.Load<GameObject>("Portal_Prefab"));
			instance.transform.parent = transform;
			instance.transform.position = transform.Find(markerNames[i]).position;
			Portal portal = instance.GetComponent<Portal>();
			portal.secretColor = gateColors[i];
			portals[i] = instance;
		}
	}

	void shuffleGateColors(){
		gateColors = new Color[numColors];
		System.Array.Copy(GameController.gameColors, gateColors, numColors);
		for (int i=0; i<numColors; i++) {
			int randomIndex = Random.Range(0,numColors);
			Color tempColor = gateColors[i];
			gateColors[i] = gateColors[randomIndex];
			gateColors[randomIndex] = tempColor;
		}
	}
}
