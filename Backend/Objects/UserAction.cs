﻿//
// Copyright (c) NickAc. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//
using System;

namespace NickAc.LightPOS.Backend.Objects
{
    public class UserAction
    {
        public enum Action
        {
            Login,
            LogOut,
            UserSale
        }

        public virtual int ID { get; set; }
        public virtual Action Event { get; set; }
        public virtual String Description { get; set; }
    }
}