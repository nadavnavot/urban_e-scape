using System;
using UnityEngine;

[Serializable]
public class Artwork
{
    public int aw_id { get; set; } // primary key
    public string aw_title { get; set; }
    public string aw_description { get; set; }
    public string aw_location { get; set; }
    public int aw_creation_year { get; set; }
    public string aw_street_map_view { get; set; }
    public string aw_category { get; set; }
    public bool aw_status { get; set; }
    public string aw_image_url; // Assuming the API returns the image URL here
    public string artistName; // Assuming the artist's name comes within the Artwork object
}
