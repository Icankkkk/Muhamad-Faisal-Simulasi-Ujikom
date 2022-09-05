using UnityEngine;
using TMPro;
using Faisal.Global;

namespace Faisal.Scene.Gameplay
{
    public class TimerManager : MonoBehaviour
    {
        [SerializeField] private float _timeLeft;
        [SerializeField] private TextMeshProUGUI _timeText;
        private bool _isPlayGame;

        private void Update()
        {
            GameStarted();
        }

        public void UpdateTimer(float timeUpdate)
        {
            timeUpdate += 1;
            float minute = Mathf.FloorToInt(timeUpdate / 60);
            float second = Mathf.FloorToInt(timeUpdate % 60);

            _timeText.text = string.Format("{0 : 00} : {1 : 00}", minute, second);
        }

        public void GameStarted()
        {
            _isPlayGame = true; // temporary code
            if (_isPlayGame)
            {
                if (_timeLeft > 0)
                {
                    _timeLeft -= Time.deltaTime;
                    UpdateTimer(_timeLeft);
                }
                else
                {
                    _timeLeft = 0;
                    _isPlayGame = false;
                    Debug.Log("Game Over");
                   // EventManager.TriggerEvent("TimeOverMessage");
                }
            }
        }

        public void IsPlayGame() => _isPlayGame = true;
    }
}


