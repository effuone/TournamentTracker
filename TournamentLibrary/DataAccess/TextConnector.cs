using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TournamentLibrary.DataAccess.TextHelpers;
using TournamentLibrary.Models;

namespace TournamentLibrary.DataAccess {
  public class TextConnector : IDataConnection {
    public const string PrizesFile = "PrizeModels.cvs";
    public const string PeopleFile = "PersonModels.cvs";
    public const string TeamFile = "TeamModels.cvs";

    public PersonModel CreatePerson(PersonModel model) {
      List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPeopleModels();
      int currentId = 1;
      if (people.Count > 0) {
        currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
      }
      model.Id = currentId;
      people.Add(model);
      people.SaveToPeopleFile(PeopleFile);
      return model;
    }

    public PrizeModel CreatePrize(PrizeModel model) {
      //Load the text file and convert the text to List<PrizeModel>
      List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

      //Find the ID
      int currentId = 1;
      if(prizes.Count > 0) {
        currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
      }
      model.Id = currentId;

      //Add the new record with the new ID 
      prizes.Add(model);

      //Convert the prizes to List<string>
      //Save the List<string> to the text file
      prizes.SaveToPrizeFile(PrizesFile);

      return model;
    }

    public TeamModel CreateTeam(TeamModel model) {
      List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
      int currentId = 1;
      if(teams.Count > 0) {
        currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
      }
      model.Id = currentId;
      teams.Add(model);
      teams.SaveToTeamFile(TeamFile);
      return model;
    }

    public List<PersonModel> GetPerson_All() {
      return PeopleFile.FullFilePath().LoadFile().ConvertToPeopleModels();
    }

    public List<TeamModel> GetTeam_All() {
      return TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
    }
  }
}
