namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Db
    {
        public static partial class Mongodb
        {
            public const string Prefix = "db.mongodb";

            /// <summary>
            /// The collection being accessed within the database stated in `db.name`.
            /// </summary>
            /// <example>
            /// e.g. <c>customers</c>, <c>products</c>
            /// </example>
            public const string Collection = $"{Prefix}.collection";
        }
    }
}
