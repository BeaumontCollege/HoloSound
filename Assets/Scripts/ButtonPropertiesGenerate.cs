using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPropertiesGenerate : MonoBehaviour {

    private Texture currentTexture;
    private Renderer renderer;
    private Object[] textures;
    private Object[] audios;
    private int i = 0;

    // Use this for initialization
    void Start () {

        renderer = GetComponent<Renderer>();

        // Get the current texture
        currentTexture = renderer.material.mainTexture;

        //string texturePath = "textures/A#";
        //renderer.material.mainTexture = (Texture)Resources.Load(texturePath, typeof(Texture));

        textures = Resources.LoadAll("Textures");
        audios = Resources.LoadAll("Audios");

        GameObject[] buttons = GameObject.FindGameObjectsWithTag("Button");


        foreach (GameObject button in buttons)
        {
            // Get button texture
            Texture btnTexture = button.GetComponent<Renderer>().material.mainTexture;

            if (currentTexture != btnTexture)
            {
                renderer.material.mainTexture = (Texture) textures[i];
                
                return;
            }
            Debug.Log(i);
        }


    }
	
	// Update is called once per frame
	void Update () {

    }
}
