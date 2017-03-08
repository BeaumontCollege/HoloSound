using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;

public class MenuManager : MonoBehaviour {

    private GameObject btnYes;
    private GameObject btnNo;
    private GameObject focusedObject;
    private GameObject Audio;

    // Use this for initialization
    void Start () {

        // Initalize audio object
        Audio = GameObject.Find("Background");

        // Get the current focused object
        focusedObject = GazeManager.Instance.HitInfo.collider.gameObject;

        //Get all components in children
        Transform[] children = GetComponentsInChildren<Transform>();

		// Find its children 
        foreach(Transform child in children)
        {
            // Find Yes button by its tag
            if (child.CompareTag("MenuYes"))
            {
                btnYes = child.gameObject;
            }
            // Find No button by its tag
            if (child.CompareTag("MenuNo"))
            {
                btnNo = child.gameObject;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (focusedObject == btnYes)
        {
            Debug.Log("Gazing on Button Yes");
            focusedObject.SendMessage("onSelect");
        }
        if (focusedObject == btnNo)
        {
            Debug.Log("No no no no no ..");
        }
    }

    void OnSelect()
    {
        Audio.SetActive(true);
    }
}
