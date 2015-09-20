using UnityEngine;
using System.Collections;

public class FSM : MonoBehaviour 
{
	public enum State 
	{
		Splashscreen,
		PlayerSetup,
		EnemySetup,
		Player_Shoot,
		Enemy_Shoot,
		Win,
		Lose,
		Exit
	}

	public enum Combat
	{
		FindEnemy,
		AttackEnemy,
		EnemyDead
	}

	private State _state;


	IEnumerator Start () 
	{
		_state = State.Splashscreen;



		switch(_state)
		{
		case State.Splashscreen:
			InitMe();
			break;

		case State.PlayerSetup:
			SetMeUp ();
			break;
		
		case State.EnemySetup:
			AI_Setup ();
			break;
		
		case State.Player_Shoot:
			Shooting ();
			break;
		
		case State.Enemy_Shoot:
			
			break;


		}
		yield return 0;
	}


	private void InitMe()
	{
		Debug.Log ("This is the Splashscreen state.");
		_state = State.PlayerSetup;
	}


	private void SetMeUp()
	{
		Debug.Log ("You have now entered the PlayerSetup state.");
		_state = State.EnemySetup;
	}

	private void AI_Setup()
	{
		Debug.Log ("");
		_state = State.Player_Shoot;
	}

	private void Shooting()
	{

	}

//	private void InCombat()
//	{
//		Debug.Log ("In Combat");
//		switch (combat)
//		{
//		case FSM.Combat.FindEnemy:
//				break;
//		case FSM.Combat.AttackEnemy:
//				break;
//		case FSM.Combat.EnemyDead:
//				break;
//
//		}
//	}
//
//	private void Looting()
//	{
//		Debug.Log ("Looting");
//	}
//
//	private void FindEnemy()
//	{
//		Debug.Log ("Finding Enemy");
//		combat = FSM.Combat.AttackEnemy;
//	}
//
//	private void AttackEnemy()
//	{
//		Debug.Log ("Attacking Enemy");
//		combat = FSM.Combat.EnemyDead;
//	}
//
//	private void EnemyDead()
//	{
//		Debug.Log ("Enemy Dead");
//		_state = State.Idle;
//	}


}
