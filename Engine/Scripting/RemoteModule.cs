﻿using System;

namespace WallApp.Scripting
{
    class RemoteModule : Module
    {
        public override Controller CreateController()
        {
            throw new NotImplementedException();
        }

        public override object CreateViewModel(LayerSettings settings)
        {
            throw new NotImplementedException();
        }

        protected override void Initialize()
        {
        }
    }
}
