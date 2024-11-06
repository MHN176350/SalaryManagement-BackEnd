
using Project.Models;

namespace Project.Repositories.Interfaces
{
    public interface IPositionRepository
    {
        void SavePosition(Position position);
        Position GetPositionById(int id);
        Position GetPositionByName(string name);
        List<Position> GetPositions();
        void UpdatePosition(Position position);
        void DeletePosition(Position position);
    }
}
