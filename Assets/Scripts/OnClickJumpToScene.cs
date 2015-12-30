using UnityEngine;
using System.Collections;

public class OnClickJumpToScene : MonoBehaviour {
	//GameObject obj = this.transform.parent;

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			//Vector3 v3;


			if(Physics.Raycast(ray, out hit,100.0f)){
				Debug.Log("bonk!");
			}
		}
	}
}