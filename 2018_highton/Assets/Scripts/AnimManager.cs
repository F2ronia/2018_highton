using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimManager : MonoBehaviour {

    private bool isClicked;
    //
    private Animator anim_hand;
    //
    private Animator anim_cam;
    //

    private void Start()
    {
        if (anim_hand == null)
            anim_hand = GetComponent<Animator>();
        else
            anim_hand = null;

        if (anim_cam == null)
            anim_cam = GetComponent<Animator>();
        else
            anim_cam = null;
    }

    // Update is called once per frame
    void Update () {
        SetisClicked();
	}
    private void SetisClicked()
    {
        if(anim_hand != null)
        {
            if (Input.GetMouseButton(1))
                anim_hand.SetBool("isClicked", true);
            if (Input.GetMouseButtonUp(1))
                anim_hand.SetBool("isClicked", false);

        }
        else if(anim_cam != null)
        {
            if (Input.GetMouseButton(1))
                anim_cam.SetBool("isClicked", true);
            if (Input.GetMouseButtonUp(1))
                anim_cam.SetBool("isClicked", false);
        }
    }
}
