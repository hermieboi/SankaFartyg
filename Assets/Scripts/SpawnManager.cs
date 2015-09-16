using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour 
{
	public GameObject SubmarinePrefab;
	public GameObject DestroyerPrefab;
	public GameObject CrusierPrefab;
	public GameObject BattleshipPrefab;
	public int Sub_total;
	public int Destroyer_total;
	public int Crusier_total;
	public int Battleship_total;

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
		Sub_total = 4;
		GameObject SubmarineClone = Instantiate (SubmarinePrefab, new Vector3 (0f,0f,0f), Quaternion.identity) as GameObject;
		Sub_total --;
		Debug.Log("You may spawn " + Sub_total + " more Submarines.");

	}

	public void SpawnDestroyer()
	{
		Destroyer_total = 3;
		GameObject DestroyerClone = Instantiate (DestroyerPrefab, new Vector3 (0f,0f,0f), Quaternion.identity) as GameObject;
		Destroyer_total --;
		Debug.Log("You may spawn " + Destroyer_total + " more Destroyers.");
	}

	public void SpawnCrusier()
	{
		Crusier_total = 2;
		GameObject CrusierClone = Instantiate (CrusierPrefab, new Vector3 (0f,0f,0f), Quaternion.identity) as GameObject;
		Crusier_total --;
		Debug.Log("You may spawn " + Crusier_total + " more Crusiers.");
	}

	public void SpawnBattleship()
	{
		Battleship_total = 1;
		GameObject BattleshipClone = Instantiate (BattleshipPrefab, new Vector3 (0f,0f,0f), Quaternion.identity) as GameObject;
		Battleship_total --;
		Debug.Log("You may spawn " + Battleship_total + " more Battleships.");
	}

}
