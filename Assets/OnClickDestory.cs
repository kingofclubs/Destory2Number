using UnityEngine;
using System.Collections;

public class OnClickDestory : MonoBehaviour {
	public GameObject gameObj;
	Animator ani;
	bool _isAlive;

	// Use this for initialization
	void Start () {
		ani = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			//Transform select = gameObj.transform;
			if (Physics.Raycast(ray,out hit,100)){
				//select.tag = "Untagged";
				//hit.collider.transform.tag = "Player";
				//Debug.Log("???");
				_isAlive = hit.collider == gameObj.GetComponent<BoxCollider>();
				ani.SetBool("isClicked", _isAlive);
			}
		}
	}
	void DestoryObject(){
		Destroy(gameObj);
	}
}

