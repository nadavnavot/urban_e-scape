using System;
using UnityEngine;

[Serializable]
public class ArtistArtwork : MonoBehaviour
{
    public int aa_id { get; set; } // primary key
    public int aa_at_id { get; set; } // foreign key
    public int aa_aw_id { get; set; } // foreign key

}
