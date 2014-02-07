using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CanonWCoroutine : MonoBehaviour {


	public GameObject thought;
	public int bubbleCounter;
	public float scale;
	public float growthRate;
	public List<GameObject> myListOfBalloons = new List<GameObject> ();
	//public Font font;
	//public GameObject myText0; 
	public TextMesh myButtonText; 
	public Vector3 myVector3forBubbleAndText; 
	//public string[] arrayOfStrings;

	// Use this for initialization
	void Start () {
		/*arrayOfStrings = new string[]{"Condoms are bad", "Condoms are good", "Condoms go crazy"};

		foreach (string rumor in arrayOfStrings) {
			print (rumor);
		}*/
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
		while (bubbleCounter <= 10) {
			FireAThought ();
			yield return new WaitForSeconds (0.3f);
		}
		}

	void FireAThought(){
		Vector3 myVector3forBubbleAndText = new Vector3(7f, -3f, -2f);
		GameObject aBubbleThought = Instantiate (thought, myVector3forBubbleAndText, Quaternion.identity) as GameObject;
		audio.Play ();
		myListOfBalloons.Add (aBubbleThought);
		/*TextMesh myTextInstance;
		myTextInstance = Instantiate(myButtonText, myVector3forBubbleAndText, Quaternion.identity) as TextMesh;
		myTextInstance.transform.parent = aBubbleThought.transform;*/
		aBubbleThought.rigidbody.AddForce (Random.Range(-2f,-5f), Random.Range(2f,4f), 0f, ForceMode.Force);
		bubbleCounter++;
	}
}
