using System;
using System.Collections.Generic;
using System.Text;

namespace WpfWithDelegates
{
    public abstract class YTSubscriber
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CellPhone { get; set; }

        public List<string>? Languages { get; set; }

        public virtual String ShowUserInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("User:");
            sb.AppendLine("----------------------");
            sb.AppendLine($"{FirstName} {LastName}");
            sb.AppendLine($"{CellPhone}");
            return (sb.ToString());
        }
    }
}
