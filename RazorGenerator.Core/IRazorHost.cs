﻿using System;
using System.Collections.Generic;

namespace RazorGenerator.Core
{
    public interface IRazorHost
    {
        string DefaultNamespace { get; set; }

        bool EnableLinePragmas { get; set; }

        event EventHandler<GeneratorErrorEventArgs> Error;

        event EventHandler<ProgressEventArgs> Progress;

        string GenerateCode();
    }
}
