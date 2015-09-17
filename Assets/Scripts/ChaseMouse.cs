using UnityEngine;
using System.Collections;

public class ChaseMouse : MonoBehaviour 
{
	
	private Vector3 mousePoz;
	private float x_Cords;
	private float y_Cords;
	private SpawnManager _spawnManager;
	public bool Chasing = true;

	
	

	void Awake()
	{
		_spawnManager = GetComponent<SpawnManager>();
	}
	// Use this for initialization
	void Start () 
	{

		mousePoz = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{

		ChasingMouse();

		
	}

	void OnMouseDown()
	{
		if (!Chasing)
		{
			gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, 15);
		}
	}

	void ChasingMouse()
	{
		mousePoz = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 15);
		mousePoz = Camera.main.ScreenToWorldPoint (mousePoz);
		transform.position = mousePoz;
		
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Destroy(gameObject);
			Debug.Log ("You just destroyed: " + gameObject.name + ".");
			Debug.Log ("Placement canceled. You have 1 more " + gameObject.name + " to spawn.");
		}
	}
}