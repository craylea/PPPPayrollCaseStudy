﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollCaseStudy.Domain {
    public class CommissionedClassification : PaymentClassification{
        private decimal _salary;

        public decimal Salary {
            get { return _salary; }
        }
        private decimal _commissionRate;

        public decimal CommissionRate {
            get { return _commissionRate; }
        }

        public CommissionedClassification(decimal salary,decimal commissionRate) {
            _salary = salary;
            _commissionRate = commissionRate;
        }
    }
}