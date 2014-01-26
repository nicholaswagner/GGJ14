using UnityEngine;
using System.Collections;

public class PlayerEntity : MonoBehaviour {

	public Color playerColor;
	public int currentLane;

	public KeyCode lane1;
	public KeyCode lane2;
	public KeyCode lane3;

	private Vector3 newPosition;
	public float smooth;


	void Awake(){
		renderer.material.color = playerColor;



	}
	// Use this for initialization
	void Start () {
		newPosition = GameController.lanePositions[currentLane];
	}
	
	// Update is called once per frame
	void Update () {

		/*
		bool down = Input.GetKeyDown(KeyCode.Space);
		bool held = Input.GetKey(KeyCode.Space);
		bool up = Input.GetKeyUp(KeyCode.Space);
		*/
		int prevLane = currentLane;

		if (Input.GetKeyDown(lane1)){
			currentLane = 0;
		}
		if (Input.GetKeyUp(lane2)){
			currentLane = 1;
		}
		if (Input.GetKeyUp(lane3)){
			currentLane = 2;
		}

		if (prevLane != currentLane ){
			// move to lane.
			newPosition = GameController.lanePositions[currentLane];
		}
		PositionChanging();
	}


	void PositionChanging ()
	{
		transform.position = Vector3.Lerp(transform.position, newPosition, smooth * Time.deltaTime);
	}
}
