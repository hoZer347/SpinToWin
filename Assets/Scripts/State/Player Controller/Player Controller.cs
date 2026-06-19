using UnityEngine;


namespace AdequateGames
{
	public class PlayerController : StateMachine<PlayerController>
	{
		[SerializeField] public CameraController cameraController;
	};
};
