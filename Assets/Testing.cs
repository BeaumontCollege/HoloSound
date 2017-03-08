using UnityEngine;
using UnityEngine.VR.WSA.Input;
using System.Collections;


public class Testing : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnSelect()
    {
        Debug.Log("On Select");
    }
    void OnHoldStarted()
    {
        Debug.Log("On Hold Started");
    }
    void OnHoldCompleted()
    {
        Debug.Log("On Hold Completed");
    }
    void OnHoldCanceled()
    {
        Debug.Log("On Hold Canceled");
    }
}
