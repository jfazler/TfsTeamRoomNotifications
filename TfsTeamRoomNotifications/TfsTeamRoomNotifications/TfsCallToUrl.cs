using System;
using System.Collections.Generic;

namespace TfsTeamRoomNotifications
{
    static public class VstsCall
    {
        public static string RoomListUrl(string project)
        {
            string urlFormat = @"https://{0}.visualstudio.com/DefaultCollection/_apis/chat/rooms?api-version=1.0";
            return string.Format(urlFormat, project);
        }

        public static string RecentMessagesUrl(string project, string roomId)
        {
            string urlFormat = @"https://{0}.visualstudio.com/DefaultCollection/_apis/chat/rooms/{1}/messages?api-version=1.0";
            return string.Format(urlFormat, project, roomId);
        }

        public static string MessagesSinceUrl(string project, string roomId, DateTime sinceDate)
        {
            const string DATE_FORMAT = "MM/dd/yyyy";
            string date = sinceDate.ToString(DATE_FORMAT);
            string tomorrow = DateTime.Now.AddDays(1).ToString(DATE_FORMAT);
            string urlFormat = @"https://{0}.visualstudio.com/DefaultCollection/_apis/chat/rooms/{1}/messages?$filter=PostedTime ge {2} and PostedTime lt {3}&api-version=1.0";
            // WORKS - string urlFormat = @"https://{0}.visualstudio.com/DefaultCollection/_apis/chat/rooms/{1}/messages?$filter=PostedTime ge 10/26/2016 and PostedTime lt 10/28/2016&api-version=1.0";
            // FAILS - have to spec lt too.  string urlFormat = @"https://{0}.visualstudio.com/DefaultCollection/_apis/chat/rooms/{1}/messages?$filter=PostedTime ge 10/26/2016&api-version=1.0";
            // DOES not return data.  Can't spec time. (Also tried ISO format)  string urlFormat = @"https://{0}.visualstudio.com/DefaultCollection/_apis/chat/rooms/{1}/messages?$filter=PostedTime ge 10/25/2016 00:00:00 and PostedTime lt 10/28/2016&api-version=1.0";
            // FAILS - can't filter by id.  string urlFormat = @"https://{0}.visualstudio.com/DefaultCollection/_apis/chat/rooms/{1}/messages?$filter=Id ge 85850&api-version=1.0";
            return string.Format(urlFormat, project, roomId, date, tomorrow);
        }

    }
}
