using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour {

    HUDscript hud;

    void OnTriggerEnter2D (Collider2D other) {
        if (other.tag == "Player") {
            hud = GameObject.Find("Main Camera").GetComponent<HUDscript>();
            hud.IncreaseScore(10);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            Destroy(this.gameObject, 3f);

            if(Settings.MusicSettings.IsMusicOn)
            {
                gameObject.GetComponent<AudioSource>().Play();
            }
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
