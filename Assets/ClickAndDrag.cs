using UnityEngine;
using System.Collections;

public class ClickAndDrag : MonoBehaviour {
	//GameObject obj = this.transform.parent;
	Transform toDrag;
	bool dragging = false;
	private Vector3 offset;
	float dist;
	public float lerpFactor = 0.2f;

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Vector3 v3;


			if(Physics.Raycast(ray, out hit,100.0f)){
				toDrag = hit.transform;
				dist = hit.transform.position.z - Camera.main.transform.position.z;
				v3 = new Vector3 (Input.mousePosition.x,Input.mousePosition.y, dist);
				v3 = Camera.main.ScreenToWorldPoint(v3);
				offset = toDrag.position - v3;
				dragging = true;
			}
		}
		if(Input.GetMouseButton(0)){
			if(dragging){
				Vector3 v3 = new Vector3 (Input.mousePosition.x,Input.mousePosition.y,dist);
				v3 = Camera.main.ScreenToWorldPoint(v3);
				toDrag.position = v3+offset;
			}
		}
		if(Input.GetMouseButtonUp(0)){
			dragging = false;
		}
	}
}
