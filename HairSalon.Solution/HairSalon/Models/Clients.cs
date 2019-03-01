using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
  public class Client
  {
    private string _name;
    private int _id;

    public Client(string name, int id)
    {
      _name = name;
      _id = id;
    }
    public string GetName()
    {
      return name;
    }
    public int GetId()
    {
      return id;
    }
    public 


  }
}
