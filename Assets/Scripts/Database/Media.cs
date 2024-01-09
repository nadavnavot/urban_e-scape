using System;
using UnityEngine;

[Serializable]
public class Media
{
    public int med_id { get; set; } // primary key
    public int med_aw_id { get; set; } // foreign key
    public DateTime med_date { get; set; }
    public string med_media { get; set; }
    public string med_medt_id { get; set; }
}
