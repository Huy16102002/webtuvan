using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BaiTapLonWNC.Models;

public partial class TblBaiViet
{
    public int MaBv { get; set; }
    [DisplayName("Tiêu đề")]
    [Required(ErrorMessage = "Không được bỏ trống")]
    [StringLength(225)]
    public string TieuDe { get; set; } = null!;
    [DisplayName("Nội dung")]
    [Required(ErrorMessage = "Không được bỏ trống")]
    [StringLength(9999)]
    public string NoiDung { get; set; } = null!;
    [DisplayName("Ảnh")]
    [StringLength(999)]
    public string? LinkAnh { get; set; }

    public int? SoLike { get; set; }

    public int? SoComment { get; set; }
    [DisplayName("Chủ đề")]
    public int MaChuDe { get; set; }

    public int MaTcn { get; set; }

    public virtual TblChuDe MaChuDeNavigation { get; set; } = null!;

    public virtual TblTrangCn MaTcnNavigation { get; set; } = null!;

    public virtual ICollection<TblComment> TblComments { get; set; } = new List<TblComment>();

    public virtual ICollection<TblLike> TblLikes { get; set; } = new List<TblLike>();
}
