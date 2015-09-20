using UnityEngine;
using System.Collections;

public class ChaseMouse : MonoBehaviour 
{
	
	private Vector3 mousePoz;
	private float x_Cords;
	private float y_Cords;
	public bool Chasing = true;

	
	

	void Awake()
	{
	

	}

	void Start () 
	{

		mousePoz = transform.position;
	}
	

	void Update () 
	{

		ChasingMouse();

		
	}




	void ChasingMouse()
	{

		if (Chasing)
		{
			mousePoz = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 15);
			mousePoz = Camera.main.ScreenToWorldPoint (mousePoz);
			transform.position = mousePoz;
		}
		
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Destroy(gameObject);
			Debug.Log ("You just destroyed: " + gameObject.name + ".");
			Debug.Log ("Placement canceled. You have 1 more " + gameObject.name + " to spawn.");
		}

		if(Chasing && Input.GetKeyDown(KeyCode.Mouse0))
		{
			gameObject.transform.position = new Vector3 (transform.localPosition.x, transform.localPosition.y, 0f);
			Chasing = false;
			Debug.Log ("You just placed a " + gameObject.name + " on the player board.");
		}


	}
}