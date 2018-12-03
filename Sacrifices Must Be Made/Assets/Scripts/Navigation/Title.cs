using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Navigate to story screen
    public void Next()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Story", UnityEngine.SceneManagement.LoadSceneMode.Single);
    }
}
