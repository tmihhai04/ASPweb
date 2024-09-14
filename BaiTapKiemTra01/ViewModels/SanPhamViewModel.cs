namespace BaiTapKiemTra01.ViewModels
{
    public class SanPhamViewModel
    {
        // Thuộc tính tên sản phẩm
        public string TenSanPham { get; set; }

        // Thuộc tính giá bán
        public decimal GiaBan { get; set; }

        // Thuộc tính ảnh mô tả (lưu đường dẫn tới ảnh)
        public string AnhMoTa { get; set; }

        // Constructor mặc định
        public SanPhamViewModel() { }

        // Constructor có tham số
        public SanPhamViewModel(string tenSanPham, decimal giaBan, string anhMoTa)
        {
            TenSanPham = tenSanPham;
            GiaBan = giaBan;
            AnhMoTa = anhMoTa;
    }   }
}
