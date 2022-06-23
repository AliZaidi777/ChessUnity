using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardTile : MonoBehaviour
{
    public ChessPiece myPiece = null;
    [SerializeField] private int myRow;
    [SerializeField] private int myColumn;

    public void SetRowColumn(int row, int column)
    {
        myRow = row;
        myColumn = column;
    }
    public int GetRow()
    {
        return myRow; ;
    }

    public int GetColumn()
    {
        return myColumn;
    }

    private void OnMouseDown()
    {
        FindObjectOfType<GameController>().OnBoardTileSelected(myRow, myColumn);
    }
}





