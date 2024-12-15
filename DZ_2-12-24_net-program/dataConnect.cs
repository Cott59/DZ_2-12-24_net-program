using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2_12_24_net_program
{
    internal class dataConnect
    {

        // lib.ru [81.176.66.163]
        // ip сервера
        //IPAddress ip = IPAddress.Parse("127.0.0.1");// "10.1.100.164" port сервера
        private IPAddress ip;
        private int _port;// = 3000;

        public void SetIP(string iptmp)
        {
            ip = IPAddress.Parse(iptmp);
        }
        public void SetPort(string port)
        {
            int p = Convert.ToInt32(port);
            _port = p;
        }
        public dataConnect()
        {
            //SetIP("");
            //SetPort("");
        }          
        //if (args.Length >= 2)
        //{
        //    try
        //    {
        //        ip = IPAddress.Parse(args[0]);
        //        _port = Int32.Parse(args[1]);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //}
        public string _answer = string.Empty;// строка для хранения ответа сервера
        public void connectPoint()
        {
            // Конечная точка подключения
            IPEndPoint ep = new IPEndPoint(ip, _port);
            // Сокет: конечная точка подключения, семейство адресов, тип сокета и протокол
            Socket socket = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.IP);
            // строка приветствия для протокола HTTP
            string _promt = "GET\r\n\r\n";
            // массив byte[] для записи ответа
            // будет содержать последовательность байтов,
            // которую требуется декодировать.
            byte[] _buffer = new byte[1024];
            // Число байтов для декодирования
            int _lenght;
            // строка для хранения ответа сервера
            _answer = string.Empty;
            try
            {
                
                // Установка соединения
                socket.Connect(ep);
                // Если соединения прошло успешно
                if (socket.Connected)
                {
                    // отправка строки приветствия,
                    // перекодированной в кодировку ASCII
                    socket.Send(System.Text.Encoding.ASCII.GetBytes(_promt));
                    do
                    {
                        // определяем количество полученных байтов
                        _lenght = socket.Receive(_buffer);
                        // добавляем в строку считанный и декодированный ответ сервера
                        // _buffer - массив байтов, содержащий последовательность байтов,
                        // которую требуется декодировать.
                        // 0 - индекс первого декодируемого байта
                        // _lenght - количество полученных байтов
                          
                        _answer += Encoding.ASCII.GetString(_buffer, 0, _lenght);
                    } while (_lenght > 0);
                }
                else Console.WriteLine("Соединиться не удалось...");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Завершение (отключение) приёма и передачи на сокете
                socket.Shutdown(SocketShutdown.Both);
                // Освобождение связанных ресурсов
                socket.Close();
                //Console.WriteLine(_answer);
            }
        }
        
    }
}
