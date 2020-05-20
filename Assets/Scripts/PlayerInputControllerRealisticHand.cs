﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputControllerRealisticHand : MonoBehaviour
{
	[Header("Input")]
	public Animator handAnimator;
	public HingeJoint handTopJoint;
	public HingeJoint wristJoint;
	public float rotationSpeed;
	public float maxRotation = 50;
	private Vector2 leftSrickInput = new Vector2();

	[Header("Hand Stabilization & Fall Down")]
	public bool improvedHandStabilization = false;
	public bool handsCanFallDown = false;
	public Vector3 restartForce = Vector3.up * 50f;
	public Rigidbody handRigid;
	public float handSpring_connectedAnchorHeight = 4.1f;

	// Start is called before the first frame update
	void Start()
	{



	}

	// Update is called once per frame
	void Update()
	{
		//Debug.Log(leftSrickInput);

		//// only if the hand doesn't use the new stabilization (cause it wouldn't have the needed components)
		//if (!improvedHandStabilization && leftSrickInput != Vector2.zero)
		//{

		//	if (leftSrickInput.x != 0f)
		//	{
		//		BendVertically(leftSrickInput.x * -rotationSpeed);
		//	}
		//	else if (leftSrickInput.y != 0f)
		//	{
		//		BendHorizontally(leftSrickInput.y * rotationSpeed);
		//	}

		//}
	}

	public void BendHorizontally(float bendValue)
	{
		//JointSpring spring = wristJoint.spring;
		//spring.targetPosition = Mathf.Clamp(spring.targetPosition + bendValue, -maxRotation, maxRotation);
		//handTopJoint.spring = spring;
	}

	public void BendVertically(float bendValue)
	{

		JointSpring spring = handTopJoint.spring;
		spring.targetPosition = Mathf.Clamp(spring.targetPosition + bendValue, -maxRotation, maxRotation);
		handTopJoint.spring = spring;

	}

	// --- ACTION FUNCTIONS ---//

	public void OnIndexFingerUP()
	{
		Debug.Log("on INDEX UP called");
		handAnimator.Play("Index UP", 4);
	}

	public void OnIndexFingerDOWN()
	{
		Debug.Log("on INDEX DOWN called");
		handAnimator.Play("Index DOWN", 4);
	}

	public void OnIndexFingerCurledIN()
	{
		handAnimator.Play("Index IN", 5);
	}

	public void OnIndexFingerCurledOUT()
	{
		handAnimator.Play("Index OUT", 5);
	}

	public void OnMiddleFingerUP()
	{
		handAnimator.Play("Middle UP", 6);
	}

	public void OnMiddleFingerDOWN()
	{
		handAnimator.Play("Middle DOWN", 6);
	}

	public void OnMiddleFingerCurledIN()
	{
		handAnimator.Play("Middle IN", 7);
	}

	public void OnMiddleFingerCurledOUT()
	{
		handAnimator.Play("Middle OUT", 7);
	}

	public void OnStandUp()
	{
		// (only if standUp is activated)
		if (handsCanFallDown)
		{
			//StartCoroutine(StandUp());
		}
	}

	public void OnBodyBending(InputValue value)
	{
		leftSrickInput = value.Get<Vector2>();


	}
}
