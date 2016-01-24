# ScriptCs.CompileOnlyOption

## What is it?
This is a [scriptcs](https://github.com/scriptcs/scriptcs) module that allows you to compile only your script files. ScriptCs.CompileOnlyOption is useful when you want to execute a cached version of a script file which leads to improved performance.

## Common usage
From the command line execute:
```
scriptcs <script-file> -modules compile-only-option -cache -- compile-only
```

This is it! Your script won't be executed - just compiled and saved in the `.scriptcs_cache` folder in your working directory. So the next time you execute `scriptcs <script-file> -cache` your script will be executed from the cache - scriptcs won't build it again in the memory thus improving startup performance.
