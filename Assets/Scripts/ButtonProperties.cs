using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class ButtonProperties : MonoBehaviour {

    private Renderer renderer;
    AudioSource audioSource = null;

    // Use this for initialization
    void Start () {

        SetTexture();
        SetAudio();

    }

    // Set button texture
    void SetTexture()
    {
        // Get the texture path and remove (Clone) string
        string texturePath = "Textures/" + transform.name.Replace("(Clone)", "");

        // Load the texture
        GetComponent<Renderer>().material.mainTexture = (Texture)Resources.Load("Textures/original", typeof(Texture));

        if (transform.name.Contains("_lower"))
        {
            // Load the texture
            GetComponent<Renderer>().material.mainTexture = (Texture)Resources.Load("Textures/lower", typeof(Texture));
        }
        if (transform.name.Contains("_higher"))
        {
            // Load the texture
            GetComponent<Renderer>().material.mainTexture = (Texture)Resources.Load("Textures/higher", typeof(Texture));
        }



        //// Get the note name
        string noteName = transform.name.Replace("_higher", "").Replace("_lower", "").Replace("(Clone)", "");

        //// Find surfaces and add text with notename
        transform.FindChild("front").gameObject.GetComponent<TextMesh>().text = noteName;
        transform.FindChild("left").gameObject.GetComponent<TextMesh>().text = noteName;
        transform.FindChild("right").gameObject.GetComponent<TextMesh>().text = noteName;
        transform.FindChild("bottom").gameObject.GetComponent<TextMesh>().text = noteName;
        transform.FindChild("top").gameObject.GetComponent<TextMesh>().text = noteName;
    }

    // Set button audio
    void SetAudio()
    {

        // Get the audio path and remove (Clone) string
        string audioPath = "Audios/" + transform.name.Replace("(Clone)", "");

        // Add an AudioSource component and set up some defaults
        audioSource = gameObject.AddComponent<AudioSource>();

        // Load Clip
        audioSource.clip = (AudioClip) Resources.Load(audioPath);

        // Default settings
        audioSource.playOnAwake = false;
        audioSource.spatialize = true;
        audioSource.spatialBlend = 1.0f;
        audioSource.dopplerLevel = 0.0f;
        audioSource.rolloffMode = AudioRolloffMode.Logarithmic;
        audioSource.volume = 1.0f;

    }

    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        audioSource.Play();
    }
}
