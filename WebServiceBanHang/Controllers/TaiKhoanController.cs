using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebServiceBanHang.Controllers
{
    public class TaiKhoanController : ApiController
    {
        [HttpGet]
        public TaiKhoan LayTaiKhoan(string TenTaiKhoan, string MatKhau)
        {
            TaiKhoan taikhoan;
            BanHangMiniDataContext context = new BanHangMiniDataContext();
            taikhoan = context.TaiKhoans.FirstOrDefault(x => x.TenTaiKhoan == TenTaiKhoan && x.MatKhau == MatKhau);
            return taikhoan;
        }

        [HttpPost]
        public bool ThemTaiKhoan(string TenTaiKhoan, string MatKhau)
        {
            BanHangMiniDataContext context = new BanHangMiniDataContext();
            try
            {
                TaiKhoan taikhoan = new TaiKhoan();
                taikhoan.TenTaiKhoan = TenTaiKhoan;
                taikhoan.MatKhau = MatKhau;
                // Đánh dấu là sẽ Insert
                context.TaiKhoans.InsertOnSubmit(taikhoan);
                // Xác nhận Insert
                context.SubmitChanges();
                return true;
            }
            catch
            {

            }
            return false;
        }

        [HttpPut]
        public bool CapNhatMatKhau(string TenTaiKhoan, string MatKhau)
        {
            BanHangMiniDataContext context = new BanHangMiniDataContext();
            TaiKhoan taikhoan = context.TaiKhoans.FirstOrDefault(x => x.TenTaiKhoan == TenTaiKhoan);
            try
            {
                if(taikhoan != null)
                {
                    taikhoan.MatKhau = MatKhau;
                    context.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return false;
        }
    }
}
