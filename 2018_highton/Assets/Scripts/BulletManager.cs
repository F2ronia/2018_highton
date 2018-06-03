using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour {

    public int hitCnt = 0;
    //
    public static BulletManager instance;
    //

    private void Awake()
    {
        if (BulletManager.instance == null)
            BulletManager.instance = this;
    }

    private float speed = 10000.0f;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddForce(transform.forward * speed);	
	}

    private void OnCollisionEnter(Collision col)
    {
        hitCnt++;
        Destroy(this.gameObject);
    }
}
