using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibAPI
    {
        public LibAPI() { }
        public async Task<string> getData(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();
                        //dùng jsonString Convert sang model
                        // cách convert  List<KhachHangModel> lst = JsonConvert.DeserializeObject<List<KhachHangModel>>(json);
                        return jsonString;
                    }
                    else
                    {
                        Console.WriteLine($"Lỗi: {response.StatusCode}");
                        return "";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                    return "";
                }
            }
        }
        public async Task<int> Update(object model, string url)
        {
            try
            {
                HttpClient client = new HttpClient();
                string json = JsonConvert.SerializeObject(model);
                //phương thưc
                HttpMethod method = new HttpMethod("PUT");
                HttpRequestMessage request = new HttpRequestMessage(method, url)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    return 1;
                }
                else { return 0; }
                return 0;
            }
            catch { return 0; }
        }
        public async Task<int> insertData(object model, string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string jsonData = JsonConvert.SerializeObject(model);
                    
                    // Gửi yêu cầu HTTP POST đến API
                    HttpResponseMessage response = await client.PostAsync(url, new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json"));

                    // Kiểm tra xem yêu cầu đã thành công (status code 200) hay không
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Dữ liệu đã được thêm thành công vào cơ sở dữ liệu.");
                        return 1;
                    }
                    else
                    {
                        Console.WriteLine($"Lỗi: {response.StatusCode}");
                        return 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                    return 0;
                }
            }
        }
        public async Task<int> deleteData(string url, string id) //nếu có nhiều hơn overload thêm nữa
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Địa chỉ URL của API mà bạn muốn sử dụng để xóa dữ liệu
                    string apiUrl = url;

                    // Thêm các tham số trên URL để xác định đối tượng hoặc tài nguyên cần xóa
                    // Ví dụ, xóa đối tượng có mã là "KH001"
                    string objectIdToDelete = id;
                    apiUrl += $"/{objectIdToDelete}";                   
                    // Gửi yêu cầu HTTP DELETE đến API
                    HttpResponseMessage response = await client.DeleteAsync(apiUrl);

                    // Kiểm tra xem yêu cầu đã thành công (status code 200) hay không
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Dữ liệu đã được xóa thành công.");
                        return 1;
                    }
                    else
                    {
                        Console.WriteLine($"Lỗi: {response.StatusCode}");
                        return 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                    return 0;
                }
            }
        }
    }
}
