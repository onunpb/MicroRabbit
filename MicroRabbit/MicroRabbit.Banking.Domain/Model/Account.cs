﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountType { get; set; }
        public string AccountBalance { get; set; }
    }
}
