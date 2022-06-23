using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : ChessPiece
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
        // Right , Left move 1 && 2 times bottom move :
        if (myTile.GetRow() + 2 == boardTile.GetRow() && myTile.GetColumn() + 1 == boardTile.GetColumn() || myTile.GetRow() + 2 == boardTile.GetRow() && myTile.GetColumn() - 1 == boardTile.GetColumn()) { MoveToPosition = true; }
        // Right , Left move 2 && 1 times bottom move :
        else if (myTile.GetRow() + 1 == boardTile.GetRow() && myTile.GetColumn() + 2 == boardTile.GetColumn() || myTile.GetRow() + 1 == boardTile.GetRow() && myTile.GetColumn() - 2 == boardTile.GetColumn()) { MoveToPosition = true; }
        // Right , Left move 1 && 2 times Top move :
        else if (myTile.GetRow() - 2 == boardTile.GetRow() && myTile.GetColumn() + 1 == boardTile.GetColumn() || myTile.GetRow() - 2 == boardTile.GetRow() && myTile.GetColumn() - 1 == boardTile.GetColumn()) { MoveToPosition = true; }
        // Right , Left move 2 && 1 times Top move :
        else if (myTile.GetRow() - 1 == boardTile.GetRow() && myTile.GetColumn() + 2 == boardTile.GetColumn() || myTile.GetRow() - 1 == boardTile.GetRow() && myTile.GetColumn() - 2 == boardTile.GetColumn()) { MoveToPosition = true; }
        else
        {
            MoveToPosition = false;
        }
        return MoveToPosition;
    }
}
