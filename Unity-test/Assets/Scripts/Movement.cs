using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 heading = new Vector3(0,0);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            heading = new Vector3(-1f, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            heading = new Vector3(0, 0, 1f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            heading = new Vector3(0, 0, -1f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            heading = new Vector3(1f, 0);
        }
        if(heading.x + heading.y + heading.z != 0)
            transform.position = transform.position + heading * Time.deltaTime;
    }
}
