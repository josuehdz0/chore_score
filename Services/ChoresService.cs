using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chore_score.Services;

public class ChoresService
{

private readonly ChoresRepository _repo;

public ChoresService( ChoresRepository repo)
{
_repo = repo;
}

public List<Chore> GetAllChores()
{
    return _repo.GetAllChores();
}

  internal Chore CompleteChore(int id)
  {
    Chore chore = this.GetOneChore(id);
    chore.CompleteChore();
    return chore;
  }

  internal Chore CreateChore(Chore choreData)
  {
    Chore core = _repo.CreateChore(choreData);
    return choreData;
  }

  internal Chore GetOneChore(int id)
  {
    Chore chore = _repo.GetOneChore(id);
    if (chore == null) throw new Exception($"No Chore at id:{id}");
    return chore;
  }

  internal string RemoveChore(int choreId)
  {
    Chore chore = this.GetOneChore(choreId);
    bool result = _repo.RemoveChore(choreId);
    if (!result) throw new Exception("didnt delete any chores");
    return $"{chore.Name} has been removed";
  }
}



