namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Faas
    {
        public const string Prefix = "faas";

        /// <summary>
        /// The name of the invoked function.
        /// </summary>
        /// <remarks>
        /// SHOULD be equal to the `faas.name` resource attribute of the invoked function.
        /// </remarks>
        public const string InvokedName = $"{Prefix}.invoked_name";

        /// <summary>
        /// The cloud provider of the invoked function.
        /// </summary>
        /// <remarks>
        /// SHOULD be equal to the `cloud.provider` resource attribute of the invoked function.
        /// </remarks>
        public const string InvokedProvider = $"{Prefix}.invoked_provider";

        /// <summary>
        /// The cloud region of the invoked function.
        /// </summary>
        /// <remarks>
        /// SHOULD be equal to the `cloud.region` resource attribute of the invoked function.
        /// </remarks>
        public const string InvokedRegion = $"{Prefix}.invoked_region";

        /// <summary>
        /// The name of the single function that this runtime instance executes.
        /// </summary>
        /// <remarks>
        /// This is the name of the function as configured/deployed on the FaaS platform and
        /// is usually different from the name of the callback function (which may be stored
        /// in the [`code.namespace`/`code.function`](/docs/general/attributes.md#source-code-attributes)
        /// span attributes). For some cloud providers, the above definition is ambiguous. The
        /// following definition of function name MUST be used for this attribute (and consequently
        /// the span name) for the listed cloud providers/products: * **Azure:** The full name
        /// `<FUNCAPP>/<FUNC>`, i.e., function app name followed by a forward slash followed
        /// by the function name (this form can also be seen in the resource JSON for the function).
        /// This means that a span attribute MUST be used, as an Azure function app can host
        /// multiple functions that would usually share a TracerProvider (see also the `cloud.resource_id`
        /// attribute).
        /// </remarks>
        /// <example>
        /// e.g. <c>my-function</c>, <c>myazurefunctionapp/some-function-name</c>
        /// </example>
        public const string Name = $"{Prefix}.name";

        /// <summary>
        /// The immutable version of the function being executed.
        /// </summary>
        /// <remarks>
        /// Depending on the cloud provider and platform, use: * **AWS Lambda:** The [function
        /// version](https://docs.aws.amazon.com/lambda/latest/dg/configuration-versions.html)
        /// (an integer represented as a decimal string). * **Google Cloud Run (Services):**
        /// The [revision](https://cloud.google.com/run/docs/managing/revisions) (i.e., the function
        /// name plus the revision suffix). * **Google Cloud Functions:** The value of the [`K_REVISION`
        /// environment variable](https://cloud.google.com/functions/docs/env-var#runtime_environment_variables_set_automatically).
        /// * **Azure Functions:** Not applicable. Do not set this attribute.
        /// </remarks>
        /// <example>
        /// e.g. <c>26</c>, <c>pinkfroid-00002</c>
        /// </example>
        public const string Version = $"{Prefix}.version";

        /// <summary>
        /// The execution environment ID as a string, that will be potentially reused for other invocations to the same function/function version.
        /// </summary>
        /// <remarks>
        /// * **AWS Lambda:** Use the (full) log stream name.
        /// </remarks>
        /// <example>
        /// e.g. <c>2021/06/28/[$LATEST]2f399eb14537447da05ab2a2e39309de</c>
        /// </example>
        public const string Instance = $"{Prefix}.instance";

        /// <summary>
        /// The amount of memory available to the serverless function converted to Bytes.
        /// </summary>
        /// <remarks>
        /// It's recommended to set this attribute since e.g. too little memory can easily stop
        /// a Java AWS Lambda function from working correctly. On AWS Lambda, the environment
        /// variable `AWS_LAMBDA_FUNCTION_MEMORY_SIZE` provides this information (which must
        /// be multiplied by 1,048,576).
        /// </remarks>
        public const string MaxMemory = $"{Prefix}.max_memory";

        /// <summary>
        /// The invocation ID of the current function invocation.
        /// </summary>
        public const string InvocationId = $"{Prefix}.invocation_id";

        /// <summary>
        /// A string containing the function invocation time in the [ISO 8601](https://www.iso.org/iso-8601-date-and-time-format.html) format expressed in [UTC](https://www.w3.org/TR/NOTE-datetime).
        /// </summary>
        public const string Time = $"{Prefix}.time";

        /// <summary>
        /// A string containing the schedule period as [Cron Expression](https://docs.oracle.com/cd/E12058_01/doc/doc.1014/e12030/cron_expressions.htm).
        /// </summary>
        public const string Cron = $"{Prefix}.cron";

        /// <summary>
        /// A boolean that is true if the serverless function is executed for the first time (aka cold-start).
        /// </summary>
        public const string Coldstart = $"{Prefix}.coldstart";

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
