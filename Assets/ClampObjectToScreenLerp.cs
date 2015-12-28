using UnityEngine;
using System.Collections;

public class ClampObjectToScreenLerp : MonoBehaviour {
	Transform objTransform;
	float xMin;
	float xMax;
	float yMin;
	float yMax;
	float zMin;
	float zMax;
	public float buffer;
	public float lerpFactor = 0.1f;
	bool dragging;

	// Use this for initialization
	void Start () {
		objTransform = this.transform;
		dragging = false;
		//Vector3 objExtents = this.GetComponent<Renderer>().bounds.extents; // For some stuipd reason, this doesn't work
		Vector3 objExtents = new Vector3(2.1f,9.9f);//So we get to hard code the solution for now. Fucking piece of shit
		xMax = objExtents.x;
		xMin = -1*objExtents.x;
		yMax = objExtents.y;
		yMin = -1*objExtents.y;
		Debug.Log(objExtents);
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			dragging = true;
		}
		if(Input.GetMouseButtonUp(0)){
			dragging = false;
		}
		if(!dragging){
			//Is it out of bounds?
			//move it smoothly
			if(objTransform.position.x < xMin){
				objTransform.position = new Vector3(Mathf.Lerp(objTransform.position.x,xMin,lerpFactor),objTransform.position.y);
			}
			if(objTransform.position.x > xMax){
				objTransform.position = new Vector3(Mathf.Lerp(objTransform.position.x,xMax,lerpFactor),objTransform.position.y);
			}
			if(objTransform.position.y < yMin){
				objTransform.position = new Vector3(objTransform.position.x,Mathf.Lerp(objTransform.position.y,yMin,lerpFactor));
			}
			if(objTransform.position.y > yMax){
				objTransform.position = new Vector3(objTransform.position.x,Mathf.Lerp(objTransform.position.y,yMax,lerpFactor));
			}
		}
	}
}
