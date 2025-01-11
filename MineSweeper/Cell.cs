using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Cell

{
    public enum Type
    {
        Invalid,
        Empty,
        Mine,
        Number,
    }
    public Vector3Int position;
    public Type type;
    public int number;
    
    public bool revealed;
    public bool flagged;
    public bool exploded;

}


//Hidden
//Mine, number, or empty
//if empty, is there one near it? how many
//its location on the grid
