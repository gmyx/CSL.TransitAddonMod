﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Transit.Framework.Redirection;

namespace CSL_Traffic
{
    public class PathFindHook : PathFind
    {
        [RedirectFrom(typeof(PathFind))]
        private void Awake()
        {
            // Disabling the Awake method
        }

        [RedirectFrom(typeof(PathFind))]
        private void OnDestroy()
        {
            // Disabling the Awake method
        }
    }
}
