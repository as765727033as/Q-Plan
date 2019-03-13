using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.transform.Find("Button_start").GetComponent<Button>().onClick.AddListener(() =>
        {
            Toast.show("暂未开放");
        });
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
