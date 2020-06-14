using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Database
{
    public static class Types
    {
        public enum Setor
        {
            [Description("Saúde")]
            Saude,
            [Description("Consumo Cíclico")]
            ConsumoCiclico
        }

        public enum SubSetor
        {
            [Description("Saúde")]
            Saude,
            [Description("Consumo Cíclico")]
            ConsumoCiclico
        }

        public enum Segmento
        {
            [Description("Saúde")]
            Saude,
            [Description("Consumo Cíclico")]
            ConsumoCiclico
        }

        
        //To Do - fazer uma função só
        public static string ToDescriptionString(this Setor val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
                .GetType()
                .GetField(val.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }

        public static string ToDescriptionString(this Segmento val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
                .GetType()
                .GetField(val.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }

        public static string ToDescriptionString(this SubSetor val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
                .GetType()
                .GetField(val.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }

    }
}
