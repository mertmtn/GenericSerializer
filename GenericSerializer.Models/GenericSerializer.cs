using GenericSerializer.Base;
using GenericSerializer.DataFormat;
using GenericSerializer.Models.Enums;
using System;

namespace GenericSerializer.Models
{
    public static class GenericSerializer<T>
    { 

        public static IGenericSerializer<T> CreateSerializerObject(DataFormatType dataFormat)
        {
            IGenericSerializer<T> serializer;
            switch (dataFormat)
            {
                case DataFormatType.XML:
                    serializer = new XmlGenericSerializer<T>(); 
                    break;
                case DataFormatType.JSON:
                    serializer = new JsonGenericSerializer<T>(); 
                    break;
                default:
                    throw new NotSupportedException(); 
            }

            return serializer;
        }
    }
}

