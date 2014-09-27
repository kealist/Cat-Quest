// Character.cs
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character : MonoBehaviour
{
	private List<RPGClass> m_Classes;
	
	void Start()
	{
		m_Classes = new List<RPGClass>(); // could populate collection during instantiation if you wanted
		m_Classes.Add (
			new RPGClass () { ClassName = "Player", Strength = 12, Vitality = 12, Dexterity = 10, Intelligence = 8 }
				);
		m_Classes.Add (
			new RPGClass () { ClassName = "BlackMouse", Strength = 10, Vitality = 11, Dexterity = 12, Intelligence = 2 }
				);
	}
}