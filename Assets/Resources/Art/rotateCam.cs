using UnityEngine;
using System.Collections;

public class rotateCam : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)){
			transform.Rotate( new Vector3 (0,-20,0)*Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.D)){
			transform.Rotate( new Vector3 (0,20,0)*Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.W)){
			transform.Rotate( new Vector3 (-10,0,0)*Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.S)){
			transform.Rotate( new Vector3 (10,0,0)*Time.deltaTime);
		}
	}
}
