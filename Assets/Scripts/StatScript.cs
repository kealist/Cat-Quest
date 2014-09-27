using UnityEngine;

/// <summary>
/// Handle hitpoints and damages
/// </summary>
public class StatScript : MonoBehaviour
{

	/// <summary>
	/// Total hitpoints
	/// </summary>
	public int baseHP = 34;
	public int baseMP = 12;
	public int baseSTR = 12;
	public int baseDEX = 12;
	public int baseINT = 12;
	public int baseVIT = 12;

	public int totalHP = 34;
	public int totalMP = 10;
	public int totalSTR = 12;
	public int totalDEX = 12;
	public int totalINT = 12;
	public int totalVIT = 12;
	/// <summary>
	/// Enemy or player?
	/// </summary>
	public bool isEnemy = true;
	
	/// <summary>
	/// Inflicts damage and check if the object should be destroyed
	/// </summary>
	/// <param name="damageCount"></param>
	public void Damage(int damageCount)
	{
		totalHP -= damageCount;
		
		if (totalHP <= 0)
		{
			// Dead!
			Destroy(gameObject);
		}
	}
}
