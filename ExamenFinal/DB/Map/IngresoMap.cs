﻿using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ExamenFinal.DB.Map
{
    public class IngresoMap : EntityTypeConfiguration<Ingreso>    {        public IngresoMap()        {            ToTable("Ingreso");            HasKey(o => o.IdIngreso);

            //Relaciones

            HasRequired(o => o.Cuenta)
                    .WithMany(o => o.Ingresos)
                    .HasForeignKey(o => o.IdCuenta);        }    }}
