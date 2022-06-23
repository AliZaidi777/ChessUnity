using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public BoardTile tilePrefab;
    public float distance = 0f;
    public BoardTile[,] boardTiles = new BoardTile[8, 8];

    public ChessPiece black_queen, black_knight, black_bishop, black_king, black_rook, black_pawn;
    public ChessPiece white_queen, white_knight, white_bishop, white_king, white_rook, white_pawn;
    private void Start()
    {
       //BoardTile temp = Instantiate(tilePrefab, transform);
        for (int x = 0; x < 8; x++)
        {

           
            if (x <= 1 || x >= 6)
            {

                if (x == 0)
                {

                    boardTiles[x, 0] = Instantiate(tilePrefab, transform); boardTiles[x, 0].transform.position = new Vector3(0 * distance, x * distance, 0);
                    boardTiles[x, 0].SetRowColumn(x, 0);
                    ChessPiece temp = Instantiate(white_rook);
                    temp.transform.position = new Vector3(0 * distance, x * distance, 0);
                    boardTiles[x, 0].myPiece = temp;
                    temp.myTile = boardTiles[x, 0];
                    boardTiles[x, 1] = Instantiate(tilePrefab, transform); boardTiles[x, 1].transform.position = new Vector3(1 * distance, x * distance, 0);
                    boardTiles[x, 1].SetRowColumn(x, 1);
                    temp = Instantiate(white_knight);
                    temp.transform.position = new Vector3(1 * distance, x * distance, 0);
                    boardTiles[x, 1].myPiece = temp;
                    temp.myTile = boardTiles[x, 1];
                    boardTiles[x, 2] = Instantiate(tilePrefab, transform); boardTiles[x, 2].transform.position = new Vector3(2 * distance, x * distance, 0);
                    boardTiles[x, 2].SetRowColumn(x, 2);
                    temp = Instantiate(white_bishop);
                    temp.transform.position = new Vector3(2 * distance, x * distance, 0);
                    boardTiles[x, 2].myPiece = temp;
                    temp.myTile = boardTiles[x, 2];
                    boardTiles[x, 3] = Instantiate(tilePrefab, transform); boardTiles[x, 3].transform.position = new Vector3(3 * distance, x * distance, 0);
                    boardTiles[x, 3].SetRowColumn(x, 3);
                    temp = Instantiate(white_queen);
                    temp.transform.position = new Vector3(3 * distance, x * distance, 0);
                    boardTiles[x, 3].myPiece = temp;
                    temp.myTile = boardTiles[x, 3];
                    boardTiles[x, 4] = Instantiate(tilePrefab, transform); boardTiles[x, 4].transform.position = new Vector3(4 * distance, x * distance, 0);
                    boardTiles[x, 4].SetRowColumn(x, 4);
                    temp = Instantiate(white_king);
                    temp.transform.position = new Vector3(4 * distance, x * distance, 0);
                    boardTiles[x, 4].myPiece = temp;
                    temp.myTile = boardTiles[x, 4];
                    boardTiles[x, 5] = Instantiate(tilePrefab, transform); boardTiles[x, 5].transform.position = new Vector3(5 * distance, x * distance, 0);
                    boardTiles[x, 5].SetRowColumn(x, 5);
                    temp = Instantiate(white_bishop);
                    temp.transform.position = new Vector3(5 * distance, x * distance, 0);
                    boardTiles[x, 5].myPiece = temp;
                    temp.myTile = boardTiles[x, 5];
                    boardTiles[x, 6] = Instantiate(tilePrefab, transform); boardTiles[x, 6].transform.position = new Vector3(6 * distance, x * distance, 0);
                    boardTiles[x, 6].SetRowColumn(x, 6);
                    temp = Instantiate(white_knight);
                    temp.transform.position = new Vector3(6 * distance, x * distance, 0);
                    boardTiles[x, 6].myPiece = temp;
                    temp.myTile = boardTiles[x, 6];
                    boardTiles[x, 7] = Instantiate(tilePrefab, transform); boardTiles[x, 7].transform.position = new Vector3(7 * distance, x * distance, 0);
                    boardTiles[x, 7].SetRowColumn(x, 7);
                    temp = Instantiate(white_rook);
                    temp.transform.position = new Vector3(7 * distance, x * distance, 0);
                    boardTiles[x, 7].myPiece = temp;
                    temp.myTile = boardTiles[x, 7];
                }
                if (x == 1)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        boardTiles[x, y] = Instantiate(tilePrefab, transform); boardTiles[x, y].transform.position = new Vector3(y * distance, x * distance, 0);
                        boardTiles[x, y].SetRowColumn(x, y);
                        ChessPiece temp = Instantiate(white_pawn);
                        temp.transform.position = new Vector3(y * distance, x * distance, 0);
                        boardTiles[x, y].myPiece = temp;
                        temp.myTile = boardTiles[x, y];
                        

                    }
                }
                if (x == 7)
                {
                    boardTiles[x, 0] = Instantiate(tilePrefab, transform); boardTiles[x, 0].transform.position = new Vector3(0 * distance, x * distance, 0);
                    boardTiles[x, 0].SetRowColumn(x, 0);
                    ChessPiece temp = Instantiate(black_rook);
                    temp.transform.position = new Vector3(0 * distance, x * distance, 0);
                    boardTiles[x, 0].myPiece = temp;
                    temp.myTile = boardTiles[x, 0];
                    boardTiles[x, 1] = Instantiate(tilePrefab, transform); boardTiles[x, 1].transform.position = new Vector3(1 * distance, x * distance, 0);
                    boardTiles[x, 1].SetRowColumn(x, 1);
                    temp = Instantiate(black_knight);
                    temp.transform.position = new Vector3(1 * distance, x * distance, 0);
                    boardTiles[x, 1].myPiece = temp;
                    temp.myTile = boardTiles[x, 1];
                    boardTiles[x, 2] = Instantiate(tilePrefab, transform); boardTiles[x, 2].transform.position = new Vector3(2 * distance, x * distance, 0);
                    boardTiles[x, 2].SetRowColumn(x, 2);
                    temp = Instantiate(black_bishop);
                    temp.transform.position = new Vector3(2 * distance, x * distance, 0);
                    boardTiles[x, 2].myPiece = temp;
                    temp.myTile = boardTiles[x, 2];
                    boardTiles[x, 3] = Instantiate(tilePrefab, transform); boardTiles[x, 3].transform.position = new Vector3(3 * distance, x * distance, 0);
                    boardTiles[x, 3].SetRowColumn(x, 3);
                    temp = Instantiate(black_queen);
                    temp.transform.position = new Vector3(3 * distance, x * distance, 0);
                    boardTiles[x, 3].myPiece = temp;
                    temp.myTile = boardTiles[x, 3];
                    boardTiles[x, 4] = Instantiate(tilePrefab, transform); boardTiles[x, 4].transform.position = new Vector3(4 * distance, x * distance, 0);
                    boardTiles[x, 4].SetRowColumn(x, 4);
                    temp = Instantiate(black_king);
                    temp.transform.position = new Vector3(4 * distance, x * distance, 0);
                    boardTiles[x, 4].myPiece = temp;
                    temp.myTile = boardTiles[x, 4];
                    boardTiles[x, 5] = Instantiate(tilePrefab, transform); boardTiles[x, 5].transform.position = new Vector3(5 * distance, x * distance, 0);
                    boardTiles[x, 5].SetRowColumn(x, 5);
                    temp = Instantiate(black_knight);
                    temp.transform.position = new Vector3(5 * distance, x * distance, 0);
                    boardTiles[x, 5].myPiece = temp;
                    temp.myTile = boardTiles[x, 5];
                    boardTiles[x, 6] = Instantiate(tilePrefab, transform); boardTiles[x, 6].transform.position = new Vector3(6 * distance, x * distance, 0);
                    boardTiles[x, 6].SetRowColumn(x, 6);
                    temp = Instantiate(black_bishop);
                    temp.transform.position = new Vector3(6 * distance, x * distance, 0);
                    boardTiles[x, 6].myPiece = temp;
                    temp.myTile = boardTiles[x, 6];
                    boardTiles[x, 7] = Instantiate(tilePrefab, transform); boardTiles[x, 7].transform.position = new Vector3(7 * distance, x * distance, 0);
                    boardTiles[x, 7].SetRowColumn(x, 7);
                    temp = Instantiate(black_rook);
                    temp.transform.position = new Vector3(7 * distance, x * distance, 0);
                    boardTiles[x, 7].myPiece = temp;
                    temp.myTile = boardTiles[x, 7];
                }
                if (x == 6)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        boardTiles[x, y] = Instantiate(tilePrefab, transform); boardTiles[x, y].transform.position = new Vector3(y * distance, x * distance, 0);
                        boardTiles[x, y].SetRowColumn(x, y);
                        ChessPiece temp = Instantiate(black_pawn);
                        temp.transform.position = new Vector3(y * distance, x * distance, 0);
                        boardTiles[x, y].myPiece = temp;
                        temp.myTile = boardTiles[x, y];
                    }
                }
            }
            else
            {
                for (int y = 0; y < 8; y++)
                {
                    boardTiles[x, y] = Instantiate(tilePrefab, transform); boardTiles[x, y].transform.position = new Vector3(y * distance, x * distance, 0);
                    boardTiles[x, y].SetRowColumn(x, y);   
                }
            }
            
        }

    }


}
