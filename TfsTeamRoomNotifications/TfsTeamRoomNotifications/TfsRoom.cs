using System;
using System.Net;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace TfsTeamRoomNotifications
{
    public class TfsRoom
    {
        public bool busy = false;

        // TODO - REMOVE.  properties for initial testing.
        private string project = "{myVstsProject}";
        private string username = "";
        private string password = "{MyPersonalAccessToken}";
        private string roomId = "{MyRoomNumber}";


        public async Task<string> checkData()
        {
            busy = true;
            try
            {
                //var sUrl = VstsCall.RecentMessagesUrl(project, roomId);
                var sUrl = VstsCall.MessagesSinceUrl(project, roomId, DateTime.Now.AddDays(-1));

                //var rtn = await Helper.GetJsonDataAsString(sUrl);
                var rtn = await Helper.GetJsonDataAsString(sUrl, username, password);
                dynamic messages = JObject.Parse(rtn);
                for (int i = 0; i < (int)messages.count; i++)
                {
                    Console.Write(messages.value[i].postedTime);
                    dynamic content = JObject.Parse((string)messages.value[i].content);
                    if (content.type == "GitPushEvent")
                    {
                        Console.Write(string.Format(" - {0} pushed commit to {1}",
                            content.data.pusherDisplayName,
                            content.data.refName));
                    }
                    else
                    {
                        Console.Write(" - Specific msg not implemented");
                    }
                    Console.WriteLine();
                }
                return rtn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine(ex.InnerException);
                return "";
            }
            finally
            {
                busy = false;
            }
        }

        public async Task<string> listRooms()
        {
            busy = true;
            try
            {
                var sUrl = VstsCall.RoomListUrl(project);
                var rtn = await Helper.GetJsonDataAsString(sUrl);
                dynamic rooms = JObject.Parse(rtn);
                for (int i = 0; i < (int)rooms.count; i++)
                {
                    Console.WriteLine(rooms.value[i].name);
                }
                return rtn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine(ex.InnerException);
                return "";
            }
            finally
            {
                busy = false;
            }
        }
    }
}
