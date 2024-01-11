using System;
using UnityEngine;

[Serializable]
public class Artwork
{
    public int id { get; set; } // primary key
    public string artwork_name { get; set; }
    public string description { get; set; }
    public string location { get; set; }
    public int year_of_creation { get; set; }
    public string country_of_origin { get; set; }
    public string art_category { get; set; }
    public bool status { get; set; }
}
