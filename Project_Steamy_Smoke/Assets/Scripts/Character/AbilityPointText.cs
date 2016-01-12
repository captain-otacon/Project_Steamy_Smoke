using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AbilityPointText : MonoBehaviour {
	public int AbilityChanger;
	AbilityPoints AbilityPoints;
	Text text;
	// Use this for initialization
	void Awake () {
		AbilityPoints = GameObject.Find("PlayerAbilityPoints").GetComponent<AbilityPoints>();
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		TextUpdate ();
	}

	void TextUpdate() {
		if (AbilityChanger == 0) {
			text.text = "" + AbilityPoints.Str + "";
		} else if (AbilityChanger == 1) {
			text.text = "" + AbilityPoints.Dex + "";
		} else if (AbilityChanger == 2) {
			text.text = "" + AbilityPoints.Con + "";
		} else if (AbilityChanger == 3) {
			text.text = "" + AbilityPoints.Int + "";
		} else if (AbilityChanger == 6) {
			text.text = "" + AbilityPoints.Wis + "";
		} else if (AbilityChanger == 5) {
			text.text = "" + AbilityPoints.Cha + "";
		}
	}
}
