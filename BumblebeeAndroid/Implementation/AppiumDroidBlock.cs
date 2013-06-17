﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;
using OpenQA.Selenium;

namespace BumblebeeAndroid.Implementation
{
    public class AppiumDroidBlock : Block
    {
        public AppiumDroidBlock(Session session) : base(session)
        {
        }

        public override IPerformsDragAndDrop GetDragAndDropPerformer()
        {
            return new AndroidDragAndDrop(Session.Driver);
        }
    }
}
