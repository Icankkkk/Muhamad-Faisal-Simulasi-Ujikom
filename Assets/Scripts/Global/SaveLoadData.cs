using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Faisal.Global
{
    public class SaveLoadData : MonoBehaviour 
    {
        public static SaveLoadData saveLoadInstance;
        private const string _prefsKey = "SaveData";

        [SerializeField] private int _currentTheme;
        [SerializeField] private bool[] _isBoughtTheme;

        public int CurrentTheme() { return _currentTheme; }
        public bool[] IsBoughtTheme() { return _isBoughtTheme; }

        private void Awake()
        {
            if (saveLoadInstance == null)
            {
                saveLoadInstance = this;
                DontDestroyOnLoad(gameObject);
            } else
            {
                Destroy(gameObject);
            }
            Load();
        }

        public void Load()
        {
            if(PlayerPrefs.HasKey(_prefsKey))
            {
                string json = PlayerPrefs.GetString(_prefsKey);
                JsonUtility.FromJsonOverwrite(json, this);
            } 
            else
            {
                Save();
            }
        }

        public void Save()
        {
            string json = JsonUtility.ToJson(this);
            PlayerPrefs.SetString(_prefsKey, json);
        }

        public void ChangeTheme(int _themes)
        {
            if (_isBoughtTheme[_themes])
            {
                _currentTheme = _themes;
            }
            else
            {
                int _cost = (_themes - 1) * 100;
            }
            Save();
        }
    }
}

