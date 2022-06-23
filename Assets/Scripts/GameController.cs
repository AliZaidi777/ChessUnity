using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    bool playerWhite;
    bool gameOver;
    Color originalColor;
    public Board board;
    int Player = 1;
     public int selectedTile = 1;
    int desiredRow, desiredColumn;
    int moveDesiredRow, moveDesiredColumn;
    public void OnBoardTileSelected(int row , int column)
    {
            if (selectedTile == 1)
            {
                desiredRow = row;
                desiredColumn = column;
                if (SelectChessPiece(desiredRow, desiredColumn))
                {
                    selectedTile = 2;
                  originalColor = board.boardTiles[desiredRow, desiredColumn].GetComponent<SpriteRenderer>().color;
                  board.boardTiles[desiredRow, desiredColumn].GetComponent<SpriteRenderer>().color = Color.gray;
                  board.boardTiles[desiredRow, desiredColumn].myPiece.move(board.boardTiles[moveDesiredRow, moveDesiredColumn], board);
                }
                     return;
            }
        else if (selectedTile == 2)
            {

            if (MoveToPosition(row, column) == true || false)
            {
                selectedTile = 1;
                if (board.boardTiles[row, column].myPiece != null)
                {
                    Destroy(board.boardTiles[row, column].myPiece.gameObject);
                }
                board.boardTiles[row, column].myPiece = board.boardTiles[desiredRow, desiredColumn].myPiece;
                board.boardTiles[desiredRow, desiredColumn].myPiece = null;
                board.boardTiles[row, column].myPiece.myTile = board.boardTiles[row, column];
                board.boardTiles[row, column].myPiece.transform.position = board.boardTiles[row, column].transform.position;
                board.boardTiles[desiredRow, desiredColumn].GetComponent<SpriteRenderer>().color = originalColor;
                Player = Player * -1;
                board.boardTiles[desiredRow, desiredColumn].myPiece.MoveD(board.boardTiles[moveDesiredRow, moveDesiredColumn], board);
                return;
            }
            else
            {
                selectedTile = 1;
                board.boardTiles[desiredRow, desiredColumn].GetComponent<SpriteRenderer>().color = originalColor;
                board.boardTiles[desiredRow, desiredColumn].myPiece.MoveD(board.boardTiles[moveDesiredRow, moveDesiredColumn], board);
            }
         }
    }
    private bool SelectChessPiece(int row, int column)
    { 
        bool SelectChessPiece;
        desiredRow = row;
        desiredColumn = column;
        if (Player == 1)
        {
            playerWhite = true;
        }
        else
        {
            playerWhite = false;
        }
        if (board.boardTiles[desiredRow, desiredColumn].myPiece != null && board.boardTiles[desiredRow, desiredColumn].myPiece.isWhite == playerWhite)
        {
            SelectChessPiece = true;
        }
        else
        {
            SelectChessPiece = false;
        }
        return SelectChessPiece;
    }
    private bool MoveToPosition(int row, int column)
    {
        moveDesiredRow = row;
        moveDesiredColumn = column;
        bool moveToPosition = false;
      
        if (board.boardTiles[desiredRow, desiredColumn].myPiece.CanMove(board.boardTiles[moveDesiredRow, moveDesiredColumn], board) == true)
        {
            if (board.boardTiles[moveDesiredRow, moveDesiredColumn].myPiece is King != board.boardTiles[desiredRow, desiredColumn].myPiece.isWhite != playerWhite)
            {
                gameOver = true;
                Debug.Log(" WON : " + playerWhite);
            }
           
            moveToPosition = true;
        }
        return moveToPosition;
    }
}
