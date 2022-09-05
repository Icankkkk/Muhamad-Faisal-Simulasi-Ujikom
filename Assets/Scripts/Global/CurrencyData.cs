using System.Collections;
using UnityEngine;

namespace Faisal.Global
{
    public class CurrencyData : MonoBehaviour
    {
        private const string _prefsKey = "Currency";

        [SerializeField] private int _goldAmount;
        [SerializeField] private int _addGold = 100;

        public int GoldAmount() { return _goldAmount; }

        public static CurrencyData currencyInstance;

        private void Awake()
        {
            if (currencyInstance == null)
            {
                currencyInstance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
            Load();
        }

        private void Load()
        {
            if (PlayerPrefs.HasKey(_prefsKey))
            {
                string json = PlayerPrefs.GetString(_prefsKey);
                JsonUtility.FromJsonOverwrite(json, this);
            }
            else
            {
                Save();
            }
        }

        private void Save()
        {
            string json = JsonUtility.ToJson(this);
            PlayerPrefs.SetString(_prefsKey, json);
        }

        public void AddingPlayerGold()
        {
            _goldAmount += _addGold;
            Save();
        }

        public void SpendPlayerGold(int price)
        {
            _goldAmount -= price;
            Save();
        }
    }
}