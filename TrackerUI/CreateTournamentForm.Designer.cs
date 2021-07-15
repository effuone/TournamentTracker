
namespace TrackerUI {
  partial class CreateTournamentForm {
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
      this.headerLabel = new System.Windows.Forms.Label();
      this.teamOneTextBox = new System.Windows.Forms.TextBox();
      this.TournamentNameValue = new System.Windows.Forms.Label();
      this.entryFeeTextBox = new System.Windows.Forms.TextBox();
      this.entryFeeLabel = new System.Windows.Forms.Label();
      this.selectedTeamDropDown = new System.Windows.Forms.ComboBox();
      this.selectTeamLabel = new System.Windows.Forms.Label();
      this.createNewTeamLabel = new System.Windows.Forms.LinkLabel();
      this.addTeamButton = new System.Windows.Forms.Button();
      this.createPrizeButton = new System.Windows.Forms.Button();
      this.tournamentPlayerListBox = new System.Windows.Forms.ListBox();
      this.tournamentPlayersLabel = new System.Windows.Forms.Label();
      this.playerDeleteButton = new System.Windows.Forms.Button();
      this.prizeDeleteButton = new System.Windows.Forms.Button();
      this.prizesLabel = new System.Windows.Forms.Label();
      this.prizesListBox = new System.Windows.Forms.ListBox();
      this.createTournamentButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // headerLabel
      // 
      this.headerLabel.AutoSize = true;
      this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.headerLabel.Location = new System.Drawing.Point(12, 9);
      this.headerLabel.Name = "headerLabel";
      this.headerLabel.Size = new System.Drawing.Size(327, 50);
      this.headerLabel.TabIndex = 1;
      this.headerLabel.Text = "Create Tournament";
      // 
      // teamOneTextBox
      // 
      this.teamOneTextBox.Location = new System.Drawing.Point(21, 126);
      this.teamOneTextBox.Name = "teamOneTextBox";
      this.teamOneTextBox.Size = new System.Drawing.Size(351, 35);
      this.teamOneTextBox.TabIndex = 10;
      // 
      // TournamentNameValue
      // 
      this.TournamentNameValue.AutoSize = true;
      this.TournamentNameValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.TournamentNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.TournamentNameValue.Location = new System.Drawing.Point(14, 74);
      this.TournamentNameValue.Name = "TournamentNameValue";
      this.TournamentNameValue.Size = new System.Drawing.Size(236, 37);
      this.TournamentNameValue.TabIndex = 9;
      this.TournamentNameValue.Text = "Tournament Name";
      // 
      // entryFeeTextBox
      // 
      this.entryFeeTextBox.Location = new System.Drawing.Point(150, 167);
      this.entryFeeTextBox.Name = "entryFeeTextBox";
      this.entryFeeTextBox.Size = new System.Drawing.Size(100, 35);
      this.entryFeeTextBox.TabIndex = 12;
      this.entryFeeTextBox.Text = "0";
      // 
      // entryFeeLabel
      // 
      this.entryFeeLabel.AutoSize = true;
      this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.entryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.entryFeeLabel.Location = new System.Drawing.Point(14, 165);
      this.entryFeeLabel.Name = "entryFeeLabel";
      this.entryFeeLabel.Size = new System.Drawing.Size(125, 37);
      this.entryFeeLabel.TabIndex = 11;
      this.entryFeeLabel.Text = "Entry Fee";
      // 
      // selectedTeamDropDown
      // 
      this.selectedTeamDropDown.FormattingEnabled = true;
      this.selectedTeamDropDown.Location = new System.Drawing.Point(21, 251);
      this.selectedTeamDropDown.Name = "selectedTeamDropDown";
      this.selectedTeamDropDown.Size = new System.Drawing.Size(351, 38);
      this.selectedTeamDropDown.TabIndex = 14;
      // 
      // selectTeamLabel
      // 
      this.selectTeamLabel.AutoSize = true;
      this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.selectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.selectTeamLabel.Location = new System.Drawing.Point(14, 211);
      this.selectTeamLabel.Name = "selectTeamLabel";
      this.selectTeamLabel.Size = new System.Drawing.Size(156, 37);
      this.selectTeamLabel.TabIndex = 13;
      this.selectTeamLabel.Text = "Select Team";
      // 
      // createNewTeamLabel
      // 
      this.createNewTeamLabel.AutoSize = true;
      this.createNewTeamLabel.Location = new System.Drawing.Point(258, 218);
      this.createNewTeamLabel.Name = "createNewTeamLabel";
      this.createNewTeamLabel.Size = new System.Drawing.Size(114, 30);
      this.createNewTeamLabel.TabIndex = 15;
      this.createNewTeamLabel.TabStop = true;
      this.createNewTeamLabel.Text = "create new";
      this.createNewTeamLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLabel_LinkClicked);
      // 
      // addTeamButton
      // 
      this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.addTeamButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.addTeamButton.Location = new System.Drawing.Point(96, 321);
      this.addTeamButton.Name = "addTeamButton";
      this.addTeamButton.Size = new System.Drawing.Size(205, 42);
      this.addTeamButton.TabIndex = 16;
      this.addTeamButton.Text = "Add Team";
      this.addTeamButton.UseVisualStyleBackColor = true;
      this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
      // 
      // createPrizeButton
      // 
      this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.createPrizeButton.Location = new System.Drawing.Point(96, 386);
      this.createPrizeButton.Name = "createPrizeButton";
      this.createPrizeButton.Size = new System.Drawing.Size(205, 42);
      this.createPrizeButton.TabIndex = 17;
      this.createPrizeButton.Text = "Create Prize";
      this.createPrizeButton.UseVisualStyleBackColor = true;
      this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
      // 
      // tournamentPlayerListBox
      // 
      this.tournamentPlayerListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tournamentPlayerListBox.FormattingEnabled = true;
      this.tournamentPlayerListBox.ItemHeight = 30;
      this.tournamentPlayerListBox.Location = new System.Drawing.Point(442, 126);
      this.tournamentPlayerListBox.Name = "tournamentPlayerListBox";
      this.tournamentPlayerListBox.Size = new System.Drawing.Size(316, 122);
      this.tournamentPlayerListBox.TabIndex = 18;
      // 
      // tournamentPlayersLabel
      // 
      this.tournamentPlayersLabel.AutoSize = true;
      this.tournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.tournamentPlayersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.tournamentPlayersLabel.Location = new System.Drawing.Point(434, 75);
      this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
      this.tournamentPlayersLabel.Size = new System.Drawing.Size(198, 37);
      this.tournamentPlayersLabel.TabIndex = 19;
      this.tournamentPlayersLabel.Text = "Teams / Players";
      // 
      // playerDeleteButton
      // 
      this.playerDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.playerDeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.playerDeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.playerDeleteButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.playerDeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.playerDeleteButton.Location = new System.Drawing.Point(782, 143);
      this.playerDeleteButton.Name = "playerDeleteButton";
      this.playerDeleteButton.Size = new System.Drawing.Size(110, 87);
      this.playerDeleteButton.TabIndex = 20;
      this.playerDeleteButton.Text = "Remove Selected";
      this.playerDeleteButton.UseVisualStyleBackColor = true;
      this.playerDeleteButton.Click += new System.EventHandler(this.playerDeleteButton_Click);
      // 
      // prizeDeleteButton
      // 
      this.prizeDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.prizeDeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.prizeDeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.prizeDeleteButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.prizeDeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.prizeDeleteButton.Location = new System.Drawing.Point(782, 345);
      this.prizeDeleteButton.Name = "prizeDeleteButton";
      this.prizeDeleteButton.Size = new System.Drawing.Size(110, 87);
      this.prizeDeleteButton.TabIndex = 23;
      this.prizeDeleteButton.Text = "Remove Selected";
      this.prizeDeleteButton.UseVisualStyleBackColor = true;
      this.prizeDeleteButton.Click += new System.EventHandler(this.prizeDeleteButton_Click);
      // 
      // prizesLabel
      // 
      this.prizesLabel.AutoSize = true;
      this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.prizesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.prizesLabel.Location = new System.Drawing.Point(434, 277);
      this.prizesLabel.Name = "prizesLabel";
      this.prizesLabel.Size = new System.Drawing.Size(85, 37);
      this.prizesLabel.TabIndex = 22;
      this.prizesLabel.Text = "Prizes";
      // 
      // prizesListBox
      // 
      this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.prizesListBox.FormattingEnabled = true;
      this.prizesListBox.ItemHeight = 30;
      this.prizesListBox.Location = new System.Drawing.Point(442, 328);
      this.prizesListBox.Name = "prizesListBox";
      this.prizesListBox.Size = new System.Drawing.Size(316, 122);
      this.prizesListBox.TabIndex = 21;
      // 
      // createTournamentButton
      // 
      this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.createTournamentButton.Location = new System.Drawing.Point(311, 532);
      this.createTournamentButton.Name = "createTournamentButton";
      this.createTournamentButton.Size = new System.Drawing.Size(321, 42);
      this.createTournamentButton.TabIndex = 24;
      this.createTournamentButton.Text = "Create Tournament";
      this.createTournamentButton.UseVisualStyleBackColor = true;
      // 
      // CreateTournamentForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(932, 586);
      this.Controls.Add(this.createTournamentButton);
      this.Controls.Add(this.prizeDeleteButton);
      this.Controls.Add(this.prizesLabel);
      this.Controls.Add(this.prizesListBox);
      this.Controls.Add(this.playerDeleteButton);
      this.Controls.Add(this.tournamentPlayersLabel);
      this.Controls.Add(this.tournamentPlayerListBox);
      this.Controls.Add(this.createPrizeButton);
      this.Controls.Add(this.addTeamButton);
      this.Controls.Add(this.createNewTeamLabel);
      this.Controls.Add(this.selectedTeamDropDown);
      this.Controls.Add(this.selectTeamLabel);
      this.Controls.Add(this.entryFeeTextBox);
      this.Controls.Add(this.entryFeeLabel);
      this.Controls.Add(this.teamOneTextBox);
      this.Controls.Add(this.TournamentNameValue);
      this.Controls.Add(this.headerLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(7);
      this.Name = "CreateTournamentForm";
      this.Text = "Create Tournament";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.TextBox teamOneTextBox;
    private System.Windows.Forms.Label TournamentNameValue;
    private System.Windows.Forms.TextBox entryFeeTextBox;
    private System.Windows.Forms.Label entryFeeLabel;
    private System.Windows.Forms.ComboBox selectedTeamDropDown;
    private System.Windows.Forms.Label selectTeamLabel;
    private System.Windows.Forms.LinkLabel createNewTeamLabel;
    private System.Windows.Forms.Button addTeamButton;
    private System.Windows.Forms.Button createPrizeButton;
    private System.Windows.Forms.ListBox tournamentPlayerListBox;
    private System.Windows.Forms.Label tournamentPlayersLabel;
    private System.Windows.Forms.Button playerDeleteButton;
    private System.Windows.Forms.Button prizeDeleteButton;
    private System.Windows.Forms.Label prizesLabel;
    private System.Windows.Forms.ListBox prizesListBox;
    private System.Windows.Forms.Button createTournamentButton;
  }
}