using UnityEngine;
using System.Collections;


public class Guis : MonoBehaviour {
	void OnGUI() {
		GUI.color = Color.black;
		GUI.backgroundColor = Color.white;
		StatScript playerStats = GameObject.Find("Player").GetComponent<StatScript>();
		GUILayout.Button("Explore");
		GUILayout.Button("Run away");
		GUILayout.Button("Attack");
		GUILayout.BeginArea(new Rect(0, Screen.height/4, 300, 300));
		GUILayout.Label("Health: " + playerStats.totalHP);
		GUILayout.Label("Magic: " + playerStats.totalMP);
		GUILayout.Label("Strength: " + playerStats.totalSTR);
		GUILayout.Label("Vitality: " + playerStats.totalVIT);
		GUILayout.Label("Intelligence: " + playerStats.totalINT);
		GUILayout.EndArea();
	}
}