using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using TournamentLibrary.Models;
using TournamentLibrary.DataAccess;

namespace TournamentLibrary.DataAccess.TextHelpers {
  public static class TextConnectorProcessor {
    public static string FullFilePath(this string fileName) {
      //PrizeModels.csv
      return $"{ConfigurationManager.AppSettings["filePath"]}\\{ fileName }";
    }
    public static List<string> LoadFile(this string file) {
      if (!File.Exists(file)) {
        return new List<string>();
      }
      return File.ReadAllLines(file).ToList();

    }
    public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines) {
      List<PrizeModel> output = new List<PrizeModel>();
      foreach (var line in lines) {
        string[] cols = line.Split(',');
        var model = new PrizeModel();
        model.Id = int.Parse(cols[0]);
        model.PlaceNumber = int.Parse(cols[1]);
        model.PlaceName = cols[2];
        model.PrizeAmount = decimal.Parse(cols[3]);
        model.PrizePercentage = double.Parse(cols[4]);
        output.Add(model);
      }
      return output;
    }
    public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName) {
      List<TeamModel> output = new List<TeamModel>();
      List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPeopleModels();
      foreach (var line in lines) {
        string[] cols = line.Split(',');
        var model = new TeamModel {
          Id = int.Parse(cols[0]),
          TeamName = cols[1]
        };
        string[] personIds = cols[2].Split('|');
        foreach (string id in personIds) {
          model.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).FirstOrDefault());
        }

        output.Add(model);
      }
      return output;
    }
    public static void SaveToTeamFile(this List<TeamModel> models, string fileName) {
      List<string> lines = new List<string>();
      foreach(var team in models) {
        lines.Add($"{ team.Id }, { team.TeamName }, { ConvertPeopleListToString(team.TeamMembers) }");
      }
      File.WriteAllLines(fileName.FullFilePath(), lines);
    }
    private static string ConvertPeopleListToString(List<PersonModel> people) {
      string output = "";
      if(people.Count == 0) {
        return "";
      }
      foreach (var item in people) {
        output += $"{ item.Id }|";
      }
      output = output.Substring(0, output.Length - 1);
      return output;
    }
    public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName) {
      List<string> lines = new List<string>();
      foreach (var p in models) {
        lines.Add($"{p.Id}, {p.PlaceNumber}, {p.PlaceName}, {p.PrizeAmount}, {p.PrizePercentage}");
      }
      File.WriteAllLines(fileName.FullFilePath(), lines);
    }
    public static List<PersonModel> ConvertToPeopleModels(this List<string> lines) {
      List<PersonModel> output = new List<PersonModel>();
      foreach (var line in lines) {
        string[] cols = line.Split(',');
        var model = new PersonModel();
        model.Id = int.Parse(cols[0]);
        model.FirstName = cols[1];
        model.LastName = cols[2];
        model.EmailAddress = cols[3];
        model.CellPhoneNumber = cols[4];
        output.Add(model);
      }
      return output;
    }
    public static void SaveToPeopleFile(this List<PersonModel> models, string fileName) {
      List<string> lines = new List<string>();
      foreach (var p in models) {
        lines.Add($"{ p.Id },{ p.FirstName },{ p.LastName },{ p.EmailAddress },{ p.CellPhoneNumber }");
      }
      File.WriteAllLines(fileName.FullFilePath(), lines);
    }
  }
}
