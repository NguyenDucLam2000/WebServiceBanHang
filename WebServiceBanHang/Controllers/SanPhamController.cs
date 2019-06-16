using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebServiceBanHang.Controllers
{
    public class SanPhamController : ApiController
    {
        [HttpGet]
        public List<SanPham> ListSanPham()
        {
            List<SanPham> ListSanPham;
            ListSanPham = (new BanHangMiniDataContext()).SanPhams.ToList();
            //ListSanPham.ForEach(x => x.LoaiSanPham = null);

            return ListSanPham;
        }
        [HttpGet]
        public List<SanPham> LayListSanPhamQuaMaLoaiSanPham(int MaLoaiSanPham)
        {
            List<SanPham> ListSanPham;
            ListSanPham = (new BanHangMiniDataContext()).SanPhams.Where(x => x.MaLoaiSanPham == MaLoaiSanPham).ToList();
            return ListSanPham;
        }
    }
}
