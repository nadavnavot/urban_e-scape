using System;
using UnityEngine;

[Serializable]
public class Artist : MonoBehaviour
{
    public int at_id { get; set; } // primary key
    public string at_name { get; set; }
    public int at_birth_year { get; set; } 
    string at_nationality { get; set; }
}
