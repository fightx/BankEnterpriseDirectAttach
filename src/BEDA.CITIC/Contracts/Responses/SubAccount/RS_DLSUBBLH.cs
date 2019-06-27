﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 附属账户历史余额查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLSUBBLH : RsBase
    {
        /// <summary>
        /// 主体账号 char(19)
        /// </summary>
        [XmlElement("mainAccNo")]
        public string MainAccNo { get; set; }
        /// <summary>
        /// 主体账户名称 varchar(122)
        /// </summary>
        [XmlElement("mainAccNm")]
        public string MainAccNm { get; set; }
        /// <summary>
        /// 附属账号 char(19)
        /// </summary>
        [XmlElement("subAccNo")]
        public string SubAccNo { get; set; }
        /// <summary>
        /// 附属账户名称 varchar(122)
        /// </summary>
        [XmlElement("subAccNm")]
        public string SubAccNm { get; set; }
        /// <summary>
        /// 开户网点 varchar(122)
        /// </summary>
        [XmlElement("mngNode")]
        public string MngNode { get; set; }
        /// <summary>
        /// 币种 char(2)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<SubAccountBalanceHistory> List { get; set; }
    }
    /// <summary>
    /// 附属账户历史余额
    /// </summary>
    public class SubAccountBalanceHistory
    {
        /// <summary>
        /// 日期 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime Date { get; set; }
        /// <summary>
        /// 日期 char(8) 格式YYYYMMDD, 对应<see cref="Date"/>
        /// </summary>
        [XmlElement("date")]
        public string DateStr
        {
            get
            {
                return this.Date.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.Date = tmp;
                }
            }
        }
        /// <summary>
        /// 账户余额 decimal(15,2)
        /// </summary>
        [XmlElement("balance")]
        public decimal Balance { get; set; }

    }
}
