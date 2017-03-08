using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Director;

public class ButtonAnimation : MonoBehaviour {

    public Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        
        // clipLength = animator.GetCurrentAnimatorClipInfo(0)[0].clip.length;

    }
	
	// Update is called once per frame
	void Update () {

	}

    // Air Tapped
    void OnSelect()
    {
        anim.SetTrigger("Bounce");
    }


    bool isAnimationPlaying()
    {
        return anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !anim.IsInTransition(0);
    }

}
