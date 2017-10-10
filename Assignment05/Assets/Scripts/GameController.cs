using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
	public static GameController instance;

	public string firstText;
	public string secondText;

	public Text textbox;
	public InputField input1;
	public InputField input2;

	public Dialogue chat;

	public enum STATES
	{
		NEWGAME,
		CURRENT,
		ENDGAME,
	};

	public STATES gameState;
	//change this to be represent what happens in what state

	void Start ()
	{
		instance = this;

		gameState = STATES.NEWGAME;
		
		chat = new Dialogue (firstText, secondText);

		if (chat != null)
		{
			ChangeDialogue ();
		}
	}


	void Update ()
	{
		//StateChange ();

		ChangeDialogue ();

		if (Input.GetKeyDown (KeyCode.Return))
		{
			chat.Set (input1.text, input2.text);
		}

	}


	public void ChangeDialogue ()
	{
		textbox.text = chat.firstText + "\n\n" + chat.secondText;
	}

	public void SaveDialogue ()
	{
		DataStoring.Save ();
	}

	public void LoadDiaglogue ()
	{

		DataStoring.Load ();

		gameState = STATES.CURRENT;

		ChangeDialogue ();
	}

	void StateChange ()
	{
		switch (gameState)
		{
			case STATES.NEWGAME:
			{
				chat = new Dialogue (firstText, secondText);
				break;
			}
			case STATES.CURRENT:
			{
				//chat = Dialogue.thisDiaglogue;
				break;

			}
			case STATES.ENDGAME:
			{
				
				break;

			}
		}
	}

}