using UnityEngine;
using UnityEngine.VR.WSA.Input;
using System.Collections;

public class ButtonAudio : MonoBehaviour
{
    [Tooltip("Solo Music")]
    AudioSource audioSource = null;
    public AudioClip clip;

    void Start()
    {
        // Add an AudioSource component and set up some defaults
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = clip;
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
        //If the sphere has no Rigidbody component, add one to enable physics.
        //if (!this.GetComponent<Rigidbody>())
        //{
        //    var rigidbody = this.gameObject.AddComponent<Rigidbody>();
        //    rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
        //}

        audioSource.Play();
    }

}