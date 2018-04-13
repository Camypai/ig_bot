using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace IlyaGorshkov_bot
{
    internal interface IBot
    {
        Task<User> GetMeAsync();
        void OnMessage(EventHandler<MessageEventArgs> eventMessage);
        void OnReceiveError(EventHandler<ReceiveErrorEventArgs> OnReceiveError);
        void OnCallBackQuery(EventHandler<CallbackQueryEventArgs> OnCallBackQuery);
        void StartReceiving();
        void StopReceiving();
        Task<Message> SendTextMessageAsync(long chatId, string message);
        Task<Message> SendTextMessageAsync(long chatId, string message, IReplyMarkup replyMarkup);

        Task<bool> AnswerCallbackQueryAsync(
            string callbackQueryId,
            string text = null,
            bool showAlert = false,
            string url = null,
            int cacheTime = 0,
            CancellationToken cancellationToken = default(CancellationToken)
        );
        Task<File> GetFileAsync(string fileId);
    }
}
