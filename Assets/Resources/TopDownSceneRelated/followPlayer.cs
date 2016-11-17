using UnityEngine;
using System.Collections;

public class followPlayer : MonoBehaviour {
	public GameObject fox;
	float middleToFox;
	Vector3 camOriPos;
	Vector3 camEdgePos;

	// Use this for initialization
	void Start () {
		camOriPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		// camera control depend on fox position
		middleToFox = Vector3.Distance (new Vector3(0,0,0), fox.transform.position);
//		Debug.Log (middleToFox);

		// if fox left the central part, follow it
		if (middleToFox > 2.0f) {
			transform.position = new Vector3 (
				Mathf.Lerp (transform.position.x, fox.transform.position.x, 0.01f),
				Mathf.Lerp (
					transform.position.y,
					fox.transform.position.y+2.7f, 0.01f),
				Mathf.Lerp(
				transform.position.z,fox.transform.position.z-3f, 0.01f)
			);

		// if fox go back to center area, camera go back to its ori pos
		} else if (middleToFox <= 2.0f) {
			transform.position = Vector3.Lerp (transform.position, camOriPos, 0.01f);
		}

		// look up when you are on the edge
		if (fox.transform.position.y >= 2.0f) {
			float angle = Mathf.LerpAngle(0, -30, 0.05f);
			transform.eulerAngles = new Vector3(angle, 0, 0);		
		}
	}

}
