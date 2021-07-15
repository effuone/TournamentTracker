using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentLibrary;
using TournamentLibrary.Models;

namespace TrackerUI {
  public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester {
    List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
    List<TeamModel> selectedTeams = new List<TeamModel>();
    List<PrizeModel> selectedPrizes = new List<PrizeModel>();
    public CreateTournamentForm() {
      InitializeComponent();
      InitializeLists();
    }
    private void InitializeLists() {
      selectedTeamDropDown.DataSource = availableTeams;
      selectedTeamDropDown.DisplayMember = "TeamName";

      tournamentPlayerListBox.DataSource = selectedTeams;
      tournamentPlayerListBox.DisplayMember = "TeamName";

      prizesListBox.DataSource = selectedPrizes;
      prizesListBox.DisplayMember = "PlaceName";
    }
    private void WireUpLists() {
      selectedTeamDropDown.DataSource = null;

      selectedTeamDropDown.DataSource = availableTeams;
      selectedTeamDropDown.DisplayMember = "TeamName";

      tournamentPlayerListBox.DataSource = null;
      tournamentPlayerListBox.DataSource = selectedTeams;
      tournamentPlayerListBox.DisplayMember = "TeamName";

      prizesListBox.DataSource = null;
      prizesListBox.DataSource = selectedPrizes;
      prizesListBox.DisplayMember = "PlaceName";
    }

    private void addTeamButton_Click(object sender, EventArgs e) {
      TeamModel t = (TeamModel)selectedTeamDropDown.SelectedItem;

      if (t != null) {
        availableTeams.Remove(t);
        selectedTeams.Add(t);

        WireUpLists();
      }
    }

    private void createPrizeButton_Click(object sender, EventArgs e) {
      //Call the CreatePrizeForm
      CreatePrizeForm frm = new CreatePrizeForm(this);
      frm.Show();
      
      
    }

    public void PrizeComplete(PrizeModel model) {
      //Get back from the form a PrizeModel
      //Take the PrizeModel and put it into our list or selected prizes
      selectedPrizes.Add(model);
      WireUpLists();
    }

    public void TeamComplete(TeamModel model) {
      selectedTeams.Add(model);
      WireUpLists();
    }

    private void createNewTeamLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      CreateTeamForm frm = new CreateTeamForm(this);
      frm.Show();
    }

    private void playerDeleteButton_Click(object sender, EventArgs e) {
      TeamModel team = (TeamModel)tournamentPlayerListBox.SelectedItem;
      if (team != null) {
        selectedTeams.Remove(team);
        availableTeams.Add(team);

        WireUpLists();
      }
    }

    private void prizeDeleteButton_Click(object sender, EventArgs e) {
      PrizeModel prize = (PrizeModel)tournamentPlayerListBox.SelectedItem;
      if (prize != null) {
        selectedPrizes.Remove(prize);
        availablePrizes.Add(prize);

        WireUpLists();
      }
    }
  }
}
