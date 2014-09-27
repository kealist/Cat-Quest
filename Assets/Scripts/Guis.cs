using UnityEngine;
using System.Collections;


public class Guis : MonoBehaviour {
	void OnGUI() {
		GUI.color = Color.black;
		StatScript playerStats = GameObject.Find("Player").GetComponent<StatScript>();
		GUILayout.Button("Explore");
		GUILayout.Label ("Health: " + playerStats.totalHP);
		GUILayout.Label ("Magic: " + playerStats.totalMP);
		GUILayout.Label ("Strength: " + playerStats.totalSTR);
		GUILayout.Label ("Vitality: " + playerStats.totalVIT);
		GUILayout.Label ("Intelligence: " + playerStats.totalINT);

	}
}