using UnityEngine;


namespace AdequateGames
{
	public class CameraController : StateMachine<CameraController>
	{
		// Tracking
		[SerializeField] public Vector3 goalOffset;
		[SerializeField] public float transitionSpeed;
		[SerializeField] public PlayerController playerController;

	};
};
