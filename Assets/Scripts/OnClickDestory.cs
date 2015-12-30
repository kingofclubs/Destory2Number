using UnityEngine;
using System.Collections;

public class OnClickDestory : MonoBehaviour
{
    GameObject gameObj;
    public GameObject squareOne;
    Animator ani;
    bool _isAlive;


    // Use this for initialization
    void Start()
    {
        ani = GetComponent<Animator>();
        gameObj = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Transform select = gameObj.transform;
            if (Physics.Raycast(ray, out hit))
            {
                //select.tag = "Untagged";
                //hit.collider.transform.tag = "Player";
                //Debug.Log("???");
                _isAlive = hit.collider == gameObj.GetComponent<BoxCollider>();
				bool isClickable = errorTest.returnClickableStatusFromTag(hit.collider.tag);
				//Debug.Log(hit.collider.tag);
				ani.SetBool("isClicked", _isAlive & isClickable);
            }
        }
    }
    void DestoryObject()
    {
        errorTest.toggleObjectActiveFromTag(gameObj.tag);
        gameObj.SetActive(false);
        //Destroy(squareOne);
		//Debug.Log("Boop");
        
    }
}

