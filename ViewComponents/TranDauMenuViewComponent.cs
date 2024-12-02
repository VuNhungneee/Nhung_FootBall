using Microsoft.AspNetCore.Mvc;
using Nhung_FootBall.Repository;
using Nhung_FootBall.Models;
namespace Nhung_FootBall.ViewComponents
{
    public class TranDauMenuViewComponent : ViewComponent
    {
        private readonly ITrongTaiRepository _tentrongtai;
        public TranDauMenuViewComponent(ITrongTaiRepository trongTaiRepository)
        {
            _tentrongtai = trongTaiRepository;
        }
        public IViewComponentResult Invoke()
        {
            var tentrongtai = _tentrongtai.GetAllTrongTai().OrderBy(x => x.HoVaTen);
            return View(tentrongtai);
        }
    }
}
