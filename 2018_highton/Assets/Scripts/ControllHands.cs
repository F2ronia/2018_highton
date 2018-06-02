using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllHands : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.forward * 1.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.back * 1.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * 1.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * 1.0f * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.W))
        {
            this.transform.Rotate(new Vector3(50.0f, 0.0f, 0.0f) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Rotate(new Vector3(-50.0f, 0.0f, 0.0f) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(new Vector3(0.0f, 0.0f, 50.0f) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(new Vector3(0.0f, 0.0f, -50.0f) * Time.deltaTime);
        }

    }
}