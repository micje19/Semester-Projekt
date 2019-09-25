using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorGrid : MonoBehaviour {
    [SerializeField]
    private int rows = 10;
    [SerializeField]
    private int cols = 4;
    [SerializeField]
    private float tileSize = 2f;
    public GameObject myPrefab;


    void Start()
    {
        CreateGrid();
    }


    private void CreateGrid()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                GameObject tile = (GameObject)Instantiate(myPrefab, transform);

                float posX = col * tileSize;
                float posY = row * -tileSize;

                tile.transform.position = new Vector2(posX, posY);
            }
        }

        float gridW = cols * tileSize;
        float gridH = rows * tileSize;
        transform.position = new Vector2(-gridW / 2 + tileSize / 2, gridH / 2 - tileSize / 2);
    }
}
