// -----------------------------------------------------------------------------------------------------
// Created date: 2018 01 22 14:42
// 
// Solution name: Admitad
// Project name: Admitad.Client
// File name: UserBalanceInfoDto.cs
// 
// Created by: Дмитрий Чмир
// -----------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace Admitad.Client.DTOs.Users
{
    /// <summary>
    /// Информация о балансе веб-мастера
    /// </summary>
    public class UserBalanceInfoDto : BaseDto
    {
        /// <summary>
        /// Код валюты
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Сумма баланса
        /// </summary>
        [JsonProperty("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// В обработке
        /// </summary>
        [JsonProperty("processing")]
        public string Processing { get; set; }

        /// <summary>
        /// Заработок за сегодня
        /// </summary>
        [JsonProperty("today")]
        public string Today { get; set; }

        /// <summary>
        /// Задержаны
        /// </summary>
        [JsonProperty("stalled")]
        public string Stalled { get; set; }
    }
}