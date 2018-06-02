using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllHands : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mPos = Input.mousePosition;
        Vector3 oPos = transform.position;

        mPos.z = oPos.z - Camera.main.transform.position.z;

        Vector3 target = Camera.main.ScreenToWorldPoint(mPos);

        float dy = target.y - oPos.y;
        float dx = target.x - oPos.x;

        float rotateDegree = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, rotateDegree);
	}
}
