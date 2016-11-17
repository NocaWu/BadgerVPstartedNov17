using UnityEngine;
using System.Collections;

public class rotating : MonoBehaviour {
	public Component[] trans;

	// Use this for initialization
	void Start () {
		trans = GetComponentsInChildren<Transform> ();

	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)){
		foreach (Transform rotation in trans)
			transform.Rotate( new Vector3 (0,0.1f,0)*Time.deltaTime);
		}
	}
}
