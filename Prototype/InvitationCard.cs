using System;

namespace Prototype
{
    internal class InvitationCard
    {
        public string To { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string SendBy { get; set; }
        public DateTime Date { get; set; }

        public InvitationCard CloneMe(InvitationCard Obj)
        {
            return (InvitationCard)this.MemberwiseClone();
        }

        //note: Object.MemberwiseClone is a .NET integrated Function
        //https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-8.0


    }
}
