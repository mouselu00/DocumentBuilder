using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilder
{
    public class Helper
    {
        /// <summary>
        /// 取得日期：yyyyMMDD
        /// </summary>
        /// <returns></returns>
        public string getDataYYYYMMDD()
        {
            return DateTime.Now.ToString("yyyyMMdd");
        }
    }
}
