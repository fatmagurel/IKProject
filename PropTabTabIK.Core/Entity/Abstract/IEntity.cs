﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PropTabTabIK.Core.Entity.Abstract
{
    public interface IEntity<T>
    {
        T ID { get; set; }

    }
}
