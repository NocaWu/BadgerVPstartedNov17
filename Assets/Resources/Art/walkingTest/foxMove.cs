using UnityEngine;
using System.Collections;

public class foxMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.J)){
			transform.position += new Vector3 (-5f,0,0)*Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.L)){
			transform.position += new Vector3 (5f,0,0)*Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.I)){
			transform.position += new Vector3 (0,0,5f)*Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.K)){
			transform.position += new Vector3 (0,0,-5f)*Time.deltaTime;
		}
	
	}
}
