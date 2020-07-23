﻿using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ExamenFinal.DB.Map
{
    public class GastoMap : EntityTypeConfiguration<Gasto>

            HasRequired(o => o.Cuenta)
            .WithMany(o => o.Gastos)
            .HasForeignKey(o => o.IdCuenta);