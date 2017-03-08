using UnityEngine;
using UnityEngine.VR.WSA.Input;
using System.Collections;

public class MenuButtonCommand : MonoBehaviour
{

    public GameObject World;
    public GameObject Audio;
    private GameObject currentButton;
    private GameObject root;

    // Use this for initialization
    void Start()
    {
        currentButton = this.transform.gameObject;
        root = this.transform.root.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {

        // If Yes button
        if (currentButton.CompareTag("MenuYes"))
        {
            // Enable background music
            Audio.SetActive(true);
        }

        // If No button
        if (currentButton.CompareTag("MenuNo"))
        {
            // Disable background music
            Audio.SetActive(false);
        }

        // Disable Menu
        DisableMenu();

        // Enable World
        EnableWorld();
    }

    // Disable Menu
    void DisableMenu()
    {
        StartCoroutine(Delay());
    }

    // Enable World 
    void EnableWorld()
    {
        World.SetActive(true);
    }

    // Thread
    IEnumerator Delay()
    {
        SetRigidBody();
        yield return new WaitForSeconds(2);
        root.SetActive(false);
    }

    void SetRigidBody()
    {
        //If the sphere has no Rigidbody component, add one to enable physics.
        if (!root.GetComponent<Rigidbody>())
        {
            var rigidbody = root.gameObject.AddComponent<Rigidbody>();
            rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
        }
    }
}
