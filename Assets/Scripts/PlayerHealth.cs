using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
	private int health = 100;
	public Text healthUI;
	
	public void TakeDamage(int dmg)
	{
		health -= dmg;
		healthUI.text = $"HP: {health}";
	}
}
