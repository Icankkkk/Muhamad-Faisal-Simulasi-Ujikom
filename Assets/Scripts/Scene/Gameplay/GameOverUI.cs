using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Faisal.Scene.Gameplay
{

    public class GameOverUI : MonoBehaviour
    {
        [SerializeField] private Button _homeButton;

        private void Awake() {
            _homeButton.onClick.RemoveAllListeners();
            _homeButton.onClick.AddListener(OnClikHomeButton);
        }

        public void OnClikHomeButton()
        {
            Debug.Log("Back to main menu!");
            SceneManager.LoadScene("MainMenu");
        }
    }

}
