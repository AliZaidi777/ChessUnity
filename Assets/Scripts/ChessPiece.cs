using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChessPiece : MonoBehaviour
{
    //[SerializeField] private BoardTile myTile = null;
    //[SerializeField] private bool isWhite = true;
    public BoardTile myTile = null;
    public bool isWhite = true;
    public abstract bool CanMove(BoardTile boardTile, Board board);
    public abstract void move(BoardTile boardTile, Board board);
    public abstract void MoveD(BoardTile boardTile, Board board);
}
