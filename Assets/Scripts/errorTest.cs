using UnityEngine;
using System.Collections;

public class errorTest : MonoBehaviour {
    public static GameObject cubeOne;
    public static GameObject cubeTwo;
    public static GameObject cubeThree;
    public static GameObject cubeFour;
    public static GameObject cubeFive;
    public static GameObject cubeSix;
    public static GameObject cubeSeven;
    public static GameObject cubeEight;
    public static GameObject cubeNine;
	public static GameObject[] cubes = new GameObject[9];

    public void Start()
    {
		cubes[0] = GameObject.FindGameObjectWithTag("cubeOne");
		cubes[1] = GameObject.FindGameObjectWithTag("cubeTwo");
		cubes[2] = GameObject.FindGameObjectWithTag("cubeThree");
		cubes[3] = GameObject.FindGameObjectWithTag("cubeFour");
		cubes[4] = GameObject.FindGameObjectWithTag("cubeFive");
		cubes[5] = GameObject.FindGameObjectWithTag("cubeSix");
		cubes[6] = GameObject.FindGameObjectWithTag("cubeSeven");
		cubes[7] = GameObject.FindGameObjectWithTag("cubeEight");
		cubes[8] = GameObject.FindGameObjectWithTag("cubeNine");
		foreach(GameObject cube in cubes){
			cube.SetActive(true);
		}

		cubeOne = GameObject.FindGameObjectWithTag("cubeOne");
		cubeTwo = GameObject.FindGameObjectWithTag("cubeTwo");
		cubeThree = GameObject.FindGameObjectWithTag("cubeThree");
		cubeFour = GameObject.FindGameObjectWithTag("cubeFour");
		cubeFive = GameObject.FindGameObjectWithTag("cubeFive");
		cubeSix = GameObject.FindGameObjectWithTag("cubeSix");
		cubeSeven = GameObject.FindGameObjectWithTag("cubeSeven");
		cubeEight = GameObject.FindGameObjectWithTag("cubeEight");
		cubeNine = GameObject.FindGameObjectWithTag("cubeNine");
        cubeOne.SetActive(true);
        cubeTwo.SetActive(true);
        cubeThree.SetActive(true);
        cubeFour.SetActive(true);
        cubeFive.SetActive(true);
        cubeSix.SetActive(true);
        cubeSeven.SetActive(true);
        cubeEight.SetActive(true);
        cubeNine.SetActive(true);

    }

	public static bool returnActiveStatusFromTag(string strin)
	{
		int cubeId = returnIntFromTag(strin);
		bool returnBool = cubes[cubeId].activeSelf;
		return returnBool;
	}

	public static int returnIntFromTag(string strin)
	{
		switch (strin)
		{
		case "cubeOne":		return 0;
		case "cubeTwo":		return 1;
		case "cubeThree":	return 2;
		case "cubeFour":	return 3;
		case "cubeFive":	return 4;
		case "cubeSix":		return 5;
		case "cubeSeven":	return 6;
		case "cubeEight":	return 7;
		case "cubeNine":	return 8;
		default:			return -1;
		}
	}

	public static void toggleObjectActiveFromTag(string strin)
	{
		int cubeId = returnIntFromTag(strin);
		cubes[cubeId].SetActive(!cubes[cubeId]);
	}
	public static bool returnClickableStatusFromTag(string strin)
	{
		int cubeId = returnIntFromTag(strin);
		if(cubeId == 0){
			return true;
		} else {
			cubeId -= 1;
			bool returnBool = !cubes[cubeId].activeSelf;
			//Debug.Log(returnBool);
			return returnBool;
		}
	}

    public static void deactivateObjectFromString(string strin)
    {
		Debug.Log("deactivateObjectFromString(string) depreciated. Use toggleObjectActiveFromTag instead");
        switch (strin)
        {
            case "cubeOne":
                cubeOne.SetActive(false);
            break;

            case "cubeTwo":
                if (!cubeOne.activeSelf)
                {
                    //Debug.Log("hello");
                    cubeTwo.SetActive(false);
                }
            break;

            case "cubeThree":
                if (!cubeTwo.activeSelf)
                {
                    cubeThree.SetActive(false);
                }
            break;

            case "cubeFour":
                if (!cubeThree.activeSelf)
                { 
                	cubeFour.SetActive(false);
                }  
            break;

            case "cubeFive":
                if (!cubeFour.activeSelf)
                {
                    cubeFive.SetActive(false);
                }
            break;

            case "cubeSix":
                if (!cubeFive.activeSelf)
                {
                    cubeSix.SetActive(false);
                }
            break;

            case "cubeSeven":
                if (!cubeSix.activeSelf)
                {
                    cubeSeven.SetActive(false);
                }
            break;

            case "cubeEight":
                if (!cubeSeven.activeSelf)
                {
                    cubeEight.SetActive(false);
                }
            break;

            case "cubeNine":
                if (!cubeEight.activeSelf)
                {
                    cubeNine.SetActive(false);
                }
            break;
       }

    }
   
}

