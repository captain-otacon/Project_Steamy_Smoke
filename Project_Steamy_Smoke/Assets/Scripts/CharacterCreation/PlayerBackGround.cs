using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerBackGround : MonoBehaviour {
	int valuetext;
	Text raceMenu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RaceBackground ();
	}

	void RaceBackground () {
		if (valuetext == 0) {
			raceMenu.text = "Human Race";
		} else if (valuetext == 1) {
			raceMenu.text = "Elf Race";
		} else if (valuetext == 2) {
			raceMenu.text = "Dwarf Race";
		}
	}	
}
