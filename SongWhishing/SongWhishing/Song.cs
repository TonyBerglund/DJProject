//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SongWishing
{
    using System;

    public partial class Song
    {
        public int IDSong { get; set; }
        public string Artist { get; set; }
        public string Låtnamn { get; set; }
        public Nullable<short> BPM { get; set; }
        public string Genre_1 { get; set; }
        public string Genre_2 { get; set; }
        public string Skivnamn { get; set; }
        public Nullable<short> Utgivningsår { get; set; }
        public Nullable<System.DateTime> Importdatum { get; set; }
        public bool Omit { get; set; }
    }
}
