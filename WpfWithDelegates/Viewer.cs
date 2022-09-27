using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWithDelegates
{
    public class Viewer : YTSubscriber
    {

        public override string ShowUserInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------------");
            sb.AppendLine($"FN:{FirstName} LN:{LastName}");
            sb.AppendLine($"Cell:{CellPhone}");
            sb.AppendLine("----------------------");
            return (sb.ToString());
        }

    }
}
