using UnityEngine;
using System.Collections;

public class FaceCamera : MonoBehaviour {
	
	Transform[] children;
	public Transform camera;

	// Use this for initialization
	void Start () {
		children = gameObject.GetComponentsInChildren<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		//turn towards
		//lookat
		foreach (Transform child in children) {
			if(child != this.transform){
				child.LookAt(camera.position);}
		}
	
	}
}
