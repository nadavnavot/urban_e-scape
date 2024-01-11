using System;
using UnityEngine;

[Serializable]
public class ArtistArtwork
{
    public int id { get; set; } // primary key
    public int artist_id { get; set; } // foreign key
    public int artwork_id { get; set; } // foreign key

}
