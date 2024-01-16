using Microsoft.AspNetCore.Mvc;
using ArtistBiography.Models;
using System.Diagnostics;

namespace ArtistBiography.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private Picture[] pictures =
        {
            new("ѳ�� 1881 p.","���������� � ���� �������-������, �������","https://upload.wikimedia.org/wikipedia/commons/5/5a/Van_Gogh_1881-04%2C_Etten_-_Sower_%28after_Millet%29_F_830_JH_1.jpg"),
            new("������� ���� 1883 p.","���������� � ����������� ������ ���������, ���������","https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Bulb_Fields.jpg/1280px-Bulb_Fields.jpg"),
            new("���� 1884 p.","���������� � ���� ��� ����, ���������","https://upload.wikimedia.org/wikipedia/commons/thumb/c/c4/Vincent_Willem_van_Gogh_139.jpg/1280px-Vincent_Willem_van_Gogh_139.jpg"),
            new("��������� � ���볺� 1885 p.","���������� � ���� ��� ����, ���������","https://upload.wikimedia.org/wikipedia/commons/3/3e/Still_life_with_Bible.jpg"),
            new("������ ��������� 1885 p.","���������� � ���� ��� ����, ���������","https://upload.wikimedia.org/wikipedia/commons/thumb/a/af/Vincent_Van_Gogh_-_The_Potato_Eaters.png/1280px-Vincent_Van_Gogh_-_The_Potato_Eaters.png"),
            new("����� � �������� 1886 p.","���������� � ���� ��� ����, ���������","https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/Skull_with_a_Burning_Cigarette.jpg/800px-Skull_with_a_Burning_Cigarette.jpg"),
            new("�������� 1886 p.","���������� � ���� ��� ����, ���������","https://upload.wikimedia.org/wikipedia/commons/thumb/2/26/Van_Gogh_-_Ein_Paar_Schuhe.jpeg/1280px-Van_Gogh_-_Ein_Paar_Schuhe.jpeg"),
            new("������� 1887 p.","���������� � ���� �'����, �����","https://upload.wikimedia.org/wikipedia/commons/e/eb/L%27italiana.jpg"),
            new("������� ������� 1887 p.","���������� � ���� ��� ����, ���������","https://upload.wikimedia.org/wikipedia/commons/thumb/5/5f/Vincent_van_Gogh_-_In_the_caf%C3%A9_-_Agostina_Segatori_in_Le_Tambourin_-_Google_Art_Project_2.jpg/800px-Vincent_van_Gogh_-_In_the_caf%C3%A9_-_Agostina_Segatori_in_Le_Tambourin_-_Google_Art_Project_2.jpg"),
            new("������ ��� ���� 1888 p.","���������� � ������������� ���������� ����, �����������","https://upload.wikimedia.org/wikipedia/commons/thumb/3/38/Van_Gogh_-_Allee_bei_Arles_mit_H%C3%A4usern.jpeg/800px-Van_Gogh_-_Allee_bei_Arles_mit_H%C3%A4usern.jpeg"),
            new("��������� 1888 p.","���������� � ���� ���� ϳ��������, ������","https://upload.wikimedia.org/wikipedia/commons/thumb/b/b4/Vincent_Willem_van_Gogh_128.jpg/800px-Vincent_Willem_van_Gogh_128.jpg"),
            new("����� ����� ��� �������� 1888 p.","���������� � ���� ��� ����, ���������","https://upload.wikimedia.org/wikipedia/commons/thumb/4/4e/Sunset_at_Montmajour_1888_Van_Gogh.jpg/1280px-Sunset_at_Montmajour_1888_Van_Gogh.jpg"),
            new("������� � ��� 1888 p.","���������� � ���� ��� ����, ���������","https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Vincent_Willem_van_Gogh_137.jpg/1280px-Vincent_Willem_van_Gogh_137.jpg"),
            new("����������� 1889 p.","���������� � ���� �'����, �����","https://upload.wikimedia.org/wikipedia/commons/thumb/6/6b/SelbstPortrait_VG2.jpg/800px-SelbstPortrait_VG2.jpg")
        };
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Information()
        {
            return View();
        }

        public IActionResult Achievement()
        {
            return View();
        }
       
        public IActionResult Gallery()
        {
            return View(pictures);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
