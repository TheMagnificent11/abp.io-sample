﻿using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Acme.ClubManagement.EntityFrameworkCore;

public class NullableDateOnlyConverter : ValueConverter<DateOnly?, DateTime?>
{
    public NullableDateOnlyConverter()
        : base(
            d => d == null
                ? null
                : new DateTime?(d.Value.ToDateTime(TimeOnly.MinValue)),
            d => d == null
                ? null
                : new DateOnly?(DateOnly.FromDateTime(d.Value)))
    {
    }
}
