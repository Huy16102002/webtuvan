using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BaiTapLonWNC.Models;

public partial class TblComment
{
    public int MaCm { get; set; }

    public int MaTcn { get; set; }
    [DisplayName("Bình luận")]
    [Required(ErrorMessage = "Không được bỏ trống")]

    public string NoiDung { get; set; } = null!;

    public int MaBv { get; set; }

    public virtual TblBaiViet MaBvNavigation { get; set; } = null!;

    public virtual TblTrangCn MaTcnNavigation { get; set; } = null!;
}
