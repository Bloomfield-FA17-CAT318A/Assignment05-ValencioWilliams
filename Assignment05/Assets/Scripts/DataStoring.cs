using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class DataStoring : MonoBehaviour {

	public static void Save()
	{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create (Application.persistentDataPath + "/save_MyDialogue.txt");
		bf.Serialize (file, Dialogue.thisDiaglogue);
		file.Close ();

		Debug.Log ("SAVED AT: " + Application.persistentDataPath);


	}

	public static void Load()
	{
		if (File.Exists (Application.persistentDataPath + "/save_MyDialogue.txt"))
		{
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/save_MyDialogue.txt", FileMode.Open);
			GameController.instance.chat = (Dialogue)bf.Deserialize (file);
			file.Close ();

			Debug.Log ("DONE Loading: " + Application.persistentDataPath + "/save_MyDialogue.txt");

		}
	}
}
