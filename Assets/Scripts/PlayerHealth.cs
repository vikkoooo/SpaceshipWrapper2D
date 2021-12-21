using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
	// Health standard int
	private int health = 100;
	public Text healthUI;
	
	// Health scriptable object
	public Text betterHealthText;
	public BetterIntVariable betterHealthInt;
	
	// Damage taken all time super simple scriptable object
	public Text dmgTakenAllTimeUI;
	public IntVariable dmgTakenAllTime;
	
	public void TakeDamage(int dmg)
	{
		health -= dmg;
		betterHealthInt.currentValue -= dmg;
		dmgTakenAllTime.value += dmg;
		
		healthUI.text = $"HP standard int: {health}";
		betterHealthText.text = $"HP scriptable object: {betterHealthInt.currentValue}";
		dmgTakenAllTimeUI.text = $"Dmg taken all time: {dmgTakenAllTime.value}";
	}
	
}
