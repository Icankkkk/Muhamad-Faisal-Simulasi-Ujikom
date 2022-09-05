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

        private void SetAllButtonListener()
        {
            _PlayButton.onClick.RemoveAllListeners();
            _ThemeButton.onClick.RemoveAllListeners();
            _ExitButton.onClick.RemoveAllListeners();

            _PlayButton.onClick.AddListener(OnClickPlayButton);
            _ThemeButton.onClick.AddListener(OnClickThemeButton);
            _ExitButton.onClick.AddListener(OnClickQuitButton);
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

