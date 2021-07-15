
namespace TrackerUI {
  partial class CreateTeamForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.teamNameValue = new System.Windows.Forms.TextBox();
      this.teamNameLabel = new System.Windows.Forms.Label();
      this.createTeamLabel = new System.Windows.Forms.Label();
      this.addMemberButton = new System.Windows.Forms.Button();
      this.selectedTeamMemberDropDown = new System.Windows.Forms.ComboBox();
      this.selectTeamMemberLabel = new System.Windows.Forms.Label();
      this.addNewMemberBox = new System.Windows.Forms.GroupBox();
      this.createMemberButton = new System.Windows.Forms.Button();
      this.cellPhoneValue = new System.Windows.Forms.TextBox();
      this.cellphoneLabel = new System.Windows.Forms.Label();
      this.emailValue = new System.Windows.Forms.TextBox();
      this.EmailLabel = new System.Windows.Forms.Label();
      this.lastNameValue = new System.Windows.Forms.TextBox();
      this.lastNameLabel = new System.Windows.Forms.Label();
      this.firstNameValue = new System.Windows.Forms.TextBox();
      this.firstNameLabel = new System.Windows.Forms.Label();
      this.teamMembersListBox = new System.Windows.Forms.ListBox();
      this.removeSelectedMemberButton = new System.Windows.Forms.Button();
      this.createTeamButton = new System.Windows.Forms.Button();
      this.addNewMemberBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // teamNameValue
      // 
      this.teamNameValue.Location = new System.Drawing.Point(21, 99);
      this.teamNameValue.Name = "teamNameValue";
      this.teamNameValue.Size = new System.Drawing.Size(351, 43);
      this.teamNameValue.TabIndex = 13;
      // 
      // teamNameLabel
      // 
      this.teamNameLabel.AutoSize = true;
      this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.teamNameLabel.Location = new System.Drawing.Point(14, 59);
      this.teamNameLabel.Name = "teamNameLabel";
      this.teamNameLabel.Size = new System.Drawing.Size(157, 37);
      this.teamNameLabel.TabIndex = 12;
      this.teamNameLabel.Text = "Team Name";
      // 
      // createTeamLabel
      // 
      this.createTeamLabel.AutoSize = true;
      this.createTeamLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.createTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.createTeamLabel.Location = new System.Drawing.Point(12, 9);
      this.createTeamLabel.Name = "createTeamLabel";
      this.createTeamLabel.Size = new System.Drawing.Size(221, 50);
      this.createTeamLabel.TabIndex = 11;
      this.createTeamLabel.Text = "Create Team";
      // 
      // addMemberButton
      // 
      this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.addMemberButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.addMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.addMemberButton.Location = new System.Drawing.Point(98, 249);
      this.addMemberButton.Name = "addMemberButton";
      this.addMemberButton.Size = new System.Drawing.Size(205, 42);
      this.addMemberButton.TabIndex = 20;
      this.addMemberButton.Text = "Add Member";
      this.addMemberButton.UseVisualStyleBackColor = true;
      this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
      // 
      // selectedTeamMemberDropDown
      // 
      this.selectedTeamMemberDropDown.FormattingEnabled = true;
      this.selectedTeamMemberDropDown.Location = new System.Drawing.Point(21, 198);
      this.selectedTeamMemberDropDown.Name = "selectedTeamMemberDropDown";
      this.selectedTeamMemberDropDown.Size = new System.Drawing.Size(351, 45);
      this.selectedTeamMemberDropDown.TabIndex = 18;
      // 
      // selectTeamMemberLabel
      // 
      this.selectTeamMemberLabel.AutoSize = true;
      this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.selectTeamMemberLabel.Location = new System.Drawing.Point(14, 158);
      this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
      this.selectTeamMemberLabel.Size = new System.Drawing.Size(263, 37);
      this.selectTeamMemberLabel.TabIndex = 17;
      this.selectTeamMemberLabel.Text = "Select Team Member";
      // 
      // addNewMemberBox
      // 
      this.addNewMemberBox.Controls.Add(this.createMemberButton);
      this.addNewMemberBox.Controls.Add(this.cellPhoneValue);
      this.addNewMemberBox.Controls.Add(this.cellphoneLabel);
      this.addNewMemberBox.Controls.Add(this.emailValue);
      this.addNewMemberBox.Controls.Add(this.EmailLabel);
      this.addNewMemberBox.Controls.Add(this.lastNameValue);
      this.addNewMemberBox.Controls.Add(this.lastNameLabel);
      this.addNewMemberBox.Controls.Add(this.firstNameValue);
      this.addNewMemberBox.Controls.Add(this.firstNameLabel);
      this.addNewMemberBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.addNewMemberBox.Location = new System.Drawing.Point(21, 297);
      this.addNewMemberBox.Name = "addNewMemberBox";
      this.addNewMemberBox.Size = new System.Drawing.Size(509, 288);
      this.addNewMemberBox.TabIndex = 21;
      this.addNewMemberBox.TabStop = false;
      this.addNewMemberBox.Text = "Add New Member";
      // 
      // createMemberButton
      // 
      this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.createMemberButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.createMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.createMemberButton.Location = new System.Drawing.Point(146, 236);
      this.createMemberButton.Name = "createMemberButton";
      this.createMemberButton.Size = new System.Drawing.Size(205, 42);
      this.createMemberButton.TabIndex = 22;
      this.createMemberButton.Text = "Create Member";
      this.createMemberButton.UseVisualStyleBackColor = true;
      this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
      // 
      // cellPhoneValue
      // 
      this.cellPhoneValue.Location = new System.Drawing.Point(162, 188);
      this.cellPhoneValue.Name = "cellPhoneValue";
      this.cellPhoneValue.Size = new System.Drawing.Size(341, 43);
      this.cellPhoneValue.TabIndex = 29;
      // 
      // cellphoneLabel
      // 
      this.cellphoneLabel.AutoSize = true;
      this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.cellphoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.cellphoneLabel.Location = new System.Drawing.Point(12, 190);
      this.cellphoneLabel.Name = "cellphoneLabel";
      this.cellphoneLabel.Size = new System.Drawing.Size(138, 37);
      this.cellphoneLabel.TabIndex = 28;
      this.cellphoneLabel.Text = "Cellphone";
      // 
      // emailValue
      // 
      this.emailValue.Location = new System.Drawing.Point(162, 139);
      this.emailValue.Name = "emailValue";
      this.emailValue.Size = new System.Drawing.Size(341, 43);
      this.emailValue.TabIndex = 27;
      // 
      // EmailLabel
      // 
      this.EmailLabel.AutoSize = true;
      this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.EmailLabel.Location = new System.Drawing.Point(12, 142);
      this.EmailLabel.Name = "EmailLabel";
      this.EmailLabel.Size = new System.Drawing.Size(82, 37);
      this.EmailLabel.TabIndex = 26;
      this.EmailLabel.Text = "Email";
      // 
      // lastNameValue
      // 
      this.lastNameValue.Location = new System.Drawing.Point(162, 91);
      this.lastNameValue.Name = "lastNameValue";
      this.lastNameValue.Size = new System.Drawing.Size(341, 43);
      this.lastNameValue.TabIndex = 25;
      // 
      // lastNameLabel
      // 
      this.lastNameLabel.AutoSize = true;
      this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.lastNameLabel.Location = new System.Drawing.Point(12, 94);
      this.lastNameLabel.Name = "lastNameLabel";
      this.lastNameLabel.Size = new System.Drawing.Size(142, 37);
      this.lastNameLabel.TabIndex = 24;
      this.lastNameLabel.Text = "Last Name";
      // 
      // firstNameValue
      // 
      this.firstNameValue.Location = new System.Drawing.Point(162, 42);
      this.firstNameValue.Name = "firstNameValue";
      this.firstNameValue.Size = new System.Drawing.Size(341, 43);
      this.firstNameValue.TabIndex = 23;
      // 
      // firstNameLabel
      // 
      this.firstNameLabel.AutoSize = true;
      this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.firstNameLabel.Location = new System.Drawing.Point(12, 45);
      this.firstNameLabel.Name = "firstNameLabel";
      this.firstNameLabel.Size = new System.Drawing.Size(144, 37);
      this.firstNameLabel.TabIndex = 22;
      this.firstNameLabel.Text = "First Name";
      // 
      // teamMembersListBox
      // 
      this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.teamMembersListBox.FormattingEnabled = true;
      this.teamMembersListBox.ItemHeight = 37;
      this.teamMembersListBox.Location = new System.Drawing.Point(554, 42);
      this.teamMembersListBox.Name = "teamMembersListBox";
      this.teamMembersListBox.Size = new System.Drawing.Size(316, 520);
      this.teamMembersListBox.TabIndex = 22;
      // 
      // removeSelectedMemberButton
      // 
      this.removeSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.removeSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.removeSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.removeSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.removeSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.removeSelectedMemberButton.Location = new System.Drawing.Point(905, 236);
      this.removeSelectedMemberButton.Name = "removeSelectedMemberButton";
      this.removeSelectedMemberButton.Size = new System.Drawing.Size(110, 126);
      this.removeSelectedMemberButton.TabIndex = 23;
      this.removeSelectedMemberButton.Text = "Remove Selected";
      this.removeSelectedMemberButton.UseVisualStyleBackColor = true;
      this.removeSelectedMemberButton.Click += new System.EventHandler(this.removeSelectedMemberButton_Click);
      // 
      // createTeamButton
      // 
      this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.createTeamButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.createTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.createTeamButton.Location = new System.Drawing.Point(369, 591);
      this.createTeamButton.Name = "createTeamButton";
      this.createTeamButton.Size = new System.Drawing.Size(321, 42);
      this.createTeamButton.TabIndex = 25;
      this.createTeamButton.Text = "Create Team";
      this.createTeamButton.UseVisualStyleBackColor = true;
      this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
      // 
      // CreateTeamForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1040, 652);
      this.Controls.Add(this.createTeamButton);
      this.Controls.Add(this.removeSelectedMemberButton);
      this.Controls.Add(this.teamMembersListBox);
      this.Controls.Add(this.addNewMemberBox);
      this.Controls.Add(this.addMemberButton);
      this.Controls.Add(this.selectedTeamMemberDropDown);
      this.Controls.Add(this.selectTeamMemberLabel);
      this.Controls.Add(this.teamNameValue);
      this.Controls.Add(this.teamNameLabel);
      this.Controls.Add(this.createTeamLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
      this.Name = "CreateTeamForm";
      this.Text = "Create Team";
      this.addNewMemberBox.ResumeLayout(false);
      this.addNewMemberBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox teamNameValue;
    private System.Windows.Forms.Label teamNameLabel;
    private System.Windows.Forms.Label createTeamLabel;
    private System.Windows.Forms.Button addMemberButton;
    private System.Windows.Forms.ComboBox selectedTeamMemberDropDown;
    private System.Windows.Forms.Label selectTeamMemberLabel;
    private System.Windows.Forms.GroupBox addNewMemberBox;
    private System.Windows.Forms.Button createMemberButton;
    private System.Windows.Forms.TextBox cellPhoneValue;
    private System.Windows.Forms.Label cellphoneLabel;
    private System.Windows.Forms.TextBox emailValue;
    private System.Windows.Forms.Label EmailLabel;
    private System.Windows.Forms.TextBox lastNameValue;
    private System.Windows.Forms.Label lastNameLabel;
    private System.Windows.Forms.TextBox firstNameValue;
    private System.Windows.Forms.Label firstNameLabel;
    private System.Windows.Forms.ListBox teamMembersListBox;
    private System.Windows.Forms.Button removeSelectedMemberButton;
    private System.Windows.Forms.Button createTeamButton;
  }
}