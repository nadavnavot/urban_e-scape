using System;
using UnityEngine;

[Serializable]
public class Media
{
    public int id { get; set; } // primary key
    public int artwork_id { get; set; } // foreign key
    public DateTime date { get; set; }
    public string media { get; set; }
    public string mediaType { get; set; }
}
