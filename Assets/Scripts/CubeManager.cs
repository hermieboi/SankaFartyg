using UnityEngine;
using System.Collections;

public class CubeManager : MonoBehaviour 
{

	private Color baseColor;

	// Use this for initialization
	void Start () 
	{
		gameObject.GetComponent<MeshRenderer>().material.color = baseColor;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnMouseOver ()
	{
		gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
	}

	void OnMouseExit ()
	{
		gameObject.GetComponent<MeshRenderer>().material.color = baseColor;
	}
}
