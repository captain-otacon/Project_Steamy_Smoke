using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AbilityPoints : MonoBehaviour {
	public int Str = 8;
	public int Dex = 8;
	public int Con = 8;
	public int Int = 8;
	public int Wis = 8;
	public int Cha = 8;

	public int Race; //0 on ihminen, 1 on elffi, 2 on kääpiö
	Dropdown RaceDropdown;
	// Use this for initialization
	void Awake () {
		RaceDropdown = GameObject.Find ("PlayerRace").GetComponent<Dropdown> ();
		Race = RaceDropdown.value;
		if (Race == 0) {
			Str = Str + 1;
			Dex = Dex + 1;
			Con = Con + 1;
			Int = Int + 1;
			Wis = Wis + 1;
			Cha = Cha + 1;
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
