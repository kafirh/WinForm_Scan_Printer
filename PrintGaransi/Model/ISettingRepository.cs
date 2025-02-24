﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPackingLabel.Model
{
    public interface ISettingRepository
    {
        List<string> GetData();
        int GetID(string locationName);
    }
}
