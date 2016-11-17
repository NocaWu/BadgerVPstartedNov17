﻿using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.UI;

public class UITextFader_HackyOnMouseClick : MonoBehaviour {

	public float travelTime;
	//Image myimg;
	Text mytext;
	// Use this for initialization
	void Start () {
		//myimg = GetComponent<Image> ();
		mytext = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad > 1f) {
			if (Input.GetMouseButtonDown (0)) {
				//myimg.DOFade (0f, travelTime);
				mytext.DOFade (0f, travelTime).OnComplete(() => gameObject.SetActive(false));
			}
		}
	}
}
