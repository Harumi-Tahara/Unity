using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JsonTest : MonoBehaviour {

	public Data PlayerData;
	public InputList Input;
	public Text angou;

	public void UpdatePlayerSatus()
	{
		PlayerData.Name = Input.Name.text;
		PlayerData.HensinType = (Data.HENSIN_TYPE)Input.Type.value;
		PlayerData.Level = int.Parse(Input.Level.text);
		PlayerData.Status.Atk = int.Parse(Input.Atk.text);
		PlayerData.Status.Def = int.Parse(Input.Def.text);

		ToJson();
		Input.text.text = jsontxt;

		Angou();
	}

	public string jsontxt;

	public void ToJson(){
		jsontxt = JsonUtility.ToJson(PlayerData,true);

	}

	public byte[] b;
	public void Angou(){
		b = System.Text.Encoding.UTF8.GetBytes(jsontxt);
		string byteStr = System.BitConverter.ToString(b);

		angou.text = byteStr;


	}

}

[System.Serializable]
public class InputList{

	public InputField Name;
	public Dropdown Type;
	public InputField Level;
	public InputField Atk;
	public InputField Def;

	public Text text;
}

[System.Serializable]
public class OutputList{
	public Text Name;
	public Text Type;
	public Text Level;
	public Text Atk;
	public Text Def;
}