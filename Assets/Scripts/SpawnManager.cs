using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour 
{
	public GameObject SubmarinePrefab;
	public GameObject DestroyerPrefab;
	public GameObject CrusierPrefab;
	public GameObject BattleshipPrefab;

	public int Sub_totalNumber;
	public int Destroyer_totalNumber;
	public int Crusier_totalNumber;
	public int Battleship_totalNumber;

	private int Submarine_HP;
	private int Destroyer_HP;
	private int Crusier_HP;
	private int Battleship_HP;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	public void SpawnSubmarine()
	{
		Sub_totalNumber = 4;
		Submarine_HP = 1;
		GameObject SubmarineClone = Instantiate (SubmarinePrefab, new Vector3 (0f,0f,0f), Quaternion.identity) as GameObject;
		Sub_totalNumber --;
		Debug.Log("You may spawn " + Sub_totalNumber + " more Submarines.");

	}

	public void SpawnDestroyer()
	{
		Destroyer_totalNumber = 3;
		Destroyer_HP = 2;
		GameObject DestroyerClone = Instantiate (DestroyerPrefab, new Vector3 (0f,0f,0f), Quaternion.identity) as GameObject;
		Destroyer_totalNumber --;
		Debug.Log("You may spawn " + Destroyer_totalNumber + " more Destroyers.");
	}

	public void SpawnCrusier()
	{
		Crusier_totalNumber = 2;
		Crusier_HP = 3;
		GameObject CrusierClone = Instantiate (CrusierPrefab, new Vector3 (0f,0f,0f), Quaternion.identity) as GameObject;
		Crusier_totalNumber --;
		Debug.Log("You may spawn " + Crusier_totalNumber + " more Crusiers.");
	}

	public void SpawnBattleship()
	{
		Battleship_totalNumber = 1;
		Battleship_HP = 4;
		GameObject BattleshipClone = Instantiate (BattleshipPrefab, new Vector3 (0f,0f,0f), Quaternion.identity) as GameObject;
		Battleship_totalNumber --;
		Debug.Log("You may spawn " + Battleship_totalNumber + " more Battleships.");
	}

}
