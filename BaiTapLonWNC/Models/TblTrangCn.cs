using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BaiTapLonWNC.Models;

public partial class TblTrangCn
{
    public int MaTcn { get; set; }
    [DisplayName("Tên của bạn")]
    [Required(ErrorMessage = "Vui lòng nhập tên của bạn")]
    public string NameTcn { get; set; } = null!;

    public int MaUs { get; set; }

    public virtual TblUser MaUsNavigation { get; set; } = null!;

    public virtual ICollection<TblBaiViet> TblBaiViets { get; set; } = new List<TblBaiViet>();

    public virtual ICollection<TblComment> TblComments { get; set; } = new List<TblComment>();

    public virtual ICollection<TblLike> TblLikes { get; set; } = new List<TblLike>();
}
