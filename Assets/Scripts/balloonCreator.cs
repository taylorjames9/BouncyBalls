using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class balloonCreator : MonoBehaviour {

	/*
	public GameObject prefaBalloon;
	public int numBalloons;
	List<GameObject> myListOfBalloons = new List<GameObject> ();
	bool forceApplied = false;
	bool balloonsGenerated = false;
	private bool scaleMaxed = false;
	public Vector3 spawnSpot;

	// Use this for initialization
	void Start () {

		numBalloons = 20;

	}
	
	// Update is called once per frame
	void Update () {
		if (!balloonsGenerated) {
			GenerateBalloons ();
			balloonsGenerated = true;
		}
		GrowBalloon0 ();
	}

		void GenerateBalloons(){
		for (int i=0; i <= numBalloons; i++) {
			GameObject dizBalloon = (GameObject)Instantiate (prefaBalloon);
			Vector3 spawnSpot = new Vector3 (5,0,0);

			dizBalloon.transform.localPosition = spawnSpot;
			dizBalloon.rigidbody.AddForce(-1,2,0,ForceMode.Force);
			//dizBalloon.rigidbody.AddForce (10, 1, 0);
			myListOfBalloons.Add (dizBalloon);
		}
	}
	/*void FixedUpdate() {
		if(!forceApplied){
		for (int i = 0; i < numBalloons; i++) {
				myListOfBalloons[i].rigidbody.AddForce (-1, 1, 0, ForceMode.Acceleration);
		}
		forceApplied = true; 
	}
	}

	void GrowBalloon0(){
		if(!scaleMaxed){
			for (int i = 0; i <= numBalloons; i++) {
				print ("We're in");
				myListOfBalloons [i].transform.localScale += new Vector3 (0.05F, 0.05f, 0);
				if (myListOfBalloons [1].transform.localScale.x >= 3) {
					scaleMaxed = true;
				}

			}
		}
	}*/

}

