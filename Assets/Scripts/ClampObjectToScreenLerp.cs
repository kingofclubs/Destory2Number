using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClampObjectToScreenLerp : MonoBehaviour {
	Transform objTransform;
	public Text text;
	Bounds bind;
	public float lerpFactor;
	Vector3 topRight,right,left,top,bottom;

	// Use this for initialization
	void Start () {
		objTransform = this.transform;
		//dragging = false;
		//lerpFactor = 0.1f;

		//First we have to get the world space coordinate size of the camera. 
		//This is done by picking the 1,1 screenspace coordinate and translating into world coords
		//if the screen changes size during the execution, this script will only work with the old screen size coordinates.
		topRight = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelRect.width,Camera.main.pixelRect.height));

		//These define midpoints on the edge of the screen
		//i.e. right is a point, in world coordinates, which will appear at the 1,0.5 screenspace coordinate
		right  = new Vector3(topRight.x,0.0f,0.0f);
		left   = new Vector3(-1*topRight.x,0.0f,0.0f);
		top    = new Vector3(0.0f,topRight.y,0.0f);
		bottom = new Vector3(0.0f,-1*topRight.y,0.0f);
	}

	// Update is called once per frame
	void Update () {
		//This defines the world space boundries in which our attached object exists and has to be called each frame to get updated coords.
		bind = this.GetComponent<Collider>().bounds;
		//Bounds bind = this.GetComponent<Collider>().bounds;
		text.text = "Dragging = "+ Input.GetMouseButton(0) + "\nobjTransform.position = " + objTransform.position + "\ntopRight = " + topRight + "\n" + bind.Contains(right) + " " + bind.Contains(left) + "\n" + bind.Contains(top) + " " + bind.Contains(bottom);


		if(!Input.GetMouseButton(0)){
			//Is it out of bounds?
			//move it smoothly
			//If the attached object is outside rendering bounds of the camera, move it back within the bounds
			//If statements include two conditions, one to see if the midpoint is outside the bounds and another to see if the opposite midpoint is inside the bounds
			//This way, in instances where the screen is larger than the map, and both of a set of midpoints are outside the bounds, it doesn't move it around
			if(!bind.Contains(right) && bind.Contains(left)){
				//print ("Right out of bounds");
				objTransform.position = new Vector3(Mathf.Lerp(objTransform.position.x,right.x,lerpFactor),objTransform.position.y);
			}
			if(!bind.Contains(left) && bind.Contains(right)){
				//print ("Left out of bounds");
				objTransform.position = new Vector3(Mathf.Lerp(objTransform.position.x,left.x,lerpFactor),objTransform.position.y);
			}
			if(!bind.Contains(top) && bind.Contains(bottom)){
				//print ("Top out of bounds");
				objTransform.position = new Vector3(objTransform.position.x,Mathf.Lerp(objTransform.position.y,top.y,lerpFactor));
			}
			if(!bind.Contains(bottom) && bind.Contains(top)){
				//print ("Bottom out of bounds");
				objTransform.position = new Vector3(objTransform.position.x,Mathf.Lerp(objTransform.position.y,bottom.y,lerpFactor));
			}

			//there exists a bug wherein the player drags the attached object beyond the EVERY midpoint. In this instance the object wont move 
			//And thusly won't be properly clamped to the screen edges
			//This next statement checks for this condition, and then attempts to return the attached object to the origin.

			if(!bind.Contains(right) && !bind.Contains(left) && !bind.Contains(bottom) && !bind.Contains(top)){
				objTransform.position = new Vector3(Mathf.Lerp(objTransform.position.x,0.0f,lerpFactor),Mathf.Lerp(objTransform.position.y,0.0f,lerpFactor));
			}
		}
	}
}
