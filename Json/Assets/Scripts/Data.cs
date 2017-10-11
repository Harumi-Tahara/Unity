using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data
{

	[SerializeField]
	private new string name;
	public string Name { get { return name; } set { name = value; } }

	public enum HENSIN_TYPE
	{
		A,
		B,
		C
	}

	[SerializeField]
	private HENSIN_TYPE hensinType;
	public HENSIN_TYPE HensinType { get; set; }

	[SerializeField]
	private int level;
	public int Level{ get { return level; } set { level = value < 0 ? 0 : value; }}

	[System.Serializable]
	public struct StatusData{

		[SerializeField]
		private int atk;
		public int Atk{ get { return atk; } set { atk = value < 0 ? 0 : value; }}

		[SerializeField]
		private int def;
		public int Def{ get { return def; } set { def = value < 0 ? 0 : value; }}
	}

	public StatusData Status;

}

