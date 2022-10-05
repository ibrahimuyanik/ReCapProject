﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator: AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.ModelYear).NotEmpty();
            //RuleFor(c => c.CarName).Must(StartWidthA).WithMessage("Araba A harfi ile başlamalı");
        }


        private bool StartWidthA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
