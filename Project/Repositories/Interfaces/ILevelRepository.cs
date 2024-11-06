
using Project.Models;

namespace Project.Repositories.Interfaces
{
    public interface ILevelRepository
    {
        void SaveLevel(Level level);
        Level GetLevelById(int id);
        Level GetLevelByName(string name);
        List<Level> GetLevels();
        void UpdateLevel(Level level);
        void DeleteLevel(Level level);
    }
}
