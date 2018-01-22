// -----------------------------------------------------------------------------------------------------
// Created date: 2018 01 22 14:35
// 
// Solution name: Admitad
// Project name: Admitad.Client
// File name: UserInfoDto.cs
// 
// Created by: Дмитрий Чмир
// -----------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace Admitad.Client.DTOs.Users
{
    /// <summary>
    /// Информация о веб-мастере
    /// </summary>
    public class UserInfoDto : BaseDto
    {
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("language")]
        public string Language { get; set; }
        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}