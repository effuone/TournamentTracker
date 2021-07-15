using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary.Models {
  public class TeamModel {
    public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
    public string TeamName { get; set; }
    public int Id { get; set; }
  }
}
