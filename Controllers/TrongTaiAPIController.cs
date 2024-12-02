using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nhung_FootBall.Models;
using Nhung_FootBall.Models.MatchModels;
namespace Nhung_FootBall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrongTaiAPIController : ControllerBase
    {
        QlgiaiBongDaKiemTraContext db = new QlgiaiBongDaKiemTraContext();
        [HttpGet]
        public IEnumerable<Match> GetAllTranDaus()
        {
            var trandau = (from p in db.Trandaus
                           select new Match
                           {
                               TranDauId = p.TranDauId,
                               NgayThiDau = p.NgayThiDau,
                               Clbnha = p.Clbnha.Trim(),
                               Clbkhach = p.Clbkhach.Trim(),
                               SanVanDongId = p.SanVanDongId,
                               Vong = p.Vong,
                               KetQua = p.KetQua,
                               Anh = p.Anh
                           }).ToList();
            return trandau;
        }
        [HttpGet("{matrongtai}")]
        public IEnumerable<TrandauViewModel> GetMatchByTrongTai(string matrongtai)
        {
            var trandau = (from p in db.Trandaus
                           join clbNha in db.Caulacbos on p.Clbnha equals clbNha.CauLacBoId
                           join clbKhach in db.Caulacbos on p.Clbkhach equals clbKhach.CauLacBoId
                           join Trongtai in db.TrongtaiTrandaus on p.TranDauId equals Trongtai.TranDauId
                           where Trongtai.TrongTaiId == matrongtai 
                           orderby p.TranDauId
                           select new TrandauViewModel
                           {
                               TranDauID = p.TranDauId,
                               Vong = p.Vong,
                               KetQua = p.KetQua,
                               Anh = p.Anh,
                               ClbNha = clbNha.TenClb ?? "Unknown",   // Lấy tên CLB nhà, thêm kiểm tra null
                               ClbKhach = clbKhach.TenClb ?? "Unknown" // Lấy tên CLB khách, thêm kiểm tra null
                           }).ToList();

            return trandau;
        }
    }
}
