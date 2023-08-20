﻿using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Zamin.Extensions.Events.Outbox.Dal.EF;

namespace ZaminTemplate.Infra.Data.Sql.Commands.Common;

public class ZaminTemplateCommandDbContext : BaseOutboxCommandDbContext
{
    public ZaminTemplateCommandDbContext(DbContextOptions<ZaminTemplateCommandDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}