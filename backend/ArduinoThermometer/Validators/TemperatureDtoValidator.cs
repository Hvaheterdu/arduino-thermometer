﻿using ArduinoThermometer.API.Models;
using FluentValidation;

namespace ArduinoThermometer.API.Validators;

public class TemperatureDtoValidator : AbstractValidator<Temperature>
{
    public TemperatureDtoValidator()
    {
        RuleFor(t => t.TemperatureGuid).NotEmpty().NotNull();
        RuleFor(t => t.Date).NotEmpty().NotNull().LessThanOrEqualTo(DateTimeOffset.Now.Date);
        RuleFor(t => t.Time).NotEmpty().NotNull().LessThanOrEqualTo(DateTimeOffset.Now.TimeOfDay);
        RuleFor(t => t.Temp).NotEmpty().NotNull();
        RuleFor(t => t.Humidity).NotEmpty().NotNull();
    }
}