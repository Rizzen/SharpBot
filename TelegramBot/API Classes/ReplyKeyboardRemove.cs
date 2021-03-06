﻿using Newtonsoft.Json;

namespace TelegramBot.API_Classes
{
    /// <summary>
    /// Upon receiving a message with this object, Telegram clients will remove the current custom keyboard and display the default letter-keyboard. By default, custom keyboards are displayed until a new keyboard is sent by a bot. An exception is made for one-time keyboards that are hidden immediately after the user presses a button (see ReplyKeyboardMarkup).
    /// </summary>
    internal class ReplyKeyboardRemove
    {
        /// <summary>
        /// Requests clients to remove the custom keyboard (user will not be able to summon this keyboard; if you want to hide the keyboard from sight but keep it accessible, use one_time_keyboard in ReplyKeyboardMarkup)
        /// </summary>
        [JsonProperty("remove_keyboard")]
        internal bool RemoveKeyboard { get; set; }

        /// <summary>
        /// Optional. Use this parameter if you want to remove the keyboard for specific users only. Targets: 1) users that are @mentioned in the text of the Message object; 2) if the bot's message is a reply (has reply_to_message_id), sender of the original message.
        /// </summary>
        [JsonProperty("selective")]
        internal bool Selective { get; set; }
    }
}
