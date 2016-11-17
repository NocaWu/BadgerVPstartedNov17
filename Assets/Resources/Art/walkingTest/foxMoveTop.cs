using UnityEngine;
using System.Collections;

public class foxMoveTop : MonoBehaviour {
//	float middleToFox;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		middleToFox = Vector3.Distance (new Vector3(0,0,0), transform.position);
//		if(middleToFox < 6.0f){
			if (Input.GetKey(KeyCode.J)){
				transform.position += new Vector3 (-2f,0,0)*Time.deltaTime;
			}

			if (Input.GetKey(KeyCode.L)){
				transform.position += new Vector3 (2f,0,0)*Time.deltaTime;
			}

			if (Input.GetKey(KeyCode.I)){
				transform.position += new Vector3 (0,1f,0)*Time.deltaTime;
			}

			if (Input.GetKey(KeyCode.K)){
				transform.position += new Vector3 (0,-1f,0)*Time.deltaTime;
			}
//		}
	}
}
