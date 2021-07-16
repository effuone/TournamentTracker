using System;
using System.Collections.Generic;
using System.Text;
using TournamentLibrary.Models;

namespace TournamentLibrary.DataAccess {
  public interface IDataConnection {
    PrizeModel CreatePrize(PrizeModel model);
    PersonModel CreatePerson(PersonModel model);
    TeamModel CreateTeam(TeamModel model);
    TournamentModel CreateTournament(TournamentModel model);
    List<TeamModel> GetTeam_All();
    List<PersonModel> GetPerson_All();
  }
}
