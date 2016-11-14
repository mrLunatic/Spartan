﻿using NetAudioPlayer.Core.Model;
using Newtonsoft.Json;

namespace NetAudioPlayer.Core.Data
{
    /// <summary>
    /// Альбом
    /// </summary>
    public class Album : Item
    {
        public const string ArtistIdField = @"artistId";

        public const string YearField = @"year";

        public const string TracksCountField = @"tracksCount";

        public const int DefaultId = 0;

        /// <summary>
        /// Идентификатор исполнителя
        /// </summary>
        [JsonProperty(ArtistIdField)]
        public int ArtistId { get; set; }

        /// <summary>
        /// Год выпуска альбома
        /// </summary>
        [JsonProperty(YearField)]
        public int Year { get; set; }

        /// <summary>
        /// Количество песен в альбоме
        /// </summary>
        [JsonProperty(TracksCountField)]
        public int TracksCount { get; set; }
    }
}
