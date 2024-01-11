using System;
using UnityEngine;

[Serializable]
public class Artist
{
    public int id { get; set; } // primary key
    public string name { get; set; }
    public int birth_year { get; set; } 
    public string nationality { get; set; }
}
