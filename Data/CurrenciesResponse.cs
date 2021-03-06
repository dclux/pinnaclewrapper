﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PinnacleWrapper.Data
{
    [Serializable]
    [XmlRoot("rsp")]
    public class CurrenciesResponse : XmlResponse
    {
        [XmlArray("currencies")]
        [XmlArrayItem("currency")]
        public List<Currency> Currencies { get; set; }
    }
}
