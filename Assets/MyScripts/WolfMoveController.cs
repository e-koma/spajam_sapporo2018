using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfMoveController : MonoBehaviour {

	public float m_Speed = 3f;
	public float m_TurnSpeed = 60f;
	public Rigidbody camera_Rigidbody;

	private Rigidbody wolf_Rigidbody;

	private void Awake()
	{
		wolf_Rigidbody = GetComponent<Rigidbody>();
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	private void FixedUpdate()
	{
		Move ();
		Turn ();
		FaceUpDown ();
	}

	private void Move()
	{
		Vector3 movement = transform.forward * Input.GetAxis ("Vertical") * m_Speed * Time.deltaTime;

		wolf_Rigidbody.MovePosition (wolf_Rigidbody.position + movement);
		camera_Rigidbody.MovePosition (camera_Rigidbody.position + movement);
	}


	private void Turn()
	{
		float turn = Input.GetAxis ("Horizontal") * m_TurnSpeed * Time.deltaTime;
		Quaternion turnRotation = Quaternion.Euler (0f, turn, 0f);

		wolf_Rigidbody.MoveRotation (wolf_Rigidbody.rotation * turnRotation);
		camera_Rigidbody.MoveRotation (camera_Rigidbody.rotation * turnRotation);
	}

	private void FaceUpDown()
	{
		float faceup = Input.GetAxis ("FaceUp") * m_TurnSpeed * Time.deltaTime;
		float facedown = Input.GetAxis ("FaceDown") * m_TurnSpeed * Time.deltaTime;
		Quaternion turnRotation = Quaternion.Euler ( facedown - faceup, 0f, 0f);

		camera_Rigidbody.MoveRotation (camera_Rigidbody.rotation * turnRotation);
	}
}
