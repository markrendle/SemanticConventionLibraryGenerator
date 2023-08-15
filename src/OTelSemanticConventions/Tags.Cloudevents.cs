namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Cloudevents
    {
        public const string Prefix = "cloudevents";

        /// <summary>
        /// The [event_id](https://github.com/cloudevents/spec/blob/v1.0.2/cloudevents/spec.md#id) uniquely identifies the event.
        /// </summary>
        /// <example>
        /// e.g. <c>123e4567-e89b-12d3-a456-426614174000</c>, <c>0001</c>
        /// </example>
        public const string EventId = $"{Prefix}.event_id";

        /// <summary>
        /// The [source](https://github.com/cloudevents/spec/blob/v1.0.2/cloudevents/spec.md#source-1) identifies the context in which an event happened.
        /// </summary>
        /// <example>
        /// e.g. <c>https://github.com/cloudevents</c>, <c>/cloudevents/spec/pull/123</c>, <c>my-service</c>
        /// </example>
        public const string EventSource = $"{Prefix}.event_source";

        /// <summary>
        /// The [version of the CloudEvents specification](https://github.com/cloudevents/spec/blob/v1.0.2/cloudevents/spec.md#specversion) which the event uses.
        /// </summary>
        public const string EventSpecVersion = $"{Prefix}.event_spec_version";

        /// <summary>
        /// The [event_type](https://github.com/cloudevents/spec/blob/v1.0.2/cloudevents/spec.md#type) contains a value describing the type of event related to the originating occurrence.
        /// </summary>
        /// <example>
        /// e.g. <c>com.github.pull_request.opened</c>, <c>com.example.object.deleted.v2</c>
        /// </example>
        public const string EventType = $"{Prefix}.event_type";

        /// <summary>
        /// The [subject](https://github.com/cloudevents/spec/blob/v1.0.2/cloudevents/spec.md#subject) of the event in the context of the event producer (identified by source).
        /// </summary>
        public const string EventSubject = $"{Prefix}.event_subject";
    }
}
