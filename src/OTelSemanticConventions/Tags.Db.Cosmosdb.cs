namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Db
    {
        public static partial class Cosmosdb
        {
            public const string Prefix = "db.cosmosdb";

            /// <summary>
            /// Unique Cosmos client instance id.
            /// </summary>
            public const string ClientId = $"{Prefix}.client_id";

            /// <summary>
            /// CosmosDB Operation Type.
            /// </summary>
            public const string OperationType = $"{Prefix}.operation_type";

            /// <summary>
            /// Cosmos client connection mode.
            /// </summary>
            public const string ConnectionMode = $"{Prefix}.connection_mode";

            /// <summary>
            /// Cosmos DB container name.
            /// </summary>
            public const string Container = $"{Prefix}.container";

            /// <summary>
            /// Request payload size in bytes
            /// </summary>
            public const string RequestContentLength = $"{Prefix}.request_content_length";

            /// <summary>
            /// Cosmos DB status code.
            /// </summary>
            /// <example>
            /// e.g. <c>200</c>, <c>201</c>
            /// </example>
            public const string StatusCode = $"{Prefix}.status_code";

            /// <summary>
            /// Cosmos DB sub status code.
            /// </summary>
            /// <example>
            /// e.g. <c>1000</c>, <c>1002</c>
            /// </example>
            public const string SubStatusCode = $"{Prefix}.sub_status_code";

            /// <summary>
            /// RU consumed for that operation
            /// </summary>
            /// <example>
            /// e.g. <c>46.18</c>, <c>1.0</c>
            /// </example>
            public const string RequestCharge = $"{Prefix}.request_charge";

            /// <summary>
            /// Value of the [HTTP User-Agent](https://www.rfc-editor.org/rfc/rfc9110.html#field.user-agent) header sent by the client.
            /// </summary>
            /// <example>
            /// e.g. <c>CERN-LineMode/2.15 libwww/2.17b3</c>
            /// </example>
            public const string Original = $"{Prefix}.user_agent.original";
        }
    }
}
