using UnityEngine;
using System.Collections;

public class CharacterMovementScript : MonoBehaviour {


	Animator characterAnimator;
	// Use this for initialization
	void Start () {
	
		characterAnimator = gameObject.GetComponent<Animator>();



	}
	
	// Update is called once per frame
	void Update () {
	
		playerInputMovementAnimation();

	}


	void playerInputMovementAnimation()
	{
		if(Input.GetKey(KeyCode.D))
		{
			characterAnimator.SetBool("Running",true);

		}
		else
		{
			characterAnimator.SetBool("Running",false);
		}

		if(Input.GetKeyDown(KeyCode.Space))
		{
			characterAnimator.SetBool("Jumping",true);
			Invoke("stopJump",2f);
		}

	}

	void stopJump()
	{
		characterAnimator.SetBool ("Jumping",false);

	}
}
