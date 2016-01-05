using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerBackGround : MonoBehaviour {
	public Dropdown raceMenu;
	public Text raceText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		UpdateText ();
	}

	public void UpdateText () {
		if (raceMenu.value == 0) {
			raceText.text = "Human";
		} else if (raceMenu.value == 1) {
			raceText.text = "Elf";
		} else if (raceMenu.value == 2) {
			raceText.text = " Dwarf";
		}
	}
}
