﻿using System;

namespace PcapVisualizer.Model
{
    public class Packet
    {
        public Packet(){}
        // пакет, который отображается в списке пакетов.
        // протокол, время, адрес отправителя, адрес получателя, размер
        // два поля - свойства и данные, как в вайршарке
        public string SourceAdress { get; set; }
        public string SourcePort { get; set; }
        public string DestinationAddress { get; set; }
        public string DestinationPort { get; set; }
        public string Protocol { get; set; }

        /// <summary>
        /// Данные, находящиеся в пакете
        /// </summary>
        public byte[] Data { get; set; }

        /// <summary>
        /// Прочие данные из заголовка пакета
        /// </summary>
        public string Header { get; set; }

        public DateTime TimeStamp { get; set; }
        public int Length { get; set; }
    }
}
