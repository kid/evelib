﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using eZet.Eve.EveApi;

namespace eZet.Eve.EveApi.Dto.EveApi {
    public abstract class XmlResult {

        public virtual void SetApiKey(ApiKey key) {

        }

    }
}