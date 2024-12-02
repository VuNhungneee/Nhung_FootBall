using System;
using System.Collections.Generic;

namespace Nhung_FootBall.Models;

public class TrandauViewModel
{
    public string TranDauID { get; set; }
    public int? Vong { get; set; }
    public string KetQua { get; set; }
    public string Anh { get; set; }
    public string ClbNha { get; set; }   // Đảm bảo thuộc tính này tồn tại
    public string ClbKhach { get; set; } // Đảm bảo thuộc tính này tồn tại
}
