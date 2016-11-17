using UnityEngine;
using System.Collections;

public class LightFloating : MonoBehaviour {
	Vector3 posOri;

	// Use this for initialization
	void Start () {
		posOri = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = posOri + new Vector3 (0, Mathf.Sin(posOri.x+Time.time), 0);
	
	}
}
