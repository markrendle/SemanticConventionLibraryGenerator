namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Process
    {
        public const string Prefix = "process";

        /// <summary>
        /// Process identifier (PID).
        /// </summary>
        /// <example>
        /// e.g. <c>1234</c>
        /// </example>
        public const string Pid = $"{Prefix}.pid";

        /// <summary>
        /// Parent Process identifier (PID).
        /// </summary>
        /// <example>
        /// e.g. <c>111</c>
        /// </example>
        public const string ParentPid = $"{Prefix}.parent_pid";

        /// <summary>
        /// The command used to launch the process (i.e. the command name). On Linux based systems, can be set to the zeroth string in `proc/[pid]/cmdline`. On Windows, can be set to the first parameter extracted from `GetCommandLineW`.
        /// </summary>
        /// <example>
        /// e.g. <c>cmd/otelcol</c>
        /// </example>
        public const string Command = $"{Prefix}.command";

        /// <summary>
        /// The full command used to launch the process as a single string representing the full command. On Windows, can be set to the result of `GetCommandLineW`. Do not set this if you have to assemble it just for monitoring; use `process.command_args` instead.
        /// </summary>
        /// <example>
        /// e.g. <c>C:\cmd\otecol --config="my directory\config.yaml"</c>
        /// </example>
        public const string CommandLine = $"{Prefix}.command_line";

        /// <summary>
        /// All the command arguments (including the command/executable itself) as received by the process. On Linux-based systems (and some other Unixoid systems supporting procfs), can be set according to the list of null-delimited strings extracted from `proc/[pid]/cmdline`. For libc-based executables, this would be the full argv vector passed to `main`.
        /// </summary>
        /// <example>
        /// e.g. <c>cmd/otecol</c>, <c>--config=config.yaml</c>
        /// </example>
        public const string CommandArgs = $"{Prefix}.command_args";

        /// <summary>
        /// The username of the user that owns the process.
        /// </summary>
        public const string Owner = $"{Prefix}.owner";
    }
}
