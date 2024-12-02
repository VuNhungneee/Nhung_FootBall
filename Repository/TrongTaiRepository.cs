using Nhung_FootBall.Models;

namespace Nhung_FootBall.Repository
{
    public class TrongTaiRepository : ITrongTaiRepository
    {
        private readonly QlgiaiBongDaKiemTraContext _context;
        public TrongTaiRepository(QlgiaiBongDaKiemTraContext context)
        {
            _context = context;
        }
        public Trongtai Add(Trongtai tentrongtai)
        {
            _context.Trongtais.Add(tentrongtai);
            _context.SaveChanges();
            return tentrongtai;
        }

        public Trongtai Delete(string trongtaiID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Trongtai> GetAllTrongTai()
        {
            return _context.Trongtais;
        }

        public Trongtai GetTrongTai(string trongtaiID)
        {
            return _context.Trongtais.Find(trongtaiID);
        }

        public Trongtai Update(Trongtai tentrongtai)
        {
            _context.Update(tentrongtai);
            _context.SaveChanges();
            return tentrongtai;
        }
    }
}
