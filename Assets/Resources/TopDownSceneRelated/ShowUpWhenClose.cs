using UnityEngine;
using System.Collections;

public class ShowUpWhenClose : MonoBehaviour {

	Transform[] children;
	public Transform fox; // player
	Color trans;
	Color normal;

	// Use this for initialization
	void Start () {
		children = gameObject.GetComponentsInChildren<Transform> ();

		trans = new Vector4 (1,1,1,0); // transparent
		normal = new Vector4 (1,1,1,1); // white
	}
	
	// Update is called once per frame
	void Update () {
		// check dist: every child to fox
		foreach (Transform child in children) {
			if(child != this.transform){
				float dist = Vector3.Distance (child.transform.position, fox.position);
				if (dist >= 2.0f) {
					child.gameObject.GetComponent<SpriteRenderer> ().color= trans;
				}else{
					// if not, give it a chance of showing up near the player
					float f = Random.Range (0, Mathf.Abs (fox.position.x - child.position.x));
					float g = Random.Range (0, Mathf.Abs (fox.position.y - child.position.y));
					if (f <= 1.5f && g <= 0.001f) { 
					child.gameObject.GetComponent<SpriteRenderer> ().color = normal;	
					} 
				}
			}
		}
	}
}
