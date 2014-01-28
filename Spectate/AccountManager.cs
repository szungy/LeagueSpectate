using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spectate
{
    class AccountManager
    {
        private static List<Account> Accounts = new List<Account>();

        public static void AddAccount(Account account)
        {
            if(!IsInAccounts(account))
                Accounts.Add(account);
        }

        public static void RemoveAccount(Account account)
        {
            foreach (Account accountT in Accounts)
                if (accountT.Name == account.Name && accountT.Region == account.Region)
                    Accounts.Remove(accountT);
        }

        public static Boolean IsInAccounts(Account account)
        {
            foreach (Account accountT in Accounts)
                if (accountT.Name == account.Name && accountT.Region == account.Region)
                    return true;

            return false;
        }

        public static void ClearAccountsList()
        {
            Accounts.Clear();
        }

        public static Boolean HaveAccountForRegion(Region region)
        {
            foreach (Account accountT in Accounts)
                if (accountT.Region == region)
                    return true;

            return false;
        }

        public static void Load(List<Account> accountsList, Boolean clear)
        {
            if(clear)
                ClearAccountsList();

            Accounts.AddRange(accountsList);
        }

        public static Account GetAccount(Region region)
        {
            foreach (Account account in Accounts)
                if (account.Region == region)
                    return account;

            return null;
        }

        public static List<Account> GetAccounts()
        {
            return Accounts;
        }

        public static List<String> GetRegions()
        {
            List<String> regions = new List<String>();

            foreach (var region in Enum.GetValues(typeof(Region)))
                regions.Add(region.ToString());

            return regions;
        }
    }

    public class Account
    {
        public String Name;
        public String Password;

        public Region Region;

        public Account(String name, String password, Region region)
        {
            this.Name = name;
            this.Password = password;
            this.Region = region;
        }

        public static Region ParseRegionString(String regionString)
        {
            return (Region) Enum.Parse(typeof(Region), regionString);
        }

        public static PVPNetConnect.Region GetPVPNetRegion(Region region)
        {
            switch (region)
            {
                case Region.BR:
                    return PVPNetConnect.Region.BR;
                case Region.EUNE:
                    return PVPNetConnect.Region.EUN;
                case Region.EUW:
                    return PVPNetConnect.Region.EUW;
                case Region.KR:
                    return PVPNetConnect.Region.KR;
                case Region.NA:
                    return PVPNetConnect.Region.NA;
                case Region.OCE:
                    return PVPNetConnect.Region.OCE;
                case Region.TR:
                    return PVPNetConnect.Region.TR;
                default:
                    throw new Exception("Unknown region!");
            }
        }
    }

    public enum Region
    {
        NA,
        EUW,
        EUNE,
        BR,
        KR,
        TR,
        OCE,
    }
}
