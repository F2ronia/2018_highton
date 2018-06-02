using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimHands : MonoBehaviour
{
    private Animator anim;
    //
    private bool isClicked;
    //
    private bool beHolding;
    //

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        test();
    }



    void test()
    {
        if (Input.GetKey(KeyCode.R))
        {
            isClicked = true;
            anim.SetBool("isClicked", true);
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            isClicked = false;
            anim.SetBool("isClicked", false);
        }
    }
}
