using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLibrary.DTO
{
   public class MsgBoxReq
    {
        public string Caption { get; set; }

        public string Message { get; set; }

        public ImageAction Image { get; set; }
    }

    public enum ImageAction
    {
        Error=0,
        Warning =1,
        Info =2
    }



}
