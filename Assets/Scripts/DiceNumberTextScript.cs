using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DiceNumberTextScript : MonoBehaviour {

	public TMP_Text text1;
	public TMP_Text text2;
	//public TMP_Text textRN;
	//public TMP_Text dice1Value;
	//public TMP_Text dice2Value;
	public static int diceNumber1;
	public static int diceNumber2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
		text1.text = diceNumber1.ToString ();
		text2.text = diceNumber2.ToString ();
	}

	/*public void ResetButton()
    {
		Debug.Log(text1.text);
		Debug.Log(text2.text);
	}*/
}
