using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerBackGround : MonoBehaviour {
	public Dropdown raceMenu;
	public Text text;
	// Use this for initialization
	void Start () {
		text = gameObject.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateText ();
	}

	public void UpdateText () {
		if (raceMenu.value == 0) {
			text.text = "Human's are most common type of creature in the world of Galerracia and you can find then in any kind of profession. Best race for multiclassing. +1 for every ability";
		} else if (raceMenu.value == 1) {
			text.text = "Elf";
		} else if (raceMenu.value == 2) {
			text.text = " Dwarf";
		}
	}
}
