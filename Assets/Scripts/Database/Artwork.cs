using System;
using UnityEngine;

[Serializable]
public class Artwork : MonoBehaviour
{
    public int aw_id { get; set; } // primary key
    public string aw_title { get; set; }
    public string aw_description { get; set; }
    public string aw_location { get; set; }
    public int aw_creation_year { get; set; }
    public string aw_street_map_view { get; set; }
    public string aw_category { get; set; }
    public sbyte aw_status { get; set; }
}
    
}
