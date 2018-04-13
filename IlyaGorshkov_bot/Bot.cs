using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace IlyaGorshkov_bot
{
    public class Bot : IBot
    {
        public TelegramBotClient BotClient { get; set; }

        public Bot(string token)
        {
            BotClient = new TelegramBotClient(token);
        }

        public void OnCallBackQuery(EventHandler<CallbackQueryEventArgs> OnCallBackQuery)
        {
            BotClient.OnCallbackQuery += OnCallBackQuery;
        }

        public void StartReceiving()
        {
            BotClient.StartReceiving();
        }

        public void StopReceiving()
        {
            BotClient.StopReceiving();
        }

        public async Task<Message> SendTextMessageAsync(
            long chatId,
            string message
        )
        {
            return await BotClient.SendTextMessageAsync(chatId, message);
        }

        public async Task<Message> SendTextMessageAsync(
            long chatId,
            string message,
            IReplyMarkup replyMarkup = null
            )
        {
            return await BotClient.SendTextMessageAsync(chatId, message, replyMarkup: replyMarkup);
        }

        public async Task<bool> AnswerCallbackQueryAsync(
            string callbackQueryId,
            string text = null,
            bool showAlert = false,
            string url = null,
            int cacheTime = 0,
            CancellationToken cancellationToken = default(CancellationToken)
            )
        {
            return await BotClient.AnswerCallbackQueryAsync(callbackQueryId, text, showAlert, url, cacheTime, cancellationToken);
        }

        public void OnMessage(EventHandler<MessageEventArgs> eventMessage)
        {
            BotClient.OnMessage += eventMessage;
        }

        public void OnReceiveError(EventHandler<ReceiveErrorEventArgs> OnReceiveError)
        {
            BotClient.OnReceiveError += OnReceiveError;
        }

        public async Task<File> GetFileAsync(string fileId)
        {
            return await BotClient.GetFileAsync(fileId);
        }

        public async Task<User> GetMeAsync()
        {
            return await BotClient.GetMeAsync();
        }
    }
}
