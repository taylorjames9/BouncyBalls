using UnityEngine;
using System.Collections;

public class CanonScript : MonoBehaviour {


	public GameObject thought;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Return)) {
			FireAThought ();
		}
	}

	void FireAThought (){
		GameObject aBulletThought = Instantiate (thought, transform.position, Quaternion.identity) as GameObject;
		aBulletThought.rigidbody.AddForce(-5f,4f,0f,ForceMode.Force);
		audio.Play();
		while (aBulletThought.transform.localScale.x < 2.5) {
			aBulletThought.transform.localScale += new Vector3 (0.005F, 0.005f, 0f);
		}

	}
}
