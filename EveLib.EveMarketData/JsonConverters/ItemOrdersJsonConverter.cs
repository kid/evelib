﻿using System;
using eZet.EveLib.Modules.Models;
using Newtonsoft.Json;

namespace eZet.EveLib.Modules.JsonConverters {
    public class ItemOrderJsonConverter : JsonConverter {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer) {
            var result = new ItemOrders();
            serializer.Converters.Add(new RowCollectionJsonConverter<ItemOrders.ItemOrderEntry>());
            result.Orders = serializer.Deserialize<EveMarketDataRowCollection<ItemOrders.ItemOrderEntry>>(reader);
            return result;
        }

        public override bool CanConvert(Type objectType) {
            throw new NotImplementedException();
        }
    }
}