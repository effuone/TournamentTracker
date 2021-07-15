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
  public partial class CreateTeamForm : Form {

    private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
    private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
    private ITeamRequester callingForm;
    public CreateTeamForm(ITeamRequester caller) {
      InitializeComponent();
      callingForm = caller;
      //CreateSampleData();

      WireUpLists();
    }


    private void CreateSampleData() {
      availableTeamMembers.Add(new PersonModel { FirstName = "Alibek", LastName = "Seitov" });
      availableTeamMembers.Add(new PersonModel { FirstName = "Alibi", LastName = "Nurlan" });
      availableTeamMembers.Add(new PersonModel { FirstName = "Tarlan", LastName = "Takuov" });
      availableTeamMembers.Add(new PersonModel { FirstName = "Dias", LastName = "Zhaparov" });

      selectedTeamMembers.Add(new PersonModel { FirstName = "Alisher", LastName = "Zakirov" });
      selectedTeamMembers.Add(new PersonModel { FirstName = "Tamir", LastName = "Talgat" });
      selectedTeamMembers.Add(new PersonModel { FirstName = "Alikhan", LastName = "Tleubekov" });

    }

    private void LoadListData() {
      availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
    }
    
    private void WireUpLists() {
      selectedTeamMemberDropDown.DataSource = null;

      selectedTeamMemberDropDown.DataSource = availableTeamMembers;
      selectedTeamMemberDropDown.DisplayMember = "FullName";

      teamMembersListBox.DataSource = null;

      teamMembersListBox.DataSource = selectedTeamMembers;
      teamMembersListBox.DisplayMember = "FullName";
    }

    private void createMemberButton_Click(object sender, EventArgs e) {
      if (ValidateForm()) {
        var p = new PersonModel();
        p.FirstName = firstNameValue.Text;
        p.LastName = lastNameValue.Text;
        p.EmailAddress = emailValue.Text;
        p.CellPhoneNumber = cellPhoneValue.Text;

        p = GlobalConfig.Connection.CreatePerson(p);

        selectedTeamMembers.Add(p);
        WireUpLists();

        firstNameValue.Text = "";
        lastNameValue.Text = "";
        emailValue.Text = "";
        cellPhoneValue.Text = "";
      } else {
        MessageBox.Show("You need to fill in all of the fields");
      }
    }
    private bool ValidateForm() {
      if(firstNameValue.Text.Length == 0) {
        return false;
      }
      if(lastNameValue.Text.Length == 0) {
        return false;
      }
      if (emailValue.Text.Length == 0) {
        return false;
      }
      
      if (cellPhoneValue.Text.Length == 0) {
        return false;
      }
      return true;
    }

    private void addMemberButton_Click(object sender, EventArgs e) {
      PersonModel p = (PersonModel)selectedTeamMemberDropDown.SelectedItem;
      if (p != null) {
        availableTeamMembers.Remove(p);
        selectedTeamMembers.Add(p);

        selectedTeamMemberDropDown.Refresh();
        teamMembersListBox.Refresh();

        WireUpLists();
      }
    }

    private void removeSelectedMemberButton_Click(object sender, EventArgs e) {
      PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;
      if (p != null) {
        selectedTeamMembers.Remove(p);
        availableTeamMembers.Add(p);

        WireUpLists();
      }
    }

    private void createTeamButton_Click(object sender, EventArgs e) {
      TeamModel t = new TeamModel();
      t.TeamName = teamNameValue.Text;
      t.TeamMembers = selectedTeamMembers;

      GlobalConfig.Connection.CreateTeam(t);
      callingForm.TeamComplete(t);

      this.Close();
    }
  }
}
