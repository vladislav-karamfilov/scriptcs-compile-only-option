namespace ScriptCs.CompileOnlyOption
{
    using System;

    using ScriptCs.Contracts;

    [Module("CompileOnlyOption", Extensions = "csx")]
    public class CompileOnlyOptionModule : IModule
    {
        public void Initialize(IModuleConfiguration config)
        {
            if (config == null)
            {
                throw new ArgumentNullException(nameof(config));
            }
            
            config.FilePreProcessor<CompileOnlyOptionFilePreProcessor>();
        }
    }
}
