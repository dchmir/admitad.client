// -----------------------------------------------------------------------------------------------------
// Created date: 2018 01 22 14:52
// 
// Solution name: Admitad
// Project name: Admitad.Client
// File name: UserBillingInformationDto.cs
// 
// Created by: Дмитрий Чмир
// -----------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace Admitad.Client.DTOs.Users
{
    /// <summary>
    /// Информация о платежных данных
    /// </summary>
    public class UserBillingInformationDto : BaseDto
    {
        /// <summary>
        /// Город
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Код валюты
        /// </summary>
        [JsonProperty("currency")]
        public string[] Currency { get; set; }

        /// <summary>
        /// Курс конвертации
        /// </summary>
        [JsonProperty("conversion_rate")]
        public string ConversionRate { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// WM-кошелек
        /// </summary>
        [JsonProperty("webmoney_account")]
        public string WebmoneyAccount { get; set; }

        /// <summary>
        /// Тип платежной системы
        /// </summary>
        [JsonProperty("withdrawal_type")]
        public string WithdrawalType { get; set; }

        /// <summary>
        /// Идентификатор
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Почтовый индекс
        /// </summary>
        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        /// <summary>
        /// Электронный адрес PayPal
        /// </summary>
        [JsonProperty("paypal_account")]
        public string PaypalAccount { get; set; }

        /// <summary>
        /// Владелец банковского аккаунта
        /// </summary>
        [JsonProperty("bank_account_owner")]
        public string BankAccountOwner { get; set; }

        /// <summary>
        /// Номер банковского аккаунта
        /// </summary>
        [JsonProperty("bank_account")]
        public string BankAccount { get; set; }

        /// <summary>
        /// Код банка
        /// </summary>
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// Название банка
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// BIC/SWIFT (для некоторых банков)
        /// </summary>
        [JsonProperty("bank_bic")]
        public string BankBic { get; set; }

        /// <summary>
        /// IBAN (для некоторых банков)
        /// </summary>
        [JsonProperty("bank_iban")]
        public string BankIban { get; set; }
    }
}