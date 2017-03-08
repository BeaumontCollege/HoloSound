using UnityEngine;
using UnityEngine.VR.WSA.Input;
using System.Collections;

public class Mapping : MonoBehaviour {

    private GameObject self;
    private PlaySpaceManager playSpaceManager;
    private GameObject spatialProcessing;
    private float scanTime;
    private float timer;
    private TextMesh textMesh;

    private bool called = false;

    // Use this for initialization
    void Start () {
        // Get current game object
        self = this.transform.gameObject;

        // Find spatial processing game object
        spatialProcessing = GameObject.Find("SpatialProcessing");
        
        // Find spatial processing's PlaySpaceManager script
        playSpaceManager = spatialProcessing.GetComponent<PlaySpaceManager>();

        // Access its property
        scanTime = playSpaceManager.scanTime;
        timer = scanTime;
        // Get current text mesh
        textMesh = GetComponent<TextMesh>();
        textMesh.alignment = TextAlignment.Center;
    }
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;
        textMesh.text = "Mapping... Please look around.\n" + timer.ToString("F0");

        //Send a tread that destroys itself after "scantime" seconds
        if (!called)
        {
            StartCoroutine(Delay());
            called = true;
        }
        
    }

    // Thread
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(scanTime);

        // Destroy self
        Destroy(self);
    }
}
