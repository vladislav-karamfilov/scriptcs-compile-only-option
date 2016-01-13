namespace ScriptCs.CompileOnlyOption
{
    using System;
    using System.Collections.Generic;

    using ScriptCs.Contracts;

    using ILog = Common.Logging.ILog;

    public class CompileOnlyOptionFilePreProcessor : FilePreProcessor
    {
        private const string CompileOnlyArgumentName = "compile-only";

        [Obsolete]
        public CompileOnlyOptionFilePreProcessor(
            IFileSystem fileSystem,
            ILog logger,
            IEnumerable<ILineProcessor> lineProcessors)
            : base(fileSystem, logger, lineProcessors)
        {
        }

        public CompileOnlyOptionFilePreProcessor(
            IFileSystem fileSystem,
            ILogProvider logProvider,
            IEnumerable<ILineProcessor> lineProcessors)
            : base(fileSystem, logProvider, lineProcessors)
        {
        }

        protected override FilePreProcessorResult Process(Action<FileParserContext> parseAction)
        {
            var result = base.Process(parseAction);

            result.Code =
$@"if (Env.ScriptArgs.All(arg => !string.Equals(arg, ""{CompileOnlyArgumentName}"", StringComparison.OrdinalIgnoreCase)))
{{
    {result.Code}
}}";

            return result;
        }
    }
}
