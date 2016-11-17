using UnityEngine;
using System.Collections;

public class mountMatCntrl : MonoBehaviour {

	Material planeMat;
	float offset = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		offset -= 0.0001f;
		planeMat = gameObject.GetComponent<MeshRenderer> ().material;
		planeMat.SetTextureOffset("_MainTex", new Vector2(offset,0.0f));
	}
}
