namespace ConsoleApp.Examples.LinkedNode.WebHistory;

public class TrangWeb
{
    public string Url { get; set; }
    public DateTime ThoiGianDuyet {  get; set; }
    public TrangWeb Truoc { get; set; }
    public TrangWeb Sau { get; set; }

    public TrangWeb(string url = null)
    {
        Url = url;
        ThoiGianDuyet = DateTime.Now;
    }
    public override string ToString()
    {
        return $"[{ThoiGianDuyet:HH:mm:ss}] - {Url}";
    }
}

public class BrowserHistoryManager
{
    private TrangWeb TrangHienTai { get; set; } = new TrangWeb();
    private TrangWeb TrangDauTien { get; set; } = new TrangWeb();
    private TrangWeb TrangCuoiCung { get; set; } = new TrangWeb();

    public BrowserHistoryManager(string trangChu)
    {
        TrangHienTai = new TrangWeb(trangChu);
        TrangDauTien = TrangDauTien;
        TrangCuoiCung = TrangCuoiCung;
    }

    public string UrlHienTai => TrangHienTai.Url ?? "Không có lịch sử";

    public void DuyetTrangMoi(string urlMoi)
    {
        var trangMoi = new TrangWeb(urlMoi);
        if(TrangHienTai == null)
        {
            TrangHienTai = TrangDauTien = TrangCuoiCung = trangMoi;
        }else if(TrangHienTai.Sau != null)
        {
            trangMoi.Truoc = TrangHienTai;
            TrangHienTai.Sau = TrangHienTai = TrangCuoiCung = trangMoi;
        }
        else
        {
            TrangHienTai.Sau = TrangCuoiCung = TrangHienTai = trangMoi;
            trangMoi.Truoc = TrangHienTai;
        }
    }

    public bool QuayLai()
    {
        if(TrangHienTai.Truoc != null)
        {
            TrangHienTai = TrangHienTai.Truoc;
            Console.WriteLine($"<-- Quay lại: {UrlHienTai}");
            return true;
        }
        Console.WriteLine("-> Không thể quay lại được nữa.");
        return false;
    }

    public bool TienLen()
    {
        if(TrangHienTai.Sau != null)
        {
            TrangHienTai = TrangHienTai.Sau;
            Console.WriteLine($"-> Tiến lên {UrlHienTai}");
            return true;
        }
        Console.WriteLine("-> Không thể tiến lên được nữa");
        return false;
    }

    public void InLichSu()
    {
        Console.WriteLine("\n ========= Lịch sử Duyệt Web ==========");
        TrangWeb webHienTai = TrangDauTien;
        while (webHienTai != null)
        {
            string nguoiTao = (webHienTai == TrangHienTai) ? "(Hiện tại)" : "";
            Console.WriteLine($"- {webHienTai.ToString()} {nguoiTao}");
            webHienTai = webHienTai.Sau;
        }
        Console.WriteLine("===================================");
    }
}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        var lichSu = new BrowserHistoryManager("https://trangchu.com");
//        lichSu.DuyetTrangMoi("https://google.com");
//        lichSu.DuyetTrangMoi("https://youtube.com");
//        lichSu.DuyetTrangMoi("https://facebook.com");

//        lichSu.InLichSu();

//        lichSu.QuayLai();
//        lichSu.QuayLai();

//        Console.WriteLine($"\n Trang hiện tại: {lichSu.UrlHienTai}");

//        lichSu.TienLen();
//        lichSu.TienLen();

//        Console.WriteLine("\n ---- Duyệt trang mới khi đang ở giữa");
//        lichSu.QuayLai();
//        lichSu.DuyetTrangMoi("https://newsite.com");

//        lichSu.InLichSu();
//    }
//}
