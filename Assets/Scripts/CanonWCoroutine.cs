using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CanonWCoroutine : MonoBehaviour {


	public GameObject thought;
	public int bubbleCounter;
	public float scale;
	public float growthRate;
	List<GameObject> myListOfBalloons = new List<GameObject> ();

	// Use this for initialization
	void Start () {
		bubbleCounter = 0; 
		scale = 1.1f;
		growthRate = 1.0f;
		StartCoroutine(thoughtRepeating());
	}
	
	// Update is called once per frame
	void Update () {

		foreach (GameObject listBalloon in myListOfBalloons) {
			if (listBalloon.transform.localScale.x < 3) {
				listBalloon.transform.localScale += new Vector3 (0.05F, 0.05f, 0f);
			}
		}
	}
	IEnumerator thoughtRepeating(){
		while (bubbleCounter <= 15) {
			FireAThought ();
			yield return new WaitForSeconds (0.1f);
		}
		}

	void FireAThought(){
		GameObject aBubbleThought = Instantiate (thought, transform.position, Quaternion.identity) as GameObject;
		aBubbleThought.rigidbody.AddForce (-5f, 4f, 0f, ForceMode.Force);
		audio.Play ();
		//ThoughtGrow (aBubbleThought);
		myListOfBalloons.Add (aBubbleThought);
		bubbleCounter++;
		//print (bubbleCounter);
	}

	/*void ThoughtGrow(GameObject passedInThought){
		passedInThought.transform.localScale = Vector3.one * scale;
		scale += growthRate * Time.deltaTime;
	}*/
}



