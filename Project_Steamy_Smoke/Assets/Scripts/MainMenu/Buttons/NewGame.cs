using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewGame : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void onClick () {
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Character Creation");
	}
}
