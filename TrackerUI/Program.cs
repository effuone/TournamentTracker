using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI {
  static class Program {
    /// <summary>
    /// Главная точка входа для приложения.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      TournamentLibrary.GlobalConfig.InitializeConnections(TournamentLibrary.DatabaseType.Sql);
      Application.Run(new CreateTournamentForm());
    }
  }
}
