
namespace TrackerUI {
  partial class TournamentDashboardForm {
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
      this.TournamentDashboardLabel = new System.Windows.Forms.Label();
      this.loadTournamentButton = new System.Windows.Forms.Button();
      this.loadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
      this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
      this.createTournamentButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // TournamentDashboardLabel
      // 
      this.TournamentDashboardLabel.AutoSize = true;
      this.TournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.TournamentDashboardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.TournamentDashboardLabel.Location = new System.Drawing.Point(213, 45);
      this.TournamentDashboardLabel.Name = "TournamentDashboardLabel";
      this.TournamentDashboardLabel.Size = new System.Drawing.Size(396, 50);
      this.TournamentDashboardLabel.TabIndex = 13;
      this.TournamentDashboardLabel.Text = "Tournament Dashboard";
      // 
      // loadTournamentButton
      // 
      this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.loadTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.loadTournamentButton.Location = new System.Drawing.Point(309, 197);
      this.loadTournamentButton.Name = "loadTournamentButton";
      this.loadTournamentButton.Size = new System.Drawing.Size(205, 42);
      this.loadTournamentButton.TabIndex = 23;
      this.loadTournamentButton.Text = "Load Tournament";
      this.loadTournamentButton.UseVisualStyleBackColor = true;
      // 
      // loadExistingTournamentDropDown
      // 
      this.loadExistingTournamentDropDown.FormattingEnabled = true;
      this.loadExistingTournamentDropDown.Location = new System.Drawing.Point(236, 150);
      this.loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
      this.loadExistingTournamentDropDown.Size = new System.Drawing.Size(351, 38);
      this.loadExistingTournamentDropDown.TabIndex = 22;
      // 
      // loadExistingTournamentLabel
      // 
      this.loadExistingTournamentLabel.AutoSize = true;
      this.loadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.loadExistingTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.loadExistingTournamentLabel.Location = new System.Drawing.Point(250, 104);
      this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
      this.loadExistingTournamentLabel.Size = new System.Drawing.Size(322, 37);
      this.loadExistingTournamentLabel.TabIndex = 21;
      this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
      // 
      // createTournamentButton
      // 
      this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.createTournamentButton.Location = new System.Drawing.Point(251, 248);
      this.createTournamentButton.Name = "createTournamentButton";
      this.createTournamentButton.Size = new System.Drawing.Size(321, 86);
      this.createTournamentButton.TabIndex = 34;
      this.createTournamentButton.Text = "Create Tournament";
      this.createTournamentButton.UseVisualStyleBackColor = true;
      // 
      // TournamentDashboardForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(827, 370);
      this.Controls.Add(this.createTournamentButton);
      this.Controls.Add(this.loadTournamentButton);
      this.Controls.Add(this.loadExistingTournamentDropDown);
      this.Controls.Add(this.loadExistingTournamentLabel);
      this.Controls.Add(this.TournamentDashboardLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "TournamentDashboardForm";
      this.Text = "Tournament Dashboard";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label TournamentDashboardLabel;
    private System.Windows.Forms.Button loadTournamentButton;
    private System.Windows.Forms.ComboBox loadExistingTournamentDropDown;
    private System.Windows.Forms.Label loadExistingTournamentLabel;
    private System.Windows.Forms.Button createTournamentButton;
  }
}