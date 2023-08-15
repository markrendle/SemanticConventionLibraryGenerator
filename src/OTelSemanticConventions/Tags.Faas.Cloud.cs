namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Faas
    {
        public static partial class Cloud
        {
            public const string Prefix = "faas.cloud";

            /// <summary>
            /// Cloud provider-specific native identifier of the monitored cloud resource (e.g. an [ARN](https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html) on AWS, a [fully qualified resource ID](https://learn.microsoft.com/en-us/rest/api/resources/resources/get-by-id) on Azure, a [full resource name](https://cloud.google.com/apis/design/resource_names#full_resource_name) on GCP)
            /// </summary>
            /// <remarks>
            /// On some cloud providers, it may not be possible to determine the full ID at startup,
            /// so it may be necessary to set `cloud.resource_id` as a span attribute instead. The
            /// exact value to use for `cloud.resource_id` depends on the cloud provider. The following
            /// well-known definitions MUST be used if you set this attribute and they apply: * **AWS
            /// Lambda:** The function [ARN](https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html).
            /// Take care not to use the "invoked ARN" directly but replace any [alias suffix](https://docs.aws.amazon.com/lambda/latest/dg/configuration-aliases.html)
            /// with the resolved function version, as the same runtime instance may be invokable
            /// with multiple different aliases. * **GCP:** The [URI of the resource](https://cloud.google.com/iam/docs/full-resource-names)
            /// * **Azure:** The [Fully Qualified Resource ID](https://docs.microsoft.com/en-us/rest/api/resources/resources/get-by-id)
            /// of the invoked function, *not* the function app, having the form `/subscriptions/<SUBSCIPTION_GUID>/resourceGroups/<RG>/providers/Microsoft.Web/sites/<FUNCAPP>/functions/<FUNC>`.
            /// This means that a span attribute MUST be used, as an Azure function app can host
            /// multiple functions that would usually share a TracerProvider.
            /// </remarks>
            /// <example>
            /// e.g. <c>arn:aws:lambda:REGION:ACCOUNT_ID:function:my-function</c>, <c>//run.googleapis.com/projects/PROJECT_ID/locations/LOCATION_ID/services/SERVICE_ID</c>, <c>/subscriptions/<SUBSCIPTION_GUID>/resourceGroups/<RG>/providers/Microsoft.Web/sites/<FUNCAPP>/functions/<FUNC></c>
            /// </example>
            public const string ResourceId = $"{Prefix}.cloud.resource_id";
        }
    }
}
