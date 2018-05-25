using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDscript : MonoBehaviour {

    float playerScore = 0;
	private float _initialCameraPos = 0;

	// Use this for initialization
	void Start () {
		_initialCameraPos = Camera.main.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
        
	}


    public void IncreaseScore (int amount) {
        playerScore += amount;
    }

    void OnGUI () {
		GUI.Label(
			new Rect(20, 20, 100, 300), 
			"Score:" + (int) ((Camera.main.transform.position.x - _initialCameraPos + playerScore) * 100)
		);
    }
}
