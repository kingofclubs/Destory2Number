using UnityEngine;
using System.Collections;

public class ClampPositionLerp : MonoBehaviour {
	Transform objTransform;
	public float xMin;
	public float xMax;
	public float yMin;
	public float yMax;
	public float zMin;
	public float zMax;
	public float lerpFactor = 0.8f;
	bool dragging;

	// Use this for initialization
	void Start () {
		objTransform = this.transform;
		dragging = false;
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
