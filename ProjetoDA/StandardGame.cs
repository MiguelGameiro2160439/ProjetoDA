//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoDA
{
    using System;
    using System.Collections.Generic;
    
    public partial class StandardGame : Game
    {
        public Nullable<int> PlayerOneId { get; set; }
        public Nullable<int> PlayerTwoId { get; set; }
        public int StandardTournamentId { get; set; }
    
        public virtual Player PlayerOne { get; set; }
        public virtual Player PlayerTwo { get; set; }
        public virtual StandardTournament Tournament { get; set; }
    }
}
