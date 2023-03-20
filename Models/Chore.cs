using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chore_score.Models;

public class Chore
{
    public Chore(string name, int time, string room, int id )
    {
        Name = name;
        Time = time;
        Room = room;
        Id = id;
    }

    public int Id { get; set; }
    public string Name { get; set;}
    public int Time { get; set; }
    public string Room { get; set; }
    public bool Completed { get; private set; } = false;

    public void CompleteChore()
    {
        this.Completed = true;
    }
}