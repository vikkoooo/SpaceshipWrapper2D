using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
	private int health = 100;
	public Text healthUI;
	public Text dmgTakenAllTimeUI;
	public IntVariable dmgTakenAllTime;
	
	public void TakeDamage(int dmg)
	{
		health -= dmg;
		dmgTakenAllTime.Value += dmg;
		healthUI.text = $"HP: {health}";
		dmgTakenAllTimeUI.text = $"Dmg taken all time: {dmgTakenAllTime.Value}";
	}
	
}
