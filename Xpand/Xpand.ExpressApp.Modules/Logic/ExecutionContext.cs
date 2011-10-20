﻿using System;

namespace Xpand.ExpressApp.Logic {
    [Flags]
    public enum ExecutionContext {
        None = 0,
        ViewChanging = 2,
        ObjectChanged = 4,
        ObjectSpaceReloaded = 8,
        CurrentObjectChanged = 16,
        ViewControlsCreated = 32,
        ControllerActivated = 64,
        ViewChanged = 128,
        TemplateViewChanged = 256,
        ObjectSpaceCommited = 512,
        CustomProcessSelectedItem = 1024,
        ControlsCreating = 2048,
        ViewOnSelectionChanged = 4096,
        NotifyPropertyObjectChanged = 8192
    }
}