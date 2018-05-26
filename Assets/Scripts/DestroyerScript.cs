using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyerScript : MonoBehaviour {

    void OnTriggerEnter2D (Collider2D other) {
        if (other.tag == "Player") {
			SavePlayerProgress ();
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (other.gameObject.transform.parent) {
            Destroy(other.gameObject.transform.parent.gameObject);
        } else {
            Destroy(other.gameObject);
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void SavePlayerProgress() {
		PlayerPrefs.SetInt("currentScore", HUDscript.scoreValue);
	}
}
