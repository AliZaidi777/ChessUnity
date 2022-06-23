using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : ChessPiece
{
    Color originalColor;
    public override void move(BoardTile boardTile, Board board)
    {
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

        if (myTile.GetRow() - boardTile.GetRow() == -1 || myTile.GetColumn() - boardTile.GetColumn() == -1 || myTile.GetRow() - boardTile.GetRow() == 1 || myTile.GetColumn() - boardTile.GetColumn() == 1 ||
            myTile.GetRow() + 1 == boardTile.GetRow() && myTile.GetColumn() + 1 == boardTile.GetColumn() || myTile.GetRow() - 1 == boardTile.GetRow() && myTile.GetColumn() - 1 == boardTile.GetColumn() ||
            myTile.GetRow() + 1 == boardTile.GetRow() && myTile.GetColumn() - 1 == boardTile.GetColumn() || myTile.GetRow() - 1 == boardTile.GetRow() && myTile.GetColumn() + 1 == boardTile.GetColumn())
        {
            if (board.boardTiles[boardTile.GetRow(), boardTile.GetColumn()].myPiece == null ||
            board.boardTiles[boardTile.GetRow(), boardTile.GetColumn()].myPiece != null && boardTile.myPiece.isWhite != myTile.myPiece.isWhite)
            {


                MoveToPosition = true;
            }
        }

        return MoveToPosition;
    }
}
