using System;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Program
    {
        //создаем сокет для сетевого взаимодействия
        static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static void Main(string[] args)
        {
            //подключаем сокет для передачи
            socket.Connect("127.0.0.1", 8091);
            //вводим сообщение
            string message = Console.ReadLine();
            //так как обмен проиходит байтами, преобразуем методом энкодинг нашу строку
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            //отправка сообщения
            socket.Send(buffer);

            Console.ReadLine();

        }

    }
}
