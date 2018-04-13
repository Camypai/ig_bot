using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;

namespace IlyaGorshkov_bot
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static TelegramBotClient bot = new TelegramBotClient("568728620:AAGeSaK44Dwl8VRA4zYtUKYBygiidZuI92M");

        static void Main(string[] args)
        {
            var me = bot.GetMeAsync().Result;

            logger.Info(me.FirstName);
            Console.WriteLine(me.FirstName);

            bot.OnMessage += BotOnOnMessage;

            bot.StartReceiving();
            Console.WriteLine("Start bot listening");
            Console.ReadLine();
            bot.StopReceiving();
        }

        private static void BotOnOnMessage(object sender, MessageEventArgs messageEventArgs)
        {
            var message = messageEventArgs.Message;

            switch (message.Type)
            {
                case MessageType.UnknownMessage:
                    break;
                case MessageType.TextMessage:
                    Console.WriteLine(message.Text);
                    break;
                case MessageType.PhotoMessage:
                    break;
                case MessageType.AudioMessage:
                    break;
                case MessageType.VideoMessage:
                    break;
                case MessageType.VoiceMessage:
                    break;
                case MessageType.DocumentMessage:
                    break;
                case MessageType.StickerMessage:
                    break;
                case MessageType.LocationMessage:
                    break;
                case MessageType.ContactMessage:
                    break;
                case MessageType.ServiceMessage:
                    break;
                case MessageType.VenueMessage:
                    break;
                case MessageType.GameMessage:
                    break;
                case MessageType.VideoNoteMessage:
                    break;
                case MessageType.Invoice:
                    break;
                case MessageType.SuccessfulPayment:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
