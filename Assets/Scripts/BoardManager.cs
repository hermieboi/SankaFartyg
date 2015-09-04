using UnityEngine;
using System;
using System.Collections.Generic;

public class BoardManager : MonoBehaviour 
{
	public GameObject cubePrefab;
	public int heightY = 10;
	public int widthX = 10;
	private Transform boardHolder1;
	private Transform boardHolder2;
	
	
	// Use this for initialization
	void Start () 
	{
		PlayerBoard ();
		EnemyBoard();
		
	}
	
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	void PlayerBoard()
	{
		boardHolder1 = new GameObject ("PlayerBoard").transform;
		for (int i = 0; i < heightY; i++) 
		{
			for (int j = 0; j < widthX ; j++)
			{
				GameObject go = Instantiate (cubePrefab, new Vector3 (j,i,0f), Quaternion.identity) as GameObject;
				go.GetComponent<MeshRenderer>().material.color = Color.blue;
				go.name = ("Y: "+ i + ", " + "X: " + j).ToString();
				go.transform.position = new Vector3(go.transform.position.x, go.transform.position.y, go.transform.position.z);
				go.transform.SetParent(boardHolder1);
				
			}
		}
	}

	void EnemyBoard()
	{
		boardHolder2 = new GameObject ("EnemyBoard").transform;
//		boardHolder2.transform.position = new Vector3 (11, 0, 0f)
		for (int i = 0; i < heightY; i++) 
		{
			for (int j = 0; j < widthX ; j++)
			{
				GameObject go = Instantiate (cubePrefab, new Vector3 (j,i,0f), Quaternion.identity) as GameObject;
				go.GetComponent<MeshRenderer>().material.color = Color.blue;
				go.name = ("Y: "+ i + ", " + "X: " + j).ToString();
				go.transform.position = new Vector3(go.transform.position.x + 11, go.transform.position.y, 0f);
				go.transform.SetParent(boardHolder2);
				
			}
		}
	}
	
}

