namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Code
    {
        public const string Prefix = "code";

        /// <summary>
        /// The method or function name, or equivalent (usually rightmost part of the code unit's name).
        /// </summary>
        public const string Function = $"{Prefix}.function";

        /// <summary>
        /// The "namespace" within which `code.function` is defined. Usually the qualified class or module name, such that `code.namespace` + some separator + `code.function` form a unique identifier for the code unit.
        /// </summary>
        public const string Namespace = $"{Prefix}.namespace";

        /// <summary>
        /// The source code file name that identifies the code unit as uniquely as possible (preferably an absolute file path).
        /// </summary>
        public const string Filepath = $"{Prefix}.filepath";

        /// <summary>
        /// The line number in `code.filepath` best representing the operation. It SHOULD point within the code unit named in `code.function`.
        /// </summary>
        public const string Lineno = $"{Prefix}.lineno";

        /// <summary>
        /// The column number in `code.filepath` best representing the operation. It SHOULD point within the code unit named in `code.function`.
        /// </summary>
        public const string Column = $"{Prefix}.column";
    }
}
