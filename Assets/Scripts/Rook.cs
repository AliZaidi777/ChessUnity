using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : ChessPiece
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
        int z = 0;
        if (myTile.GetRow() == boardTile.GetRow() || myTile.GetColumn() == boardTile.GetColumn())
        {
            if (z == 0)
            {
                // Rook Move Top
                if (myTile.GetRow() > boardTile.GetRow() && myTile.GetColumn() == boardTile.GetColumn())
                {
                    for (int x = myTile.GetRow() - 1; x > boardTile.GetRow(); x--)
                    {
                        if (board.boardTiles[x, boardTile.GetColumn()].myPiece == null)
                        {
                            z = 1;
                            MoveToPosition = true;
                        }
                        else
                        {
                            MoveToPosition = false;
                            break;
                        }
                    }
                }
                // Rook Move Buttom
                else if (myTile.GetRow() < boardTile.GetRow() || myTile.GetColumn() == boardTile.GetColumn())
                {
                    for (int x = myTile.GetRow() + 1; x < boardTile.GetRow(); x++)
                    {
                        if (board.boardTiles[x, boardTile.GetColumn()].myPiece == null)
                        {
                            z = 1;
                            MoveToPosition = true;
                        }
                        else
                        {
                            MoveToPosition = false;
                            break;
                        }
                    }
                }
                //Rook move on left 
                else if (myTile.GetColumn() < boardTile.GetColumn() && myTile.GetRow() == boardTile.GetRow())
                {
                    for (int y = myTile.GetColumn() + 1; y < boardTile.GetColumn(); y++)
                    {
                        if (board.boardTiles[boardTile.GetRow(), y].myPiece == null)
                        {
                            z = 1;
                            MoveToPosition = true;
                        }
                        else
                        {
                            MoveToPosition = false;
                            break;
                        }
                    }
                }
                //Rook move on right
                else if (myTile.GetColumn() > boardTile.GetColumn() && myTile.GetRow() == boardTile.GetRow())
                {
                    for (int y = myTile.GetColumn() - 1; y > boardTile.GetColumn(); y--)
                    {
                        if (board.boardTiles[boardTile.GetRow(), y].myPiece == null)
                        {
                            z = 1;
                            MoveToPosition = true;
                        }
                        else
                        {
                            MoveToPosition = false;
                            break;
                        }
                    }
                }
            }
            if (MoveToPosition == false && z == 0)
            {
                if (boardTile.GetRow() == myTile.GetRow() + 1 && boardTile.GetColumn() == myTile.GetColumn() ||
                    boardTile.GetRow() == myTile.GetRow() - 1 && boardTile.GetColumn() == myTile.GetColumn() ||
                    boardTile.GetRow() == myTile.GetRow() && boardTile.GetColumn() == myTile.GetColumn() - 1 ||
                    boardTile.GetRow() == myTile.GetRow() && boardTile.GetColumn() == myTile.GetColumn() + 1)
                {
                    if (board.boardTiles[boardTile.GetRow(), boardTile.GetColumn()].myPiece == null ||
                        board.boardTiles[boardTile.GetRow(), boardTile.GetColumn()].myPiece != null && boardTile.myPiece.isWhite != myTile.myPiece.isWhite)
                    {
                        MoveToPosition = true;
                    }
                    else
                    {
                        MoveToPosition = false;
                    }
                }
            }
            else if (MoveToPosition == true && z == 1)
            {
                if (board.boardTiles[boardTile.GetRow(), boardTile.GetColumn()].myPiece == null ||
                      board.boardTiles[boardTile.GetRow(), boardTile.GetColumn()].myPiece != null && boardTile.myPiece.isWhite != myTile.myPiece.isWhite)
                {
                    MoveToPosition = true;
                }
                else
                {
                    MoveToPosition = false;
                }

            }
        }
        return MoveToPosition;
    }

}
