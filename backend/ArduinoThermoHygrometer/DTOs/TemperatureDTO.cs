﻿using System.ComponentModel.DataAnnotations;

namespace ArduinoThermoHygrometer.DTOs;

public record TemperatureDto
{
    [Required]
    [StringLength(10)]
    public string Temp { get; set; } = default!;

    [Required]
    [StringLength(10)]
    public string AirHumidity { get; set; } = default!;
}
