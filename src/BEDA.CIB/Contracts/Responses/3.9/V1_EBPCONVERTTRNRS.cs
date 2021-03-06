﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.3.3电子商业汇票质押托管转换响应主体
    /// </summary>
    public class V1_EBPCONVERTTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.3电子商业汇票质押托管转换响应主体
        /// </summary>
        public EBPCONVERTTRNRS EBPCONVERTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.3电子商业汇票质押托管转换响应主体
    /// </summary>
    public class EBPCONVERTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.3电子商业汇票质押托管转换响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPCONVERTTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.3电子商业汇票质押托管转换响应内容
    /// </summary>
    public class EBPCONVERTTRN_RSBODY
    {
        /// <summary>
        /// 转换类型 ，0-质押转托管 1-托管转质押	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string CONVERTTYPE { get; set; }
        /// <summary>
        /// 票据总笔数	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public int TOTALCOUNT { get; set; }
        /// <summary>
        /// 票据总金额（18,2） 	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TOTALAMT { get; set; }
        /// <summary>
        /// 3.9.3.3电子商业汇票质押托管转换响应集合	必回
        /// </summary>
        [XmlElement("CONTENT", Order = 10)]
        public List<Requests.EBPCONVERTTRN_CONTENT> List { get; set; }
        /// <summary>
        /// 指令处理节点
        /// </summary>
        [XmlElement(Order = 20)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
