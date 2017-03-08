using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;

public class StayWithCamera : MonoBehaviour {

    private float z;

    // Use this for initialization
    void Start () {
        z = this.transform.position.z;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 newPosition = Vector3.Lerp(this.transform.position, Camera.main.transform.position + (Camera.main.transform.forward * z), Time.deltaTime * 10);
        this.transform.position = newPosition;
    }
}
