using System;
using UnityEngine;
using UnityEngine.UI;


namespace AdequateGames
{
	[Serializable]
	public class St_Pl_MainMenuStartGameSelected : State<PlayerController>
	{
		// Probably gonna include a delay for each button to slide out of the screen
		// For now, just gonna disable them

		// Also, a camera pan to the player

		public override void OnEnter(State lastState)
		{
			base.OnEnter(lastState);
		}

		public override void OnUpdate()
		{
			base.OnUpdate();

			Proceed();
		}

		public override void OnExit(State nextState)
		{
			base.OnExit(nextState);

			MainMenu mainMenu = GameObject.FindAnyObjectByType<MainMenu>();

			foreach (Button button in mainMenu.GetComponentsInChildren<Button>())
				button.gameObject.SetActive(false);
		}
	};
};
