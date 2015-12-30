using UnityEngine;
using System.Collections;

public class errorTest : MonoBehaviour {
    public  static GameObject cubeOne;
    public  static GameObject cubeTwo;
    public  static GameObject cubeThree;
    public  static GameObject cubeFour;
    public  static GameObject cubeFive;
    public  static GameObject cubeSix;
    public  static GameObject cubeSeven;
    public  static GameObject cubeEight;
    public  static GameObject cubeNine;

    public void Start()
    {
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

    public static void toggleObjectFromString(string strin)
    {
        switch (strin)
        {
            case "cubeOne":
                cubeOne.SetActive(false);
                break;

            case "cubeTwo":
                if (!cubeOne.activeSelf)
                {
                    Debug.Log("hello");
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

