using UnityEngine;
using System.Collections;

public class Gui_Adder : MonoBehaviour {


	public TextMesh myButtonText; 
	public Vector3 myVector3forBubbleAndText; 
	//public string[] arrayOfStrings;
	public float yOffestForText;


	void Start () {
	}

	void Update () {
	
	}

	void Awake(){

		yOffestForText = 0.18f;
		string[] arrayOfStrings = {"Condoms \nare\n bad", "Condoms \nare \ngood", "Condoms \ngo \ncrazy"};
		TextMesh myTextInstance;
		myTextInstance = Instantiate(myButtonText, transform.position, Quaternion.identity) as TextMesh;
		myTextInstance.transform.parent = this.transform;
		myTextInstance.transform.localPosition = new Vector3(0f,yOffestForText,0f);
		int randomNum = Random.Range (0, 3);
		//print (randomNum);
		myTextInstance.text = arrayOfStrings [randomNum];
	}

	/*void OnTap( TapGesture gesture ) 
	{
		// Number of taps performed
		//int taps = gesture.Taps;
		print ("I got tapped at Rachels' Warehouse!");
	}*/
}
