using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	bool levelComplete = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		bool update = checkLevelComplete();
		if(update != levelComplete){
			Debug.Log("LEVEL COMPLETE");
			levelComplete = update;
		}
	}

	static bool checkLevelComplete(){
		bool levelNotFinished = true;
		foreach(GameObject cube in errorTest.cubes){
			levelNotFinished = levelNotFinished & !cube.activeSelf;
		}
		return levelNotFinished;
	}
}
