using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Faisal.Scene.Home
{
    public class HomeScene : MonoBehaviour
    {
        [SerializeField] private Button _PlayButton;
        [SerializeField] private Button _ThemeButton;
        [SerializeField] private Button _ExitButton;

        private void Awake()
        {
            SetAllButtonListener();
        }

        private void SetPlayButtonListener(Button button)
        {
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(OnClickPlayButton);
        }

        private void SetThemeButtonListener(Button button)
        {
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(OnClickThemeButton);
        }

        private void SetExitButtonListener(Button button)
        {
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(OnClickQuitButton);
        }

        private void SetAllButtonListener()
        {
            SetPlayButtonListener(_PlayButton);
            SetThemeButtonListener(_ThemeButton);
            SetExitButtonListener(_ExitButton);
        }

        public void OnClickPlayButton()
        {
            Debug.Log("load to gameplay!");
            SceneManager.LoadScene("Gameplay");
        }

        public void OnClickThemeButton()
        {
            Debug.Log("load to Themes!");
            SceneManager.LoadScene("Themes");
        }

        public void OnClickQuitButton()
        {
            Debug.Log("Exit Game!");
            Application.Quit();
        }
    }
}

