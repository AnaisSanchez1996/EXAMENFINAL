using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ExamenFinal.DB.Map
{
    public class CuentaMap : EntityTypeConfiguration<Cuenta>    {        public CuentaMap()        {            ToTable("Cuenta");            HasKey(o => o.IdCuenta);        }    }}
