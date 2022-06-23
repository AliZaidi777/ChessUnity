using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : ChessPiece
{
    Color originalColor;
    public override void move(BoardTile boardTile, Board board)
    {
        originalColor = board.boardTiles[myTile.GetRow(), myTile.GetColumn()].GetComponent<SpriteRenderer>().color;
        int x;
        if (isWhite) { x = -1; }
        else { x = 1; }
        if (board.boardTiles[myTile.GetRow() - x, myTile.GetColumn()].myPiece == null)
        {
            board.boardTiles[myTile.GetRow() - x, myTile.GetColumn()].GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (board.boardTiles[myTile.GetRow() - x, myTile.GetColumn() + 1].myPiece != null)
        {
            board.boardTiles[myTile.GetRow() - x, myTile.GetColumn() + 1].GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (board.boardTiles[myTile.GetRow() - x, myTile.GetColumn() - 1].myPiece != null)
        {
            board.boardTiles[myTile.GetRow() - x, myTile.GetColumn() - 1].GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
    public override void MoveD(BoardTile boardTile, Board board)
    {
        int x;
        if (isWhite) { x = -1; }
        else { x = 1; }
        if (board.boardTiles[myTile.GetRow() - x, myTile.GetColumn()].myPiece == null)
        {
            board.boardTiles[myTile.GetRow() - x, myTile.GetColumn()].GetComponent<SpriteRenderer>().color = originalColor;
        }
        if (board.boardTiles[myTile.GetRow() - x, myTile.GetColumn() + 1].myPiece != null)
        {
            board.boardTiles[myTile.GetRow() - x, myTile.GetColumn() + 1].GetComponent<SpriteRenderer>().color = originalColor;
        }
        if (board.boardTiles[myTile.GetRow() - x, myTile.GetColumn() - 1].myPiece != null)
        {
            board.boardTiles[myTile.GetRow() - x, myTile.GetColumn() - 1].GetComponent<SpriteRenderer>().color = originalColor;
        }
    }
    public override bool CanMove(BoardTile boardTile, Board board)
    {
        bool MoveToPosition = false;
        int x;
        if (isWhite) { x = -1; }
        else { x = 1; }
        if (myTile.GetRow() - boardTile.GetRow() == x)
        {
            if ((myTile.GetColumn() == boardTile.GetColumn() && boardTile.myPiece == null) ||
                board.boardTiles[boardTile.GetRow(), myTile.GetColumn() + 1].myPiece != null &&
                myTile.myPiece.isWhite != boardTile.myPiece.isWhite ||
                board.boardTiles[boardTile.GetRow(), myTile.GetColumn() - 1].myPiece != null && 
                myTile.myPiece.isWhite != boardTile.myPiece.isWhite)
            {
              MoveToPosition = true;
            }
        }
        return MoveToPosition;
        
    }

}