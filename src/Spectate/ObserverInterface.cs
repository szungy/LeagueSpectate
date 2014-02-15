using PVPNetConnect;
using PVPNetConnect.RiotObjects.Platform.Catalog.Champion;
using PVPNetConnect.RiotObjects.Platform.Clientfacade.Domain;
using PVPNetConnect.RiotObjects.Platform.Game;
using PVPNetConnect.RiotObjects.Platform.Summoner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spectate
{
    class ObserverInterface
    {
        public static async Task<ObserverResult> GetObserverInformation(String Summoner, Account account)
        {
            try
            {
                PVPNetConnection conn = new PVPNetConnection();

                try
                {
                    await Task.Run(() =>
                    {
                        conn.Connect(account.Name, account.Password, Account.GetPVPNetRegion(account.Region), MainForm.GameVersion);
                    });
                }
                catch
                {
                    return new ObserverResult(ObserverResultStatus.ConectionProblem);
                }

                ((MainForm)MainForm.ActiveForm).StatusUpdate("Connected...");

                PlatformGameLifecycleDTO res = (await conn.RetrieveInProgressSpectatorGameInfo(Summoner));

                if (res.PlayerCredentials == null)
                    return new ObserverResult(ObserverResultStatus.NotInGame);

                List<String> observerInfos = new List<String>();

                observerInfos.Add(res.PlayerCredentials.ObserverServerIp + ":" + res.PlayerCredentials.ObserverServerPort);
                observerInfos.Add(res.PlayerCredentials.ObserverEncryptionKey);
                observerInfos.Add(res.PlayerCredentials.GameId.ToString());

                if (conn != null && conn.IsConnected())
                    conn.Disconnect();

                return new ObserverResult(ObserverResultStatus.Successful, observerInfos);
            }
            catch
            {
                return new ObserverResult(ObserverResultStatus.UnknownFail);
            }
        }

        public static async Task<Double> TestAccount(Account account)
        {
            PVPNetConnection conn = new PVPNetConnection();
            LoginDataPacket packet = null;

            try
            {
                await Task.Run(() =>
                {
                    conn.Connect(account.Name, account.Password, Account.GetPVPNetRegion(account.Region), MainForm.GameVersion);
                });                
            }
            catch
            {
                if (conn != null && conn.IsConnected())
                    conn.Disconnect();

                return -1D;
            }

            try
            {
                packet = await conn.GetLoginDataPacketForUser();
            }
            catch
            {
                if (conn != null && conn.IsConnected())
                    conn.Disconnect();

                return -1D;
            }

            if (conn != null && conn.IsConnected())
                conn.Disconnect();

            return packet.IpBalance;
        }
    }

    class ObserverResult
    {
        public ObserverResultStatus Status;
        public List<String> ObserverData = new List<String>();

        public ObserverResult(ObserverResultStatus status)
        {
            this.Status = status;
        }

        public ObserverResult(ObserverResultStatus status, List<String> observerData)
        {
            this.Status = status;
            this.ObserverData = observerData;
        }
    }

    enum ObserverResultStatus
    {
        ConectionProblem,
        NotInGame,
        Successful,
        UnknownFail
    }
}
