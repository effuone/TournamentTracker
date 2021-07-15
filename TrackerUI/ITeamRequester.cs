using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentLibrary.Models;

namespace TrackerUI {
  public interface ITeamRequester {
    void TeamComplete(TeamModel model);
  }
}
