using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Faisal.Scene.Gameplay
{
    public class GridSystem : MonoBehaviour
    {
        public int rows { get; private set; } = 5;
        public int colums { get; private set; } = 6;
        public Tiles[,] gridList { get; private set; }

        private float _gridSpace = 1f;
        private Vector2 _gridOrigin = Vector2.zero;

        [SerializeField] private Tiles _gridPrefab;
        [SerializeField] private int _currentIndexTileX;
        [SerializeField] private int _currentIndexTileY;

        private void Awake()
        {
            CreateGrid();
        }

        public void CreateGrid()
        {
            gridList = new Tiles[rows, colums];
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < colums; y++)
                {
                    Vector2 spawnPosition = new Vector2(x * _gridSpace, y * _gridSpace) + _gridOrigin;
                    Tiles gridObject = Instantiate(_gridPrefab, spawnPosition, Quaternion.identity, transform);

                    gridObject.gameObject.name = "Tile( " + ("X:" + x + " ,Y:" + y + " )");
                    gridObject.SetIndexTiles(x, y);
                }
            }
        }
    }
}
