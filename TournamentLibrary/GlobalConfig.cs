using System;
using System.Collections.Generic;
using System.Text;
using TournamentLibrary.Models;
using TournamentLibrary.DataAccess;
using System.Configuration;

namespace TournamentLibrary {
  public static class GlobalConfig {
    public static IDataConnection Connection { get; private set; }
    public static void InitializeConnections(DatabaseType db) {
      if (db == DatabaseType.Sql) {
        SqlConnector sql = new SqlConnector();
        Connection = sql;
      }
      else if (db == DatabaseType.TextFile) {
        TextConnector text = new TextConnector();
        Connection = text;
      }
    }
    public static string CnnString (string name) {
      return ConfigurationManager.ConnectionStrings[name].ConnectionString;
    }
  }
}
