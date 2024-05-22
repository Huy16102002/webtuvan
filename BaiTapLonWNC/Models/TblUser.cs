using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BaiTapLonWNC.Models;

public partial class TblUser
{
    public int MaUs { get; set; }

    [DisplayName("Tên đăng nhập")]
    [Required(ErrorMessage = "Không được bỏ trống")]
    [StringLength(50)]
    public string UserName { get; set; } = null!;
    [DisplayName("Mật khẩu")]
    [Required(ErrorMessage = "Không được bỏ trống")]
    [StringLength(50)]
    public string Pass { get; set; } = null!;

    public bool LoaiUser { get; set; }

    public virtual ICollection<TblTrangCn> TblTrangCns { get; set; } = new List<TblTrangCn>();
}
