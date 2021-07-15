
namespace TrackerUI {
  partial class TournamentViewerForm {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent() {
      this.headerLabel = new System.Windows.Forms.Label();
      this.tournamentName = new System.Windows.Forms.Label();
      this.roundLabel = new System.Windows.Forms.Label();
      this.roundDropDown = new System.Windows.Forms.ComboBox();
      this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
      this.matchupListBox = new System.Windows.Forms.ListBox();
      this.teamOneName = new System.Windows.Forms.Label();
      this.teamOneScoreLabel = new System.Windows.Forms.Label();
      this.teamOneTextBox = new System.Windows.Forms.TextBox();
      this.teamTwoTextBox = new System.Windows.Forms.TextBox();
      this.teamTwoScoreLabel = new System.Windows.Forms.Label();
      this.teamTwoName = new System.Windows.Forms.Label();
      this.versusLabel = new System.Windows.Forms.Label();
      this.scoreButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // headerLabel
      // 
      this.headerLabel.AutoSize = true;
      this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.headerLabel.Location = new System.Drawing.Point(12, 9);
      this.headerLabel.Name = "headerLabel";
      this.headerLabel.Size = new System.Drawing.Size(220, 50);
      this.headerLabel.TabIndex = 0;
      this.headerLabel.Text = "Tournament:";
      // 
      // tournamentName
      // 
      this.tournamentName.AutoSize = true;
      this.tournamentName.Font = new System.Drawing.Font("Segoe UI Semilight", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.tournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.tournamentName.Location = new System.Drawing.Point(220, 9);
      this.tournamentName.Name = "tournamentName";
      this.tournamentName.Size = new System.Drawing.Size(152, 50);
      this.tournamentName.TabIndex = 1;
      this.tournamentName.Text = "<none>";
      // 
      // roundLabel
      // 
      this.roundLabel.AutoSize = true;
      this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.roundLabel.Location = new System.Drawing.Point(14, 72);
      this.roundLabel.Name = "roundLabel";
      this.roundLabel.Size = new System.Drawing.Size(94, 37);
      this.roundLabel.TabIndex = 2;
      this.roundLabel.Text = "Round";
      // 
      // roundDropDown
      // 
      this.roundDropDown.FormattingEnabled = true;
      this.roundDropDown.Location = new System.Drawing.Point(114, 71);
      this.roundDropDown.Name = "roundDropDown";
      this.roundDropDown.Size = new System.Drawing.Size(223, 38);
      this.roundDropDown.TabIndex = 3;
      // 
      // unplayedOnlyCheckbox
      // 
      this.unplayedOnlyCheckbox.AutoSize = true;
      this.unplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.unplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.unplayedOnlyCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(118, 112);
      this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
      this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(209, 41);
      this.unplayedOnlyCheckbox.TabIndex = 4;
      this.unplayedOnlyCheckbox.Text = "Unplayed Only";
      this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
      // 
      // matchupListBox
      // 
      this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.matchupListBox.FormattingEnabled = true;
      this.matchupListBox.ItemHeight = 30;
      this.matchupListBox.Location = new System.Drawing.Point(21, 159);
      this.matchupListBox.Name = "matchupListBox";
      this.matchupListBox.Size = new System.Drawing.Size(316, 302);
      this.matchupListBox.TabIndex = 5;
      // 
      // teamOneName
      // 
      this.teamOneName.AutoSize = true;
      this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.teamOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.teamOneName.Location = new System.Drawing.Point(381, 181);
      this.teamOneName.Name = "teamOneName";
      this.teamOneName.Size = new System.Drawing.Size(165, 37);
      this.teamOneName.TabIndex = 6;
      this.teamOneName.Text = "<team one>";
      // 
      // teamOneScoreLabel
      // 
      this.teamOneScoreLabel.AutoSize = true;
      this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.teamOneScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.teamOneScoreLabel.Location = new System.Drawing.Point(383, 223);
      this.teamOneScoreLabel.Name = "teamOneScoreLabel";
      this.teamOneScoreLabel.Size = new System.Drawing.Size(82, 37);
      this.teamOneScoreLabel.TabIndex = 7;
      this.teamOneScoreLabel.Text = "Score";
      // 
      // teamOneTextBox
      // 
      this.teamOneTextBox.Location = new System.Drawing.Point(467, 226);
      this.teamOneTextBox.Name = "teamOneTextBox";
      this.teamOneTextBox.Size = new System.Drawing.Size(100, 35);
      this.teamOneTextBox.TabIndex = 8;
      // 
      // teamTwoTextBox
      // 
      this.teamTwoTextBox.Location = new System.Drawing.Point(467, 414);
      this.teamTwoTextBox.Name = "teamTwoTextBox";
      this.teamTwoTextBox.Size = new System.Drawing.Size(100, 35);
      this.teamTwoTextBox.TabIndex = 11;
      // 
      // teamTwoScoreLabel
      // 
      this.teamTwoScoreLabel.AutoSize = true;
      this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.teamTwoScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.teamTwoScoreLabel.Location = new System.Drawing.Point(383, 409);
      this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
      this.teamTwoScoreLabel.Size = new System.Drawing.Size(82, 37);
      this.teamTwoScoreLabel.TabIndex = 10;
      this.teamTwoScoreLabel.Text = "Score";
      // 
      // teamTwoName
      // 
      this.teamTwoName.AutoSize = true;
      this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.teamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.teamTwoName.Location = new System.Drawing.Point(381, 367);
      this.teamTwoName.Name = "teamTwoName";
      this.teamTwoName.Size = new System.Drawing.Size(165, 37);
      this.teamTwoName.TabIndex = 9;
      this.teamTwoName.Text = "<team two>";
      // 
      // versusLabel
      // 
      this.versusLabel.AutoSize = true;
      this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.versusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.versusLabel.Location = new System.Drawing.Point(436, 301);
      this.versusLabel.Name = "versusLabel";
      this.versusLabel.Size = new System.Drawing.Size(70, 37);
      this.versusLabel.TabIndex = 12;
      this.versusLabel.Text = "-VS-";
      // 
      // scoreButton
      // 
      this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.scoreButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.scoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.scoreButton.Location = new System.Drawing.Point(512, 300);
      this.scoreButton.Name = "scoreButton";
      this.scoreButton.Size = new System.Drawing.Size(96, 42);
      this.scoreButton.TabIndex = 13;
      this.scoreButton.Text = "Score";
      this.scoreButton.UseVisualStyleBackColor = true;
      // 
      // TournamentUI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(674, 559);
      this.Controls.Add(this.scoreButton);
      this.Controls.Add(this.versusLabel);
      this.Controls.Add(this.teamTwoTextBox);
      this.Controls.Add(this.teamTwoScoreLabel);
      this.Controls.Add(this.teamTwoName);
      this.Controls.Add(this.teamOneTextBox);
      this.Controls.Add(this.teamOneScoreLabel);
      this.Controls.Add(this.teamOneName);
      this.Controls.Add(this.matchupListBox);
      this.Controls.Add(this.unplayedOnlyCheckbox);
      this.Controls.Add(this.roundDropDown);
      this.Controls.Add(this.roundLabel);
      this.Controls.Add(this.tournamentName);
      this.Controls.Add(this.headerLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "TournamentUI";
      this.Text = "Tournament Viewer";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.Label tournamentName;
    private System.Windows.Forms.Label roundLabel;
    private System.Windows.Forms.ComboBox roundDropDown;
    private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
    private System.Windows.Forms.ListBox matchupListBox;
    private System.Windows.Forms.Label teamOneName;
    private System.Windows.Forms.Label teamOneScoreLabel;
    private System.Windows.Forms.TextBox teamOneTextBox;
    private System.Windows.Forms.TextBox teamTwoTextBox;
    private System.Windows.Forms.Label teamTwoScoreLabel;
    private System.Windows.Forms.Label teamTwoName;
    private System.Windows.Forms.Label versusLabel;
    private System.Windows.Forms.Button scoreButton;
  }
}

