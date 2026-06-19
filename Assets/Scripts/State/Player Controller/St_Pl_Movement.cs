using System;
using UnityEngine;
using UnityEngine.InputSystem;


namespace AdequateGames
{
	[Serializable]
	public class St_Pl_Movement : State<PlayerController>
	{
		override public void OnEnter(State lastState)
		{
			base.OnEnter(lastState);
		}

		public override void OnPhysics()
		{
			base.OnPhysics();

			if (Keyboard.current.wKey.isPressed)
				Focus.zSpeed.Accelerate();

			if (Keyboard.current.aKey.isPressed)
				Focus.xSpeed.Decelerate();

			if (Keyboard.current.sKey.isPressed)
				Focus.zSpeed.Decelerate();

			if (Keyboard.current.dKey.isPressed)
				Focus.xSpeed.Accelerate();

			if (!Keyboard.current.wKey.isPressed && !Keyboard.current.sKey.isPressed)
				Focus.zSpeed.ApplyFriction();

			if (!Keyboard.current.aKey.isPressed && !Keyboard.current.dKey.isPressed)
				Focus.xSpeed.ApplyFriction();

			Focus.transform.position += Focus.zSpeed.SpeedVector * Time.deltaTime;
			Focus.transform.position += Focus.xSpeed.SpeedVector * Time.deltaTime;
		}
	};
};
