using Nhung_FootBall.Models;
namespace Nhung_FootBall.Repository
{
    public interface ITrongTaiRepository
    {
        Trongtai Add(Trongtai tentrongtai);
        Trongtai Update(Trongtai tentrongtai);
        Trongtai Delete(String trongtaiID);
        Trongtai GetTrongTai(String trongtaiID);
        IEnumerable<Trongtai> GetAllTrongTai();
    }
}
