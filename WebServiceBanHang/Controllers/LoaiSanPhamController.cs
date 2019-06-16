using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebServiceBanHang.Controllers
{
    public class LoaiSanPhamController : ApiController
    {
        [HttpGet]
        public List<LoaiSanPham> ListLoaiSanPham()
        {
            List<LoaiSanPham> ListLoaiSanPham;
            ListLoaiSanPham = (new BanHangMiniDataContext()).LoaiSanPhams.ToList();
            ListLoaiSanPham.ForEach(x => x.SanPhams = null);
            return ListLoaiSanPham;
        }
    }
}
