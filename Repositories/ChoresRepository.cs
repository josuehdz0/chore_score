using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chore_score.Repositories;

public class ChoresRepository
{
    private List<Chore> dbChores = new List<Chore>();

    public ChoresRepository()
    {
        dbChores.Add(new Chore("Dishes",10,"Kitchen", 1));
        dbChores.Add(new Chore("Wash Clothes",10,"Room", 2));
        dbChores.Add(new Chore("Vacuum",10,"Living Room", 3));
    }

    internal Chore CreateChore( Chore choreData)
    {
        choreData.Id = dbChores[dbChores.Count -1].Id +1;
        dbChores.Add(new Chore(choreData.Name , choreData.Time, choreData.Room, choreData.Id));
        return choreData;
    }

    internal List<Chore> GetAllChores()
    {
        return dbChores;
    }

    internal Chore GetOneChore( int id)
    {
        Chore chore = dbChores.Find(chore => chore.Id == id);
        return chore;
    }

    internal bool RemoveChore( int choreId)
    {
        int count = dbChores.RemoveAll(chore => chore.Id == choreId);
        return count > 0;
    }
}
