﻿using UnityEngine;

public class Settings : MonoBehaviour
{

	public static Settings instance;
	[Header("Player References")]
	public HandReferences LEFT;
	public HandReferences RIGHT;

	[Header("Config")]
	public bool useFK;
	public bool useTriggersCurl = true;
	public bool amplifyJump;
	public bool compassBending;
	public bool lookAtActive;
	public enum FallDirection { X, XandZ}
	public FallDirection fallDirection;
	public enum FallMode { neverFall, getUpAutomatically, dontGetUp, spring_backFoot, spring_feet, bend}
	public FallMode fallMode;
	public enum ColisionAmplificationMode { velocityChange, velocityAddition, shockwave};
	public float springForce;
	public ColisionAmplificationMode colisionAmplificationMode;
	public enum TransformType { global, local };
	public TransformType poseSpace = TransformType.global;


	[Header("Physics Correction")]
	public float hipRotationSpeed;
	public float maxHipRotation = 50;
	public float maxHipPushForce = 10;
	public float jumpForce = 10;

	[Header("Detect fast stick releases")]
	public float stickReleaseTimeWindow = 0.1f;

    [Header("If spring fall mode")]
    public float configJoint_Y_Offset = 2f;
    public float anchorInputStrength = 0.1f;
    public float anchorBreakDistanceLimit = 0.8f;
    public float anchorBreakAngleLimit = 45f;

	private void Awake()
	{
		if (Settings.instance == null)
		{
			Settings.instance = this;
		}
	}
	// Start is called before the first frame update
	void Start()
    {
    
		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
