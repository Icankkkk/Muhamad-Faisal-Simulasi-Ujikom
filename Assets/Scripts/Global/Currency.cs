using System.Collections;
using System.Collections.Generic;
using Faisal.Message;
using UnityEngine;

namespace Faisal.Global
{
    public class Currency : MonoBehaviour
    {
        [SerializeField] int _playerGold = 500;

        private void OnEnable()
        {
            EventManager.StartListening("OnGameOverMessage", OnGameOver);
        }
        private void OnDisable()
        {
            EventManager.StopListening("OnGameOverMessage", OnGameOver);
        }

        public void OnGameOver()
        {   
            int gold = _playerGold;
            EventManager.TriggerEvent("WinnerMessage", new WinnerMessage(gold));
        }
    }
}


