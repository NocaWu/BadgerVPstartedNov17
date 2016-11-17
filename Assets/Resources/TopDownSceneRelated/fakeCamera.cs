using UnityEngine;
using System.Collections;

public class fakeCamera : MonoBehaviour {
	public GameObject mainCamera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (mainCamera.transform.position.x, mainCamera.transform.position.y, -6.2114f);
	}
}
