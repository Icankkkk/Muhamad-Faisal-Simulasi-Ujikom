using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Faisal.Scene.Gameplay
{
    public class TileObject : MonoBehaviour
    {
        private int _indexY;
        private int _indexX;
        private int _indexType;
        

        [SerializeField] private Sprite[] _sprites;

        public int IndexX => _indexX;
        public int IndexY => _indexY;
        public int IndexType => _indexType;

        private void Awake()
        {
            _sprites = Resources.LoadAll<Sprite>("Images/");
        }

        public void SetupAllIndex(int x, int y, int type)
        {
            _indexX = x;
            _indexY = y;
            _indexType = type;
        }

        public void SetImageTiles(int type)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = _sprites[type];
        }
    }

}
