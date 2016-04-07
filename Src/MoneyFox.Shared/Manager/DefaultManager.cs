﻿using System.Collections.ObjectModel;
using System.Linq;
using MoneyFox.Shared.DataAccess;
using MoneyFox.Shared.Interfaces;
using MoneyFox.Shared.Model;

namespace MoneyFox.Shared.Manager
{
    public class DefaultManager : IDefaultManager
    {
        private readonly IAccountRepository accountRepository;
        private readonly SettingDataAccess settings;

        public DefaultManager(IAccountRepository accountRepository, SettingDataAccess settings)
        {
            this.accountRepository = accountRepository;
            this.settings = settings;
        }

        public Account GetDefaultAccount()
        {
            if (accountRepository.Selected != null)
            {
                return accountRepository.Selected;
            }

            if (accountRepository.Data == null)
            {
                accountRepository.Data = new ObservableCollection<Account>();
            }

            if (accountRepository.Data.Any() && settings.DefaultAccount != -1)
            {
                return accountRepository.Data.FirstOrDefault(x => x.Id == settings.DefaultAccount);
            }

            return accountRepository.Data.FirstOrDefault();
        }
    }
}