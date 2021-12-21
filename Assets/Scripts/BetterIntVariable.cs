using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BetterIntVariable : ScriptableObject
{
	[SerializeField] private int value;
	public int currentValue { get; set; }
	
	private void OnEnable()
	{
		currentValue = value;
	}
}