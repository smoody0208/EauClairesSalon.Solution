using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSalon.Models 
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    
  }
}