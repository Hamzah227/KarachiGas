using System.Collections.Generic;
using System.Text;

namespace Karachi_Gas
{
    class ErrorResponse
    {
        public bool Error { get; set; }
        public List<ErrorList> ErrorList { get; set; }

        public ErrorResponse()
        {
            ErrorList = new List<ErrorList>();
        }

        public string getErrorMessage()
        {
            StringBuilder sb = new StringBuilder();

            if (this.ErrorList != null)
            {
                foreach (ErrorList item in this.ErrorList)
                    sb.AppendLine(item.Message);
            }

            return sb.ToString();
        }
    }

    public class ErrorList
    {
        public int ErrorCode { get; set; }
        public string Message { get; set; }
        public string ErrorType { get; set; }
        public Level WarningLevel { get; set; }
        public string Description { get; set; }
    }

    public enum Level
    {
        Error,
        Warning,
        Information
    }
}

