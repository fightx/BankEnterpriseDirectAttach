﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 8.4.2.活期转定期经办请求响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_4_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCTFOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCTFOPR";
        /// <summary>
        /// 8.4.2.活期转定期经办请求响应内容
        /// </summary>
        public NTCTFOPRZ NTCTFOPRZ { get; set; }
    }
    /// <summary>
    /// 8.4.2.活期转定期经办请求响应内容
    /// </summary>
    public class NTCTFOPRZ
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 定期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTDAT { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="INTDAT"/>
        /// </summary>
        [XmlElement("INTDAT")]
        public string INTDATStr
        {
            get
            {
                return this.INTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="EXPDAT"/>
        /// </summary>
        [XmlElement("EXPDAT")]
        public string EXPDATStr
        {
            get
            {
                return this.EXPDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
