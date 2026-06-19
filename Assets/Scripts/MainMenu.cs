using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;


namespace AdequateGames
{
	public class MainMenu : MonoBehaviour
	{
		[SerializeField] Button btStartGame;
		[SerializeField] Button btExitGame;

		// Nice to have options
		//[SerializeField] Button btOptions;

		[SerializeField] Button btRyan;
		[SerializeField] VideoClip ryanVideoClip;

		[SerializeField] PlayerController playerController;
		[SerializeField] CameraController cameraController;

		private void Start()
		{
			btStartGame.onClick.AddListener(() =>
			{
				cameraController.SetState<St_Cm_MainMenuToGameTransition>();
				playerController.SetState<St_Pl_MainMenuStartGameSelected>();
			});
			btExitGame.onClick.AddListener(() => Application.Quit());
			//btOptions.onClick.AddListener(() => ???); For now, nice to have
			btRyan.onClick.AddListener(() =>
			{
				// Probably do something more sophisticated here later.

				var videoPlayer = gameObject.AddComponent<VideoPlayer>();
				videoPlayer.clip = ryanVideoClip;
				videoPlayer.Play();
			});
		}
	};
};
