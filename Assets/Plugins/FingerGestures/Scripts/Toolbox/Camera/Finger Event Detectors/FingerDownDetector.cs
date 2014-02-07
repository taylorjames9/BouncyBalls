using UnityEngine;
using System.Collections;

public class FingerDownEvent : FingerEvent 
{
	//public GameObject particleSystem;
	public GameObject prefabulous;

	void Update(){
		/*if (ProcessFinger.finger.IsDown && !finger.WasDown) {
			prefabulous = Instantiate(Load("Particle System")) as GameObject;
			Instantiate(prefabulous, Quaternion.identity);
		}*/
	}
}

[AddComponentMenu( "FingerGestures/Finger Events/Finger Down Detector" )]
public class FingerDownDetector : FingerEventDetector<FingerDownEvent>
{
    public event FingerEventHandler OnFingerDown;
    public string MessageName = "OnFingerDown";   
	public GameObject prefabulous;

	 
    
    protected override void ProcessFinger( FingerGestures.Finger finger )
    {
        if( finger.IsDown && !finger.WasDown )
        {

			print ("Yes! I got finger gestures working!");
			//GameObject prefabulous = Instantiate(Load("Particle System")) as GameObject;
			//Instantiate(prefabulous, Quaternion.identity);





            FingerDownEvent e = GetEvent( finger.Index );
            e.Name = MessageName;
            UpdateSelection( e );

            if( OnFingerDown != null )
                OnFingerDown( e );

            TrySendMessage( e );
        }
    }
}
