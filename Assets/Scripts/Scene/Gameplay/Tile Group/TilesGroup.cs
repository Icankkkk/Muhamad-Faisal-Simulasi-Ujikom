using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Faisal.Scene.Gameplay
{

    public class TilesGroup : MonoBehaviour
    {
        public int row { get; private set; } = 5;
        public int column { get; private set; } = 6;
        private float _gridSpace = 1f;

        [SerializeField] private TilesGroup gridPrefab;
        public Vector3 gridOrigin = Vector3.zero;

        public TilesGroup[,] gridList { get; private set; }
        [SerializeField] private int _currentIndexTileX;
        [SerializeField] private int _currentIndexTileZ;

        private void Awake()
        {
            SetupAllTiles();
        }

        public void SetupAllTiles()
        {
            gridList = new TilesGroup[row, column];
            for (int x = 0; x < row; x++)
            {
                for (int z = 0; z < column; z++)
                {
                    Vector3 spawnPosition = new Vector3(x * _gridSpace, 0, z * _gridSpace) + gridOrigin;
                    TilesGroup gridObjects = Instantiate(gridPrefab, spawnPosition, Quaternion.identity, transform);

                    gridList[x, z] = gridObjects;

                    gridObjects.gameObject.name = "Tile( " + ("X:" + x + " ,Z:" + z + " )");
                }
            }
        }

    }

}
