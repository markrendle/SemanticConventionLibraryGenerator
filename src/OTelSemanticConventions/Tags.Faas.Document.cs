namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Faas
    {
        public static partial class Document
        {
            public const string Prefix = "faas.document";

            /// <summary>
            /// The name of the source on which the triggering operation was performed. For example, in Cloud Storage or S3 corresponds to the bucket name, and in Cosmos DB to the database name.
            /// </summary>
            /// <example>
            /// e.g. <c>myBucketName</c>, <c>myDbName</c>
            /// </example>
            public const string Collection = $"{Prefix}.collection";

            /// <summary>
            /// Describes the type of the operation that was performed on the data.
            /// </summary>
            public const string Operation = $"{Prefix}.operation";

            /// <summary>
            /// A string containing the time when the data was accessed in the [ISO 8601](https://www.iso.org/iso-8601-date-and-time-format.html) format expressed in [UTC](https://www.w3.org/TR/NOTE-datetime).
            /// </summary>
            public const string Time = $"{Prefix}.time";

            /// <summary>
            /// The document name/table subjected to the operation. For example, in Cloud Storage or S3 is the name of the file, and in Cosmos DB the table name.
            /// </summary>
            /// <example>
            /// e.g. <c>myFile.txt</c>, <c>myTableName</c>
            /// </example>
            public const string Name = $"{Prefix}.name";
        }
    }
}
