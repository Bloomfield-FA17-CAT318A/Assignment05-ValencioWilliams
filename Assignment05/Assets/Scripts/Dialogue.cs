using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class Dialogue {

	public static Dialogue thisDiaglogue;

	public string firstText;
	public string secondText;

	public Dialogue(string n1, string n2)
	{
		thisDiaglogue = this;
		firstText = n1; 
		secondText = n2;
	}

	public void Set(string n1, string n2)
	{
		firstText = n1;
		secondText = n2;
	}

	public Dialogue Get()
	{
		return new Dialogue (firstText, secondText);
	}


	public override string ToString()
	{
		return firstText + " " + secondText;
	}

}