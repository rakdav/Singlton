using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal interface IDataReader
    {
        void Read();
    }
    class DataBaseReader : IDataReader
    {

        public void Read() => Console.WriteLine("Читаю с БД");
    }
    class FileReader : IDataReader
    {
        public void Read() => Console.WriteLine("Читаю с файла");
    }
    abstract class Sender
    {
        protected IDataReader _reader;
        protected Sender(IDataReader dr) => _reader = dr;
        public void SetDataReader(IDataReader dr) => _reader = dr;
        public abstract void Send();
    }
    class EmailSender : Sender
    {
        public EmailSender(IDataReader dr) : base(dr){}
        public override void Send()
        {
            _reader.Read();
            Console.WriteLine("send by email");
        }
    }
    class TelegramBotSender : Sender
    {
        public TelegramBotSender(IDataReader dr) : base(dr)
        {
        }

        public override void Send()
        {
            _reader.Read();
            Console.WriteLine("send by telegram bot");
        }
    }
}
