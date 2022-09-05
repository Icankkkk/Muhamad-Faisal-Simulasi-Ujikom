using System.Collections;
using System.Collections.Generic;
using Faisal.Global;
using Faisal.Message;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

namespace Faisal.Scene.Gameplay
{
    public class GameplayScene : MonoBehaviour
    {
        [SerializeField] private Image _gameOverPanel;
        [SerializeField] private Button _homeButton;
        [SerializeField] private TextMeshProUGUI _winPlayerGold;

        private void Awake()
        {
            _homeButton.onClick.RemoveAllListeners();
            _homeButton.onClick.AddListener(OnClickHomeButton);
        }

        private void OnClickHomeButton()
        {
            Debug.Log("Back to main menu!");
            SceneManager.LoadScene("MainMenu");
        }

        private void GetPlayerWin(object winData)
        {
            WinnerMessage message = (WinnerMessage) winData;
            _winPlayerGold.text = "You have gold " + message.gold.ToString();

            _gameOverPanel.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

}

