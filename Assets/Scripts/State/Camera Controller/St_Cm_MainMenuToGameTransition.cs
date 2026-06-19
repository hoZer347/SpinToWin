using System;
using UnityEngine;


namespace AdequateGames
{
	[Serializable]
	public class St_Cm_MainMenuToGameTransition : State<CameraController>
	{
		Vector3 goalPosition;
		Vector3 goalDirection;

		public override void OnEnter(State lastState)
		{
			base.OnEnter(lastState);


		}

		public override void OnPhysics()
		{
			base.OnPhysics();

			goalPosition = Focus.playerController.transform.position + Focus.goalOffset;
			goalDirection = (Focus.playerController.transform.position - Focus.transform.position).normalized;

			Focus.transform.position = Vector3.Lerp(
				Focus.transform.position,
				goalPosition,
				Focus.transitionSpeed * Time.deltaTime);
			
			Focus.transform.forward = Vector3.Lerp(
				Focus.transform.forward,
				goalDirection,
				Focus.transitionSpeed * Time.deltaTime);
		}
	};
};
