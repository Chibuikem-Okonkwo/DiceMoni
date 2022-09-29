using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheckZoneScript : MonoBehaviour {

	Vector3 diceVelocity1;
	Vector3 diceVelocity2;

	// Update is called once per frame
	void FixedUpdate () {
		diceVelocity1 = DiceScript.diceVelocity1;
		diceVelocity2 = DiceScript.diceVelocity2;
	}

	void OnTriggerStay(Collider col)
	{
		if (diceVelocity1.x == 0f && diceVelocity1.y == 0f && diceVelocity1.z == 0f)
		{
			switch (col.gameObject.name) {
			case "side1":
				DiceNumberTextScript.diceNumber1 = 6;
				break;
			case "side2":
				DiceNumberTextScript.diceNumber1 = 5;
				break;
			case "side3":
				DiceNumberTextScript.diceNumber1 = 4;
				break;
			case "side4":
				DiceNumberTextScript.diceNumber1 = 3;
				break;
			case "side5":
				DiceNumberTextScript.diceNumber1 = 2;
				break;
			case "side6":
				DiceNumberTextScript.diceNumber1 = 1;
				break;
			}
		}
		
		if (diceVelocity2.x == 0f && diceVelocity2.y == 0f && diceVelocity2.z == 0f)
		{
			switch (col.gameObject.name) {
			case "side1(2)":
				DiceNumberTextScript.diceNumber2 = 6;
				break;
			case "side2(2)":
				DiceNumberTextScript.diceNumber2 = 5;
				break;
			case "side3(2)":
				DiceNumberTextScript.diceNumber2 = 4;
				break;
			case "side4(2)":
				DiceNumberTextScript.diceNumber2 = 3;
				break;
			case "side5(2)":
				DiceNumberTextScript.diceNumber2 = 2;
				break;
			case "side6(2)":
				DiceNumberTextScript.diceNumber2 = 1;
				break;
			}
		}
	}
}
