
using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Tamagotchi
  {
    private string _tamaName;
    private int _food;
    private int _stage;
    private int _attention;
    private bool _isSleep;
    private bool _isDead;
    // private static List<Place> places = new List<Place> ();

    public Tamagotchi (string tamaName, int food, int stage, int attention, bool isSleep, bool isDead)
    {
      _tamaName = tamaName;
      _food = food;
      _stage = stage;
      _attention = attention;
      _isSleep = isSleep;
      _isDead = isDead;
      // places.Add(this);
    }
    public void SetTamaName(string tamaName)
    {
      _tamaName = tamaName;
    }
    public string GetTamaName()
    {
      return _tamaName;
    }
    public void SetFood(int food)
    {
      _food = food;
    }
    public int GetFood()
    {
      return _food;
    }
    public void SetStage(int stage)
    {
      _stage = stage;
    }
    public int GetStage()
    {
      return _stage;
    }
    public void SetAttention(int attention)
    {
      _attention = attention;
    }
    public int GetAttention()
    {
      return _attention;
    }
    public void SetIsSleep(bool isSleep)
    {
      _isSleep = isSleep;
    }
    public bool GetIsSleep()
    {
      return _isSleep;
    }
    public void SetIsDead(bool isDead)
    {
      _isDead = isDead;
    }
    public bool GetIsDead()
    {
      return _isDead;
    }
  }
}
