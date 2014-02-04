using UnityEngine;
using System.Collections;

public class Bubble_Individual_Script : MonoBehaviour {


	public Font font;
	//public Material material;

	// Use this for initialization
	void Start () {
	
	}

	void Awake(){
		TextMesh tm = gameObject.AddComponent(typeof(TextMesh)) as TextMesh;
		tm.text = "TEXTO";
		tm.font = font;
		tm.characterSize = 2.0f;
	}

	// Update is called once per frame
	/*void Update () {

		if (Input.GetKeyDown(KeyCode.A)) {
			gameObject.AddComponent(MeshRenderer);
			renderer.material = material;

			var tm = gameObject.AddComponent(TextMesh);

			tm.text = "Some text to display";
			tm.font = font;
			tm.characterSize = 0.25;
		}
	
	}*/
}
