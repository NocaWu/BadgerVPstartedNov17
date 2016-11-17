using UnityEngine;
using System.Collections;

public class treeSwaying : MonoBehaviour {
	Transform[] children;

	// Use this for initialization
	void Start () {
		children = gameObject.GetComponentsInChildren<Transform> ();

	}
	
	// Update is called once per frame
	void Update () {
		foreach (Transform child in children) {
			if (child != this.transform) {
				child.transform.eulerAngles = new Vector3(
					Mathf.Sin(Time.time + child.transform.position.x + child.transform.position.z),
					Mathf.Sin(Time.time + child.transform.position.x + child.transform.position.z), 
					Mathf.Sin(Time.time + child.transform.position.x + child.transform.position.z));
			}
		}
	}
}
