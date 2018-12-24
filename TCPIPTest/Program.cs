using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Server
{
    class Program
    {
        //создаем сокет для сетевого взаимодействия
        static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static void Main(string[] args)
        {
            //привязываем сервер к адресу
            socket.Bind(new IPEndPoint(IPAddress.Any, 8091));
            //определяем макс количество подключений
            socket.Listen(5);
            //принимаем подключения
            Socket client = socket.Accept();
            //Узнаем про подключение
            Console.WriteLine("Connected");
            //массив для хранения данных
            byte[] buffer = new byte[1024];
            //Получаем данные
            client.Receive(buffer);
            //выводим на экран, предварительно переведя из байт
            Console.WriteLine(Encoding.ASCII.GetString(buffer));
            Console.ReadLine();
        }
    }
}