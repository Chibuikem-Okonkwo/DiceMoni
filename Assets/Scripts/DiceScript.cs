using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DiceScript : MonoBehaviour {

	static Rigidbody rb1;
	static Rigidbody rb2;
	public static Vector3 diceVelocity1;
	public static Vector3 diceVelocity2;
	public GameObject dice1;
	public GameObject dice2;

	public TMP_Text dice1Value;
	public TMP_Text dice2Value;
	public TMP_Text textRN;
	public static int diceNumber1;
	public static int diceNumber2;

	public Button rollButton;
	private bool isBtnClicked;
	public static bool gameIsPaused = false;

	private int rollNumber;

	public GameObject pauseMenu;
	public GameObject gameOverMenu;

	// Use this for initialization
	void Start () {
		rb1 = dice1.GetComponent<Rigidbody>();
		rb2 = dice2.GetComponent<Rigidbody>();
		isBtnClicked = false;
		rollNumber = 0;
		//ResetDicePosition();
	}

    public void ResetDicePosition()
    {
		
		//rb2 = dice2.GetComponent<Rigidbody>();
		//transform.position = new Vector3(0, 2, 0);
		//rb2.AddTorque(2, 2, 0);
		//transform.position = new Vector3(2, 2, 0);
	}

    // Update is called once per frame
    void Update () {
		/*diceVelocity1 = rb1.velocity;
		diceVelocity2 = rb2.velocity;

		if (Input.GetKeyDown (KeyCode.Space)) {
			DiceNumberTextScript.diceNumber1 = 0;
			float dirX = Random.Range (0, 500);
			float dirY = Random.Range (0, 500);
			float dirZ = Random.Range (0, 500);
			transform.position = new Vector3 (0, 2, 0);
			transform.rotation = Quaternion.identity;
			rb1.AddForce (transform.up * 500);
			rb1.AddTorque (dirX, dirY, dirZ);
		}
		
		diceVelocity2 = rb2.velocity;

		if (Input.GetKeyDown (KeyCode.Space)) {
			DiceNumberTextScript.diceNumber2 = 0;
			float dirX = Random.Range (0, 500);
			float dirY = Random.Range (0, 500);
			float dirZ = Random.Range (0, 500);
			transform.position = new Vector3 (2, 2, 0);
			transform.rotation = Quaternion.identity;
			rb2.AddForce (transform.up * 500);
			rb2.AddTorque (dirX, dirY, dirZ);
		}*/
	}

	void RollDice1()
    {
		//diceNumber1 = 0;
		float dirX = Random.Range(0, 500);
		float dirY = Random.Range(0, 500);
		float dirZ = Random.Range(0, 500);
		transform.position = new Vector3(0, 2, 0);
		transform.rotation = Quaternion.identity;
		rb1.AddForce(transform.up * 500);
		rb1.AddTorque(dirX, dirY, dirZ);
	}
	void RollDice2()
    {
		
		//diceNumber2 = 0;
		float dirX = Random.Range(0, 500);
		float dirY = Random.Range(0, 500);
		float dirZ = Random.Range(0, 500);
		transform.position = new Vector3(2, 2, 0);
		transform.rotation = Quaternion.identity;
		rb2.AddForce(transform.up * 500);
		rb2.AddTorque(dirX, dirY, dirZ);
	}

	public void RollDice()
    {

		diceVelocity1 = rb1.velocity;
		diceVelocity2 = rb2.velocity;
		if ( rollNumber == 0 || rollNumber > 0 && rollNumber < 6)
		{
			RollDice1();
			RollDice2();
			rollNumber++;
		}
        else
        {
			gameOverMenu.SetActive(true);
			FindObjectOfType<AudioManager>().Play("DiceLeaving");
			Time.timeScale = 0f;
        }
		
		//isBtnClicked = true;
		rollButton.interactable = false;

		FindObjectOfType<AudioManager>().Play("DiceLanding");

		UpdateRollData();


    }

	public void EndGame()
    {
		FindObjectOfType<AudioManager>().Play("EndGame");
	}
	
	public void DiceLeaving()
    {
		FindObjectOfType<AudioManager>().Play("DiceLeaving");
	}

	void UpdateRollData()
    {

		textRN.text = rollNumber.ToString();
		//dice1Value.text = diceNumber1.ToString();
		//dice2Value.text = diceNumber2.ToString();

		rollButton.interactable = true;
	}

	public void PauseButton()
    {
		pauseMenu.SetActive(true);
		Time.timeScale = 0f;
		gameIsPaused = true;
    }

	public void ResumeButton()
    {
		pauseMenu.SetActive(false);
		Time.timeScale = 1f; 
		gameIsPaused = false;
	}

	public void QuitButton()
    {
		SceneManager.LoadScene(SceneConstants.HomeScene);
		Time.timeScale = 1f;
    }

	public void PlayButton()
	{
		pauseMenu.SetActive(false);
		SceneManager.LoadScene(SceneConstants.HomeScene);
		Time.timeScale = 1f;
		gameIsPaused = false;
	}
}
