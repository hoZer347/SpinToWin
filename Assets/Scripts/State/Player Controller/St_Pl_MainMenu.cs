using System;
using UnityEngine;


namespace AdequateGames
{
	[Serializable]
	public class St_Pl_MainMenu : State<PlayerController>
	{
		public override void OnEnter(State lastState)
		{
			base.OnEnter(lastState);

			Focus.cameraController.SetState<St_Cm_MainMenuToGameTransition>();

			Push<St_Pl_MainMenuStartGameSelected>();
			Push<St_Pl_WaitForSpinput>();
		}
	};
};
