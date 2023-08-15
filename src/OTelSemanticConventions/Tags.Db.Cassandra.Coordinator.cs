namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Db
    {
        public static partial class Cassandra
        {
            public static partial class Coordinator
            {
                public const string Prefix = "db.cassandra.coordinator";

                /// <summary>
                /// The ID of the coordinating node for a query.
                /// </summary>
                public const string Id = $"{Prefix}.coordinator.id";

                /// <summary>
                /// The data center of the coordinating node for a query.
                /// </summary>
                public const string Dc = $"{Prefix}.coordinator.dc";
            }
        }
    }
}
