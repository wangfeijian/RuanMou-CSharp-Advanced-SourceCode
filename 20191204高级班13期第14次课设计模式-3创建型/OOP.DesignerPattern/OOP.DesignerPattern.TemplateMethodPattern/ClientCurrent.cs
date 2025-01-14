﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DesignerPattern.TemplateMethodPattern
{
    /// <summary>
    /// 银行客户端
    /// </summary>
    public class ClientCurrent : AbstractClient
    {
        /// <summary>
        /// 活期  定期  利率不同
        /// </summary>
        /// <param name="balance"></param>
        /// <returns></returns>
        public override double CalculateInterest(double balance)
        {
            return balance * 0.001;
        }


    }
}
