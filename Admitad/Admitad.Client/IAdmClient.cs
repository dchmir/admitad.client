// -----------------------------------------------------------------------------------------------------
// Created date: 2018 01 22 13:53
// 
// Solution name: Admitad
// Project name: Admitad.Client
// File name: IAdmClient.cs
// 
// Created by: Дмитрий Чмир
// -----------------------------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using Admitad.Client.DTOs;
using Admitad.Client.DTOs.Users;

namespace Admitad.Client
{
    public interface IAdmClient
    {
        /// <summary>
        /// Получение информации о веб-мастере
        /// </summary>
        /// <returns></returns>
        UserInfoDto GetUserInfo();

        /// <summary>
        /// Получение информации о балансе веб-мастера
        /// </summary>
        /// <returns></returns>
        IList<UserBalanceInfoDto> GetUserBalanceInformation();

        /// <summary>
        /// Возвращает информацию о платежных данных веб-мастера
        /// </summary>
        /// <returns></returns>
        IList<UserBillingInformationDto> GetUserBillingInformation();
    }
}